using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackSimulator
{
    public partial class fmDecConvert : Form
    {
        fmStack fmS;
        int n;
        Stack<int> myStack = new Stack<int>();
        Stack<int> rs = new Stack<int>();
        //string dl, dl2, dl3;
        Random rd = new Random();
        string msb;
        string Txt;
        bool slConvert = false;
        int X, Y;
        Graphics g;
        int hex;


        public fmDecConvert(fmStack fm)
        {
            InitializeComponent();
            fmS = fm;
            X = 90;
            Y = 10;
            g = label3.CreateGraphics();
        }

        #region Drawing
        private void draw(Node<int> stack, string txt = "")
        {
            if (slConvert == true) //true = Push;
            {
                //label Top
                lbTop.Visible = true;
                lbTop.Location = new Point(X - 55, Y + 5);

                //label Stack
                stack.label.Size = new Size(100, 30);
                stack.label.Location = new Point(X, Y);

                //label Text
                stack.text.Location = new Point(X + 100, Y + 4);
                stack.text.Text = txt;

                //Add control
                label3.Controls.Add(stack.label);
                label3.Controls.Add(lbTop);
                label3.Controls.Add(stack.text);
            }
            else //false = Pop;
            {
                lbTop.Location = new Point(X - 50, Y + 4);

                stack.label.Dispose();
                stack.label = null;

                stack.text.Dispose();
                stack.text = null;


                label3.Controls.Remove(stack.label);
                label3.Controls.Remove(stack.text);
            }
        }

        private void updateLocation()
        {
            if (slConvert == true)
            {
                Y += 36;
            }
            else
            {
                Y -= 36;
            }
        }
        #endregion

        #region Thoát fmConvert
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
            }
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                fmS.Close();
            }
        }
        #endregion

        #region Convert
        private void numCv_ValueChanged(object sender, EventArgs e)
        {
            n = Convert.ToInt32(numCv.Value);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            slConvert = false; 
            while(myStack.Top != null)
            {                
                draw(myStack.Top);
                myStack.Pop();
                updateLocation();
            }
            lbTop.Visible = false;
            lbRs.Text = "Result: ";
        }

        private void btRd_Click(object sender, EventArgs e)
        {
            numCv.Value = Convert.ToInt32(rd.Next(0, 9999));
        }

        private void btBin_Click(object sender, EventArgs e)
        {
            clear_Click(sender, e);
            //label3.Text = "";
            //txPush.Text = "";
            if (n == 0)
            {
                MessageBox.Show("0", "Result", MessageBoxButtons.OK);
            }
            else
            {
                unchanged();
                timer1.Start();
            }
        }

        private void btHex_Click(object sender, EventArgs e)
        {
            clear_Click(sender, e);
            //label3.Text = "";
            //txPush.Text = "";
            if (n == 0)
            {
                MessageBox.Show("0", "Result", MessageBoxButtons.OK);
            }
            else if (n >= 16)
            {
                unchanged();
                timer2.Start();
            }
            else MessageBox.Show("Your input is less than 16! Try another value!", "Notification", MessageBoxButtons.OK);

        }

        private void btOct_Click(object sender, EventArgs e)
        {
            clear_Click(sender, e);
            //label3.Text = "";
            //txPush.Text = "";
            if (n == 0)
            {
                MessageBox.Show("0", "Result", MessageBoxButtons.OK);
            }
            else
            {
                unchanged();
                timer3.Start();
            }
        }
        #endregion

        #region Timer
        private void unchanged()
        {
            numCv.Focus();
            btBin.Enabled = !btBin.Enabled;
            btRd.Enabled = !btRd.Enabled;
            btHex.Enabled = !btHex.Enabled;
            btOct.Enabled = !btOct.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (n != 0)
            {
                slConvert = true;
                myStack.Push(n % 2);

                //dl = string.Format(">> {0} / 2 = {1} dư {2}\r\n", n, n / 2, n % 2);
                //dl2 = string.Format("Push ({0})\r\n", n % 2);
                n /= 2;

                //label3.Text += dl;
                //txPush.Text += dl2;
                lbRs.Text = string.Format("Result: " + myStack.PrintBinary());
                
                draw(myStack.Top);
                updateLocation();

                if (n == 0)
                {
                    timer1.Stop();
                    //label3.Text += "Result: " + myStack.PrintBinary();
                    MessageBox.Show(myStack.PrintBinary(), "Result", MessageBoxButtons.OK);
                    numCv.Value = 0;
                    slConvert = false;
                    unchanged();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (n != 0)
            {
                slConvert = true;
                hex = n % 16;
                myStack.Push(hex);
                //dl = string.Format(">> {0} / 16 = {1} dư {2}\r\n\r\n", n, n / 16, n % 16);
                //dl2 = string.Format("Push ({0})\r\n", n % 16);
                lbRs.Text = string.Format("Result: " + myStack.PrintHex());
                
                /*
                if ((n % 16) > 9)
                {*/
                switch (hex)
                {
                    case 10: Txt = string.Format(">> A"); break;
                        //dl3 = string.Format("{0} >> A\r\n", n % 16); break;
                    case 11: Txt = string.Format(">> B"); break;
                        //dl3 = string.Format("{0} >> B\r\n", n % 16); break;
                    case 12: Txt = string.Format(">> C"); break; 
                        //dl3 = string.Format("{0} >> C\r\n", n % 16); break;
                    case 13: Txt = string.Format(">> D"); break;
                        //dl3 = string.Format("{0} >> D\r\n", n % 16); break;
                    case 14: Txt = string.Format(">> E"); break;
                        //dl3 = string.Format("{0} >> E\r\n", n % 16); break;
                    case 15: Txt = string.Format(">> F"); break;
                        //dl3 = string.Format("{0} >> F\r\n", n % 16); break;
                    default: Txt = ""; break;
                }
                /*
                }
                else dl3 = string.Format("{0} >> {0}\r\n", n % 16);
                */

                draw(myStack.Top, Txt);
                updateLocation();
                n /= 16;
                

                //label3.Text += dl;
                //txPush.Text += dl2 + dl3;

                if (n == 0)
                {
                    timer2.Stop();
                    //label3.Text += "Result: " + myStack.PrintHex();
                    msb = string.Format("{0}(10) = {1}(16)", numCv.Value, myStack.PrintHex());
                    MessageBox.Show(msb, "Result", MessageBoxButtons.OK);
                    numCv.Value = 0;
                    slConvert = false;
                    unchanged();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (n != 0)
            {
                slConvert = true;
                myStack.Push(n % 8);
                //dl = string.Format(">> {0} / 8 = {1} dư {2}\r\n", n, n / 8, n % 8);
                //dl2 = string.Format("Push ({0})\r\n", n % 8);
                lbRs.Text = string.Format("Result: " + myStack.PrintBinary());
                draw(myStack.Top);
                updateLocation();
                n /= 8;
                //label3.Text += dl;
               //txPush.Text += dl2;
                if (n == 0)
                {
                    timer1.Stop();
                    //label3.Text += "Result: " + myStack.PrintBinary();
                    msb = string.Format("{0}(10) = {1}(8)", numCv.Value, myStack.PrintBinary());
                    MessageBox.Show(msb, "Result", MessageBoxButtons.OK);
                    numCv.Value = 0;
                    slConvert = false;
                    unchanged();
                }
            }
        }
        #endregion

    }
}