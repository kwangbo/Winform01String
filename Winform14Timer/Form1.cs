using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform14Timer
{
    public partial class Form1 : Form
    {
        Dictionary<String, String> _dData = new Dictionary<string, string>();
        CXMLControl _xml = new CXMLControl();

        string strPath = Application.StartupPath + "\\Save.txt";

        private double iTick = 0;
        private double iTotal = 0;

        private int i1Add = 1;
        private int i1Level = 1;

        private int i3Add = 3;
        private int i3Level = 1;

        private int i50Add = 0;
        private int i50Level = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(strPath))
            {
                //File이 있을 경우 File Loading
                _dData = _xml.fXML_Reader(strPath);

                iTick = double.Parse(_dData[CXMLControl._TICK]);
                iTotal = double.Parse(_dData[CXMLControl._TOTAL]);
                i1Level = int.Parse(_dData[CXMLControl._LEVEL_1]);
                i3Level = int.Parse(_dData[CXMLControl._LEVEL_3]);
                i50Level = int.Parse(_dData[CXMLControl._LEVEL_50]);

            }

            Timer oTimer = new Timer(); // System.Windows.Forms.Timer() ;  single 
            oTimer.Enabled = true;
            oTimer.Interval = 100;
            oTimer.Tick += OTimer_Tick;
            oTimer.Start();

        }


        private void Form1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            _dData.Clear();
            _dData.Add(CXMLControl._TICK, iTick.ToString());
            _dData.Add(CXMLControl._TOTAL, iTotal.ToString());
            _dData.Add(CXMLControl._LEVEL_1, i1Level.ToString());
            _dData.Add(CXMLControl._LEVEL_3, i3Level.ToString());
            _dData.Add(CXMLControl._LEVEL_50, i50Level.ToString());
            _xml.fXML_Writer(strPath, _dData);

        }



        private void OTimer_Tick(object sender, EventArgs e)
        {
            iTick = i1Add + i3Add + i50Add;
            iTotal = iTotal + iTick;

            lblTickPoint.Text = string.Format("{0} (1:{1}), (3:{2}), (50:{3})", 
                iTick.ToString(),i1Level.ToString(), i3Level.ToString(), i50Level.ToString() );
            lblTotal.Text = iTotal.ToString();

        
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Button obt = sender as Button;

            switch (obt.Name)
            {
                case "btn1Add":
                    if (iTotal > 100)
                    {
                        iTotal = iTotal - 100;
                        i1Level++;
                        i1Add = 1 * i1Level;
                    }
                    break;

                case "btn3Add":
                    if (iTotal > 300)
                    {
                        iTotal = iTotal - 100;
                        i3Level++;
                        i3Add = 3 * i3Level;
                    }

                    break;

                case "btn50Add":
                    if (iTotal > 5000)
                    {
                        iTotal = iTotal - 100;
                        i50Level++;
                        i50Add = 50 * i50Level;
                    }

                    break;

                default:
                    break;
            }

        }

    }
}
