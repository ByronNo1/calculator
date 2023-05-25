using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string pStrOperator = "";
        decimal pOldDec_1 = 0, pOldDec_2 = 0;
        int pNStep = 0;


        public Form1()
        {
            InitializeComponent();
        }


        #region UI事件
        private void btn_Num_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
            {
               
                string str = ((Button)sender).Text;
                decimal tmpdou = 0;
                if (decimal.TryParse(str, out tmpdou))
                {
                    insert(tmpdou);
                }
            }
            else
            {
                return;
            }



        }

        private void btn_Point_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
            {
                FunPoint();
            }
            else
            {
                return;
            }

        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
            { FunC(); }
            else
            {
                return;
            }

        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
            {
                string str = ((Button)sender).Text;
                FunOperator(str);
            }
            else
            {
                return;
            }

        }

        private void btn_PosNeg_Click(object sender, EventArgs e)
        {// (+-)
            if (e is MouseEventArgs)
            {
                FunPosNeg();
            }
            else
            {
                return;
            }

        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {     //=
            if (e is MouseEventArgs)
            {
                FunResult();
            }
            else
            {
                return;
            }

        }

        private void btn_DEL_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
            {
                FunDEL();
            }
            else
            {
                return;
            }

        }

        #endregion

        #region Function
        //偵測鍵盤輸入
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Shift || keyData == Keys.ShiftKey || (int)keyData == 65552)
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }

            switch (keyData)
            {
                case Keys.Escape:
                    FunC();
                    break;

                case Keys.Delete:
                case Keys.Back:
                    FunDEL();
                    break;

                case Keys.OemPeriod:
                    FunPoint();
                    break;
                case System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Shift:// +
                case Keys.Add:// +
                    FunOperator("+");
                    break;
                case Keys.Multiply:// *
                    FunOperator("*");
                    break;
                case Keys.Subtract:// -
                    FunOperator("-");
                    break;
                case Keys.Divide:// /
                case Keys.Oem2:// /
                    FunOperator("/");
                    break;
                case Keys.Oemplus:// =
                case Keys.Enter:// =
                    FunResult();
                    break;
                default:
                    decimal tmpDec = 0;
                    if (keyData >= Keys.NumPad0 && keyData <= Keys.NumPad9)
                    {
                        tmpDec = (decimal)keyData - 96;
                        insert(tmpDec);
                    }
                    else if (keyData >= Keys.D0 && keyData <= Keys.D9)
                    {
                        tmpDec = (decimal)keyData - 48;
                        insert(tmpDec);
                    }
                    else
                    {
                        return base.ProcessCmdKey(ref msg, keyData);
                    }
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);


        }

        //塞入數字
        private void insert(decimal _tmpI)
        {
            decimal tmpdou = 0;
            if (pNStep == 1)
            {
                txtResult.Text = "0";
                pNStep = 2;//已經數入第二值
            }
            else if (pNStep == 3)//已經算完了
            {
                txtResult.Text = "0";
                pNStep = 0;//進入重新輸入
            }
            txtResult.Text += _tmpI.ToString();

            if (decimal.TryParse(txtResult.Text, out tmpdou))
            {
                txtResult.Text = tmpdou.ToString();
                if (txtResult.Text == "")
                {
                    txtResult.Text = "0";
                }
            }
            else
            {
                txtResult.Text = "0";
            }

        }

        //塞入 小數點
        private void FunPoint()
        {
            double tmpdou = 0;
            string str = "";
            str = txtResult.Text;
            txtResult.Text += ".";
            if (double.TryParse("0" + txtResult.Text, out tmpdou))
            {
                if(tmpdou == 0)
                {
                    txtResult.Text = "0.";
                }
            }
            else
            {
                txtResult.Text = str;
            }

        }

        //清空
        private void FunC()
        {
            txtResult.Text = "0";
            pStrOperator = "";
            pOldDec_1 = 0;
            pOldDec_2 = 0;
            pNStep = 0;
        }

        //運算子
        private void FunOperator(string _str)
        {
            decimal tmpdou = 0;
            if (pNStep == 2)//已經是第二輸入
            {
                FunResult();
            }
            else if(pNStep == 3) //已經算完第一次的 運算子，第二次計算子 必須將原本的質丟進去
            {
                pNStep = 0;
            }
            switch (_str)
            {
                case "+":
                case "A1"://+
                    pStrOperator = "+";
                    break;
                case "-":
                case "A2"://-
                    pStrOperator = "-";
                    break;
                    
                case "×":
                case "*":
                case "A3"://*
                    pStrOperator = "*";
                    break;
                case "÷":
                case "/":
                case "A4":// /
                    pStrOperator = "/";
                    break;
            }
            if (pNStep == 0) //沒有輸入的狀態
            {
                pNStep = 1;//進入第二輸入
                if (decimal.TryParse(txtResult.Text, out tmpdou))
                {
                    txtResult.Text = tmpdou.ToString("#0.######################################################################");
                    if (decimal.TryParse(txtResult.Text, out tmpdou))
                    {
                        pOldDec_1 = tmpdou * 1;
                    }
                }
            }
        }

        //正負號
        private void FunPosNeg()
        {
            decimal tmpdou = 0;
            if (decimal.TryParse(txtResult.Text, out tmpdou))
            {
                if (tmpdou != 0 && decimal.TryParse(txtResult.Text + "1", out tmpdou)) //加一避免小數點後是零會不見
                {
                    tmpdou = tmpdou * (-1);
                    txtResult.Text = tmpdou.ToString().Substring(0, tmpdou.ToString().Count() - 1);
                    if (txtResult.Text == "")
                    {
                        txtResult.Text = "0";
                    }
                }
            }
        }

        //結果
        private void FunResult()
        {
            decimal tmpdou = 0;
            if (pNStep == 2)//已經是第二輸入
            {//先行計算結果
                decimal.TryParse(txtResult.Text, out tmpdou);
                txtResult.Text = tmpdou.ToString("#0.######################################################################");
                decimal.TryParse(txtResult.Text, out tmpdou);
                pOldDec_2 = tmpdou;
                pNStep = 1;//
            }
            else if (pNStep == 0)
            {
                if (decimal.TryParse(txtResult.Text, out tmpdou))
                {
                    txtResult.Text = tmpdou.ToString("#0.######################################################################");
                    if (decimal.TryParse(txtResult.Text, out tmpdou))
                    {
                        pOldDec_1 = tmpdou * 1;
                    }
                }
            }

            switch (pStrOperator)
            {
                case "+":
                    txtResult.Text = (pOldDec_1 + pOldDec_2).ToString();
                    break;
                case "-":
                    txtResult.Text = (pOldDec_1 - pOldDec_2).ToString();
                    break;
                case "*":
                    txtResult.Text = (pOldDec_1 * pOldDec_2).ToString();
                    break;
                case "/":
                    if (pOldDec_2 != 0)
                    {
                        txtResult.Text = (pOldDec_1 / pOldDec_2).ToString();
                    }
                    else
                    {
                        txtResult.Text = pOldDec_1.ToString();
                    }
                    break;
            }
            decimal.TryParse(txtResult.Text, out pOldDec_1);

        }
        

        private void FunDEL()
        {
            decimal tmpdou = 0;
            if (decimal.TryParse(txtResult.Text, out tmpdou))
            {
                if (tmpdou != 0 && decimal.TryParse(txtResult.Text + "1", out tmpdou)) //加一避免小數點後是零會不見
                {
                    txtResult.Text = tmpdou.ToString().Substring(0, tmpdou.ToString().Count() - 2);
                    if (txtResult.Text == "" || decimal.TryParse(txtResult.Text, out tmpdou) == false || tmpdou == 0)
                    {
                        txtResult.Text = "0";
                    }
                }
                else if (tmpdou == 0)
                {
                    txtResult.Text = "0";
                }
            }
        }

        #endregion

    }
}
