using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform21Exception
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "-";

            try
            {
                //format exception
                int iCheck = 0;

                if (int.TryParse(textBox1.Text, out iCheck))
                {
                    int.Parse(textBox1.Text);
                }
                else
                {
                    label1.Text = "Data Form이 맞지 않습니다.";
                }

                //ARGUMENT EXCEPTION

                string strTest = string.Empty;
                List<string> LStringCheck = new List<string>();
                LStringCheck.Add("Test1");

                //for (int i = 0; i < 2; i++)
                //{
                //    strTest = LStringCheck[i];

                //}

                foreach (string ostrText in LStringCheck)
                {
                    strTest = ostrText;
                }

                //NullReferenceException
                List<object> LObject = null;
                object oRet = LObject[0];


                //InvalidCastException
                object oCheck = "fdsfd";
                if (oCheck is int)
                {
                    int iCastCheck = (int)oCheck;

                }

            }
            catch (FormatException ex)
            {
                label1.Text = ex.ToString();
                //ex.ToString;
            }
            catch (ArgumentException ex)
            {
                label1.Text = ex.ToString();
            }
            catch (NullReferenceException ex)
            {
                label1.Text = ex.ToString();
            }
            catch (Exception ex)
            {
                label1.Text = ex.ToString();
            }
            finally
            {
                label1.Text = "end";
            }
        }
    }
}
