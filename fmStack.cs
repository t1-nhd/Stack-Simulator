using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace StackSimulator
{
    public partial class fmStack : Form
    {        
        Stack<int> myStack; //Stack;
        private int X, Y;
        private Graphics g;
        private Random rd;
        private const int maxSize = 20; //số lượng ptu trong Stack: được người dùng nhập vào <20
        private bool slPush = false; // :select push : xác nhận btPush được nhấn;
        private int numPush;
        private int countList;

        public fmStack()
        {
            InitializeComponent();
            Init(); 
        }

        private void Init() //khởi tạo khi load
        {
            txTop.Text = "";
            myStack = new Stack<int>();
            rd = new Random();
            X = 90; Y = 460;
            g = drawingStack.CreateGraphics();
        }

        #region Các xử lý thủ công
        private void txPush_ValueChanged(object sender, EventArgs e)
        {
            numPush = Convert.ToInt32(txPush.Value);
        }

        private void btRandom_Click(object sender, EventArgs e)
        {
            txPush.Value = rd.Next(1, 9999);
        }

        private void btPush_Click(object sender, EventArgs e)
        {
            if (myStack.Count() >= maxSize)
            {
                MessageBox.Show("Stack overflow!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                slPush = true;
                myStack.Push(numPush);

                txList.Text = myStack.Print();
                txCount.Text = "Count: " + myStack.Count().ToString();
                txPop.Text = numPush.ToString();
                draw(myStack.Top);
                txTop.Text = "Top";
                updateLocation();
            }
        }

        private void btPop_Click(object sender, EventArgs e)
        {

            if (myStack.Count() <= 0)
            {
                txPop.Text = "";
                MessageBox.Show("Stack is empty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                slPush = false;
                draw(myStack.Top);
                myStack.Pop();
                if (myStack.Count() <= 0) txPop.Text = "Empty";
                else txPop.Text = myStack.Top.Data.ToString();
                txList.Text = myStack.Print();
                txCount.Text = "Count: " + myStack.Count().ToString();
                updateLocation();
                slPush = true;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            slPush = false;
            while (myStack.Top != null)
            {
                draw(myStack.Top);
                myStack.Pop();
                updateLocation();
            }
            txList.Text = "Stack is clear!";
            txCount.Text = "Count: 0";
            txPush.Value = 0;
            txPop.Text = "";
            btStop.Text = "Pause";
            btStop.Enabled = false;
        }

        private void btPeek_Click(object sender, EventArgs e)
        {
            if (myStack.Count() <= 0)
            {
                MessageBox.Show("Nothing to Peek! Stack is empty!");
            }
            else MessageBox.Show("Top = " + myStack.Top.Data.ToString(), "Top Element", MessageBoxButtons.OK);
        }
        #endregion

        #region System.Drawing
        private void draw(Node<int> stack)
        {
            if (slPush == true) //true = Push;
            {
                stack.label.Location = new Point(X, Y);
                drawingStack.Controls.Add(stack.label);
            }
            else //false = Pop;
            {
                stack.label.Dispose();
                stack.label = null;
                drawingStack.Controls.Remove(stack.label);
            }
        }

        private void updateLocation()
        {
            if (slPush == true)
            {
                Y -= 24;
                txTop.Location = new Point(txTop.Location.X, txTop.Location.Y - 24);
            }
            else
            {
                Y += 24;
                txTop.Location = new Point(txTop.Location.X, txTop.Location.Y + 24);
            }
        }
        #endregion
                
        #region Menustrip
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nguyễn Hoàng Duy - 62130337\n" +
                            "Trường Đại Học Nha Trang\n" +
                            "Khoa Công Nghệ Thông Tin\n" +
                            "Thực Tập Cơ Sở - 62.CNTT-2\n" +
                            "Gv. Phạm Thị Kim Ngoan", "Notification", MessageBoxButtons.OK);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want exit?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }
        #endregion

        #region Mảng ngẫu nhiên tự động
        private void whenRunning()
        {
            btPush.Enabled = !btPush.Enabled;
            btPop.Enabled = !btPop.Enabled;
            numMax.Enabled = !numMax.Enabled;
            txPush.Enabled = !txPush.Enabled;
            btPeek.Enabled = !btPeek.Enabled;
            btRandom.Enabled = !btRandom.Enabled;
            btClear.Enabled = !btClear.Enabled;
        }

        private void numMax_ValueChanged(object sender, EventArgs e)
        {
            countList = Convert.ToInt32(numMax.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numMax.Value) == 0)
            {
                numMax.Value = 20;
            }
            btClear_Click(sender, e);
            timer1.Start();
            btStop.Enabled = true;
            whenRunning();
            if (!timer1.Enabled)
            {
                whenRunning();
                btStop.Enabled = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (myStack.Count() < countList)
            {
                btRandom_Click(sender, e);
                btPush_Click(sender, e);
            }
            else
            {
                whenRunning();
                timer1.Enabled = !timer1.Enabled;
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            btStop.Text = btStop.Text == "Pause" ? "Play" : "Pause";
            whenRunning();
        }
        #endregion

        #region Isekai
        private void queueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pnStack.Visible = false;
        }

        private void infixToPostfixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmInfixToPostfix fm = new fmInfixToPostfix(this);
            fm.ShowDialog();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmDecConvert fm = new fmDecConvert(this);
            fm.ShowDialog();
        }
        #endregion

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want exit?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }
    }
}