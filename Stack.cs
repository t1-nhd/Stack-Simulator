using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSimulator
{
    class Stack<T>
    {
        public Node<T> Top; //Phần tử Top 

        public Stack() //Khởi tạo 1 Stack
        {
            Top = null;
        }

        #region Các thao tác trên Stack
        public int Count()
        {
            int c = 0;
            Node<T> p = Top;
            while (p != null)
            {
                c++;
                p = p.Next;
            }
            return c;
        }
        public void Push(T data)
        {
            Node<T> p = new Node<T>(data);
            p.Next = Top;
            Top = p;

        }
        public T Pop()
        {
            T x = Top.Data;
            Top = Top.Next;
            return x;
        }
        public object Peek()
        {
            if (Top == null)
            {
                return null;
            }
            else return Top.Data;
        }
        public void Clear()
        {
            while (Top != null)
            {
                Pop();
            }
        }
        #endregion Các thao tác trên Stack

        #region in Stack
        public string Print()
        {
            string s = "";
            Node<T> p = Top;
            while (p != null)
            {
                s += "[" + p.Data.ToString() + "]   ";
                p = p.Next;
            }
            return s;
        }
        public string PrintBinary()
        {
            string s = "";
            Node<T> p = Top;
            while (p != null)
            {
                s += p.Data.ToString();
                p = p.Next;
            }
            return s;
        }

        public string PrintHex()
        {
            string s = "";
            Node<T> p = Top;
            while (p != null)
            {
                if (Convert.ToInt32(p.Data) < 10)
                {
                    s += p.Data.ToString();
                    p = p.Next;
                }
                else
                {
                    switch (Convert.ToInt32(p.Data))
                    {
                        case 10:
                            s += "A"; break;
                        case 11:
                            s += "B"; break;
                        case 12:
                            s += "C"; break;
                        case 13:
                            s += "D"; break;
                        case 14:
                            s += "E"; break;
                        case 15:
                            s += "F"; break;
                    }
                    p = p.Next;
                }
            }

            return s;
        }
        #endregion
    }
}