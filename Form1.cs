using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int x = 0;
        int n = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            x = rnd.Next(1,101);
            label3.Text = Convert.ToString(x);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(textBox1.Text) == x) 
               label3.Text = "Умница, Вы угадали с " + (10 - n) + " попыток!";

            if (Convert.ToInt32(textBox1.Text) != x)
            {
                n--;
                if (Convert.ToInt32(textBox1.Text) < x) label3.Text = "Вы не угадали! \n У вас осталось " + n + " попыток! \n Загаданная цифра больше!";
                else label3.Text = "Вы не угадали! \n У вас осталось " + n + " попыток! \n Загаданная цифра меньше!";
            }  

            if (x == 0)
               label3.Text = "Нажмите на кнопку сверху, \n чтобы компьютер загадал число!";

            if (n == 0)
                label3.Text = "У вас не осталось больше попыток, вы проиграли!";
            
        }
    }
}
