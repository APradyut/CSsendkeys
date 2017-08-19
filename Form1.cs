using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SendThis;

namespace dll_testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SendThis.SendThis st = new SendThis.SendThis();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                while (i < Convert.ToInt32(textBox1.Text))
                {
                    st.start("text" + i);
                    Console.WriteLine("text" + i);
                    i++;
                }
            }
            catch(Exception exp)
            {

            }
        }
    }
}
