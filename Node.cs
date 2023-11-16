using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StackSimulator
{
    class Node<T>
    {
        public T Data;
        public Node<T> Next;
        public Label label, text;

        public Node(T data)
        {
            Data = data;
            Next = null;
            label = new Label
            {
                Size = new Size(100, 22),
                BackColor = Color.DeepSkyBlue,
                Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Bold),
                Text = data.ToString(),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            text = new Label
            {
                ForeColor = Color.Red,
                Size = new Size(48, 30),
                Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Bold)
            };
        }
    }
}