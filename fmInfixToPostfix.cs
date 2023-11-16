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
    public partial class fmInfixToPostfix : Form
    {
        fmStack fmS;
        string infix;
        Stack<char> myStack = new Stack<char>();
        string postfix = "", txA = "";
        Graphics g;
        int i = 0;


        public fmInfixToPostfix(fmStack fm)
        {
            InitializeComponent();
            fmS = fm;
            g = fDisplay.CreateGraphics();
        }

        #region Thoát fmInfixToPostfix
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
                fmS.Close();
            }
        }
        #endregion

        #region check VAR
        bool isAlpha(char c)
        {
            if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z') return true;
            return false;
        }
        bool isNum(char c)
        {
            if (c >= '0' && c <= '9') return true;
            return false;
        }
        bool isOperator(char c)
        {
            if (c == '^' || c == '*' || c == '-' || c == '+' || c == '/' || c == '(' || c == ')') return true;
            return false;
        }
        bool checkVar(string s)
        {
            char c;
            for(int i = 0; i < s.Length; i++)
            {
                if (!isAlpha(s[0]) && !isNum(s[0]) || !isAlpha(s[s.Length - 1]) && !isNum(s[s.Length - 1])) return false;
                c = Convert.ToChar(s[i]);
                if (!isAlpha(c) && !isNum(c) && !isOperator(c)) return false;
            }
            return true;
        }
        int prio(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;
            }
            return -1;
        }
        #endregion

        #region Convert

        private void reset()
        {
            txOut.Text = "";
            txAction.Text = "";
            postfix = "";
            txA = "";
            i = 0;
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(i < infix.Length)
            {
                label4.Text = infix[i].ToString();
                if (isAlpha(infix[i]) || isNum(infix[i])) //toán hạng và ký tự alp -> chuyển sang chuỗi Output
                {
                    postfix += infix[i];
                    txOut.Text = postfix;
                    
                }
                else if (infix[i] == '(')
                {
                    txA += "Push('(')\r\n";
                    txAction.Text = txA;
                    myStack.Push(infix[i]);
                    draw(myStack.Top, true);
                }
                else if (infix[i] == ')')
                {
                    if (myStack.Top.Data != '(')
                    {
                        txA += "Pop()\r\n";
                        txAction.Text = txA;
                        draw(myStack.Top, false);
                        postfix += myStack.Pop();

                        txOut.Text = postfix;
                        i--;
                    }
                    else
                    {
                        txA += "Pop()\r\n";
                        txAction.Text = txA;
                        draw(myStack.Top, false);
                        myStack.Pop();
                    }
                    
                }
                else
                {
                    if (myStack.Count() <= 0)
                    {
                        txA += string.Format("Push('{0}')\r\n", infix[i]);
                        txAction.Text = txA;
                        myStack.Push(infix[i]);
                        
                        draw(myStack.Top, true);
                    }
                    else
                    {
                        if (prio(infix[i]) > prio(myStack.Top.Data)) //nếu độ ưu tiên lớn hơn -> Push
                        {
                            txA += string.Format("'{0}' > '{1}' -> Push('{0}')\r\n", infix[i], myStack.Top.Data);
                            txAction.Text = txA;
                            myStack.Push(infix[i]);
                            draw(myStack.Top, true);
                        }
                        else //nhỏ hơn hoặc bằng -> Swap
                        {
                            txA += string.Format("'{0}' <= '{1}' -> Swap('{0}', '{1}')\r\n", infix[i], myStack.Top.Data);
                            txAction.Text = txAction.Text = txA;
                            draw(myStack.Top, false);
                            postfix += myStack.Pop();
                            txOut.Text = postfix;

                            myStack.Push(infix[i]);
                            draw(myStack.Top, true);
                            
                        }
                    }
                }
                i++;
            }
            
            else
            {
                if (myStack.Count() > 0)
                {
                    draw(myStack.Top, false);
                    postfix += myStack.Pop();
                    txA += "Pop()\r\n";
                    txAction.Text = txA;
                    txOut.Text = postfix;
                }
                else
                {
                    timer1.Stop();
                    unchanged();
                    MessageBox.Show(postfix, "Result", MessageBoxButtons.OK);
                    infix = "";
                }
            }
        }

        //hàm vẽ
        private void draw(Node<char> stack, bool slPush) //gọi hàm draw truyền vào giá trị cho slPush để biết hàm vẽ hay xóa
        {

            if (slPush == true) //true = Push;
            {
                stack.label.Size = new Size(40, 40);
                stack.label.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold);
                fDisplay.Controls.Add(stack.label);
            }
            else //false = Pop;
            {
                stack.label.Dispose();
                stack.label = null;
                fDisplay.Controls.Remove(stack.label);
            }
        }

        private void btCv_Click(object sender, EventArgs e)
        {
            //nếu hàm truyền vào == $
            if (infix == null)
            {
                MessageBox.Show("Nothing to convert! Please input a expression!", "Notification", MessageBoxButtons.OK);
            }

            //nếu hàm truyền vào kp 1 biểu thức {
            //      != các toán hạng
            //      != ký tự chữ cái
            //      != các toán tử 
            //}
            else if (!checkVar(infix))
            {
                MessageBox.Show("Something went wrong! Try Again!", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                unchanged();
                timer1.Start();
            }
        }

        private void txInput_TextChanged_1(object sender, EventArgs e)
        {
            reset();
            infix = txInput.Text;
        }

        //Khóa các button khi chương trình chạy
        private void unchanged()
        {
            btCv.Enabled = !btCv.Enabled;
        }
        #endregion
    }
}