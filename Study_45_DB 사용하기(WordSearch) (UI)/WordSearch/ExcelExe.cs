using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace WordSearch
{
    class ExcelExe
    {
        public enum enExportType
        {
            EXCEL_COM,
            OLEDB_EXCEL,
            CSV_STREAM,

        }

        public string ExcelExport(string SaveFilePath, DataTable dt, enExportType ExportType )
        {
            string strRet = null;
            switch (ExportType)
            {
                case enExportType.EXCEL_COM:
                    strRet = SaveExcel_COMAP(SaveFilePath, dt);
                    break;
                case enExportType.OLEDB_EXCEL:
                    strRet = SaveExcel_OLEDB(SaveFilePath, dt);
                    break;
                case enExportType.CSV_STREAM:
                    strRet = SaveExcel_CSV(SaveFilePath, dt);
                    break;
                default:
                    strRet = "Code에서 Export Type이 잘못 지정 되었습니다.";
                    break;
            }
            return strRet;
        }

        #region Excel Com API 사용 

        private string SaveExcel_COMAP(string SaveFilePath, DataTable dt)
        {
            string strRet = null;

            // Microsoft.Office.Interop.Excel.Application
            Excel.Application excelApp = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;

            try
            {
                //excel 첫번째 워크시트 가져오기
                excelApp = new Excel.Application();
                wb = excelApp.Workbooks.Add();
                ws = wb.Worksheets.get_Item(1) as Excel.Worksheet;

                //데이터 넣기
                int iRow = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    int iColumn = 1;
                    foreach (var vitem in dr.ItemArray)
                    {
                        ws.Cells[iRow, iColumn] = vitem;
                        iColumn++;
                    }
                    iRow++;
                }

                //엑셀파일 저장 
                wb.SaveAs(SaveFilePath, Excel.XlFileFormat.xlWorkbookNormal);
                wb.Close(true);
                excelApp.Quit();

                strRet = "Excel Export Success !!! ";

            }
            catch (Exception ex)
            {
                strRet = $"Excel Expoert Failed : {ex.ToString()}";
            }
            finally 
            {
                //clean up
                ReleaseExcelObjecgt(ws);
                ReleaseExcelObjecgt(wb);
                ReleaseExcelObjecgt(excelApp);
            }

            return strRet;

        }

        public void ReleaseExcelObjecgt(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }

        #endregion

        #region OleDB 사용

        /// <summary>
        /// OLEDB를 사용해서 Excel Export를 진행
        /// </summary>
        private string SaveExcel_OLEDB(string FilePath, DataTable dt)
        {
            try
            {
                //string ExcelOleDbConnectionStringTemplate = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=YES\";";

                string ExcelOleDbConnectionStringTemplate = "Provider=Microsoft.JET.OLEDB.4.0;data source={0};Extended Properties=\"Excel 8.0;HDR=YES\";";

                string createTableWithHeaderScript = GenerateCreateTableCommand(dt);

                using (var conn = new OleDbConnection(String.Format(ExcelOleDbConnectionStringTemplate, FilePath)))
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    OleDbCommand cmd = new OleDbCommand(createTableWithHeaderScript, conn);
                    cmd.ExecuteNonQuery();

                    foreach (DataRow dataExportRow in dt.Rows)
                    {
                        AddNewRow(conn, dataExportRow);
                    }
                }

                return "Excel Export Success!!!";
            }
            catch (Exception ex)
            {
                return $"Excel Export Failed : {ex.ToString()}";
            }
        }


        //Row 입력
        private static void AddNewRow(OleDbConnection conn, DataRow dataRow)
        {
            string insertCmd = GenerateInsertRowCommand(dataRow);

            using (OleDbCommand cmd = new OleDbCommand(insertCmd, conn))
            {
                AddParametersWithValue(cmd, dataRow);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Row 기준으로 입력 할 Insert Query Command를 생성
        /// </summary>
        private static string GenerateInsertRowCommand(DataRow dataRow)
        {
            var stringBuilder = new StringBuilder();
            var columns = dataRow.Table.Columns.Cast<DataColumn>().ToList();
            var columnNamesCommaSeparated = string.Join(",", columns.Select(x => x.Caption));
            var questionmarkCommaSeparated = string.Join(",", columns.Select(x => "?"));

            stringBuilder.AppendFormat("INSERT INTO [{0}] (", dataRow.Table.TableName);
            stringBuilder.Append(columnNamesCommaSeparated);
            stringBuilder.Append(") VALUES(");
            stringBuilder.Append(questionmarkCommaSeparated);
            stringBuilder.Append(")");
            return stringBuilder.ToString();
        }

        /// <summary>
        /// 값을 가진 변수를 추가
        /// </summary>
        private static void AddParametersWithValue(OleDbCommand cmd, DataRow dataRow)
        {
            var paramNumber = 1;

            for (int i = 0; i <= dataRow.Table.Columns.Count - 1; i++)
            {
                if (!ReferenceEquals(dataRow.Table.Columns[i].DataType, typeof(int)) && !ReferenceEquals(dataRow.Table.Columns[i].DataType, typeof(decimal)))
                {
                    cmd.Parameters.AddWithValue("@p" + paramNumber, dataRow[i].ToString().Replace("'", "''"));
                }
                else
                {
                    object value = GetParameterValue(dataRow[i]);
                    OleDbParameter parameter = cmd.Parameters.AddWithValue("@p" + paramNumber, value);
                    if (value is decimal)
                    {
                        parameter.OleDbType = OleDbType.Currency;
                    }
                }

                paramNumber = paramNumber + 1;
            }
        }

        /// <summary>
        /// OLEDB 형으로 변경
        /// </summary>
        private static object GetParameterValue(object value)
        {
            if (value is string)
            {
                return value.ToString().Replace("'", "''");
            }
            return value;
        }

        // Table Header를 가지고 Table 생성
        private string GenerateCreateTableCommand(DataTable tableDefination)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool firstcol = true;

            stringBuilder.AppendFormat("CREATE TABLE [{0}] (", tableDefination.TableName);

            foreach (DataColumn tableColumn in tableDefination.Columns)
            {
                if (!firstcol)
                {
                    stringBuilder.Append(", ");
                }
                firstcol = false;

                string columnDataType = "CHAR(255)";

                switch (tableColumn.DataType.Name)
                {
                    case "String":
                        columnDataType = "CHAR(255)";
                        break;
                    case "Int32":
                        columnDataType = "INTEGER";
                        break;
                    case "Decimal":
                        columnDataType = "CURRENCY";
                        break;
                }

                stringBuilder.AppendFormat("{0} {1}", tableColumn.ColumnName, columnDataType);
            }
            stringBuilder.Append(")");

            return stringBuilder.ToString();
        }

        #endregion
        #region CSV
        private string SaveExcel_CSV(string FilePath, DataTable dt)
        {
            try
            {
                var lines = new List<string>();

                string[] columnNames = dt.Columns.Cast<DataColumn>().
                                                  Select(column => column.ColumnName).
                                                  ToArray();

                var header = string.Join(",", columnNames);
                lines.Add(header);

                var valueLines = dt.AsEnumerable()
                                   .Select(row => string.Join(",", row.ItemArray));
                lines.AddRange(valueLines);

                //File.WriteAllLines("Excel.csv", lines);
                File.WriteAllLines(FilePath, lines, Encoding.UTF8);
                return "Excel Export Success!!!";
            }
            catch (Exception ex)
            {
                return $"Excel Export Failed : {ex.ToString()}";
            }
        }
        #endregion

    }
}
