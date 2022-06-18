using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindTest
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
                {
                    e.Handled = true;
                }
        }

        private void Ploshad2_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox1.Text);

            double s = Math.PI * r*r;

            MessageBox.Show("Площадь данного круга " + s);
        }
    }
}
