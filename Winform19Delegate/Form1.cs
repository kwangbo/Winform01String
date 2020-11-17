using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform19Delegate
{
    public partial class Form1 : Form
    {
        public delegate int delFuncDow_Edge(int i);
        public delegate int delFuncTopping(string strOder, int Ea);

        public delegate T delFunc<T>(T i);

        public delegate object delFuncO(object i); // var, object

        int _iTotalPrice = 0;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            Dictionary<string, int> dPizzaOrder = new Dictionary<string, int>();

            delFuncDow_Edge delDow = new delFuncDow_Edge(fDow);
            delFuncDow_Edge delEdge = new delFuncDow_Edge(fEdge);

            delFuncTopping delTopping = null;

            int iDowOrder = 0;
            int iEdgeOrder = 0;

            //도우를 선택
            if (rdoDow1.Checked)
            {
                iDowOrder = 1;
                dPizzaOrder.Add("오리지널", 1);
            }
            else if (rdoDow2.Checked)
            {
                iDowOrder = 2;
                dPizzaOrder.Add("씬", 2);
            }

            // delDow(iDowOrder);

            //Edge를 선택
            if (rdoEdge1.Checked)
            {
                iEdgeOrder = 1;
                dPizzaOrder.Add("리치골드", 1);
            }
            else if (rdoEdge2.Checked)
            {
                iEdgeOrder = 2;
                dPizzaOrder.Add("치즈클러스터", 1);
            }

            // delEdge(iEdgeOrder);
            // 좋은 지 모르 겠음 
            fCallBackDelegate(iDowOrder, delDow);
            fCallBackDelegate(iEdgeOrder, delEdge);

            if (cboxTopping1.Checked)
            {
                //delTopping = new delFuncTopping(fTopping1);
                delTopping += fTopping1;
                dPizzaOrder.Add("소세지", (int)numEa.Value);
            }

            if (cboxTopping2.Checked)
            {
                //delTopping = new delFuncTopping(fTopping1);
                delTopping += fTopping2;
                dPizzaOrder.Add("감자", (int)numEa.Value);
            }
            if (cboxTopping3.Checked)
            {
                //delTopping = new delFuncTopping(fTopping1);
                delTopping += fTopping3;
                dPizzaOrder.Add("치즈", (int)numEa.Value);

            }
            
            delTopping("토핑", (int)numEa.Value);

            flboxOrderRed("---------------------------------");
            flboxOrderRed(string.Format("전체 주문 가격은 {0}원 입니다.", _iTotalPrice));

            frmLoading(dPizzaOrder);
        }

       

        

        #region Function
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="iOrder"></param>
        /// <returns></returns>
        private int fDow(int iOrder)
        {
            string strOder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 10_000;
                strOder = string.Format("도우는 오리지널을 선택 하셨습니다. ({0}원)", iPrice.ToString());
            }
            else if (iOrder == 2 )
            {
                iPrice = 11_000;
                strOder = string.Format("도우는 오리지널을 선택 하셨습니다. ({0}원)", iPrice.ToString());
            }
            else 
            {
                strOder = "도우를 선택하지 않았습니다.";
            }

            lboxOrder.Items.Add(strOder);

            return _iTotalPrice = _iTotalPrice + iPrice;
        }


        private int fEdge(int iOrder)
        {
            string strOder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 1_000;
                strOder = string.Format("엣지는 리치골드를 선택 하셨습니다. ({0}원)", iPrice.ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 2_000;
                strOder = string.Format("엣지는 치즈크러스터를 선택 하셨습니다. ({0}원)", iPrice.ToString());
            }
            else
            {
                strOder = "엣지를 선택하지 않았습니다.";
            }

            flboxOrderRed(strOder);

            return _iTotalPrice = _iTotalPrice + iPrice;
        }


        public int fCallBackDelegate(int i, delFuncDow_Edge delFunction )
        {
            return delFunction(i);
        }

        private int fTopping1(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa + 500;

            strOrder = string.Format("소세지 {0} {1} 개를 선택 하셨습니다. : ({2})원 (1ea 500원)", Order, iEa, iPrice);

            flboxOrderRed(strOrder);

            return _iTotalPrice = _iTotalPrice + iPrice;
        }


        private int fTopping2(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa + 200;

            strOrder = string.Format("감자 {0} {1} 개를 선택 하셨습니다. : ({2})원 (1ea 200원)", Order, iEa, iPrice);

            flboxOrderRed(strOrder);
            return _iTotalPrice = _iTotalPrice + iPrice;
        }


        private int fTopping3(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa + 300;

            strOrder = string.Format("치즈 {0} {1} 개를 선택 하셨습니다. : ({2})원 (1ea 530원)", Order, iEa, iPrice);

            flboxOrderRed(strOrder);

            return _iTotalPrice = _iTotalPrice + iPrice;
        }


        private void flboxOrderRed(string strOder)
        {
            lboxOrder.Items.Add(strOder);
        }

        #endregion

        #region event
        frmPizza fPizza;
        private void frmLoading(Dictionary<string, int> dPizzaOrder)
        {
            if (fPizza != null)
            {
                fPizza.Dispose();
                fPizza = null;
            }

            fPizza = new frmPizza();
            fPizza.eventdelPizzaComplete += FPizza_eventdelPizzaComplete;
            fPizza.Show();

            fPizza.fPizzrCheck(dPizzaOrder);

            //_timer = new Timer();
            //_timer.Interval = 1000;
            //_timer.Tick += _timer_Tick;
            //_timer.Start();

        }

        //private void _timer_Tick(object sender, EventArgs e)
        //{
        //    if (fPizza.BOrderComplete)
        //    {
        //        flboxOrderRed("주문 완료 확인 ");
        //    }
        //}
      
        private int FPizza_eventdelPizzaComplete(string strResult, int iTime)
        {
            flboxOrderRed("---------------------------------");
            flboxOrderRed(string.Format(" {0} / 걸린시가 : {1} ", strResult, iTime));

            // 시간 5분 넘으면  -1 
            if (iTime > 5000)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}
