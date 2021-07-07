using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymousMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void RunDelegate(int p);
        delegate int Expr(int a, int b);

        private void Form1_Load(object sender, EventArgs e)
        {
            // 무명메소드 ( 메소드에 이름이 없다. )
            // delegate *** (int p) { /* ..... */ };
            RunDelegate r = delegate (int p) { MessageBox.Show(p.ToString()); };
            r(123);

            Expr expr = delegate (int a, int b)
            {
                return 2 * a + b;
            };

            int result = expr(1, 2);

            //button1.Click += Button1_Click;
            // (object sender, EventArgs e) 이 부분, 사용안하면 삭제 가능.
            button1.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("Button1");
            };
        }

        /*
        // 탭을 치면 자동으로 메소드가 들어옴
        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button1");
        }
        */
    }
}
