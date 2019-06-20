using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {
        public Random rnd = new Random();
        public long money = 0; // игровая валюта
        public long x2 = 0; // количество х2 бустеров
        public long x3 = 0; // количество х3 бустеров
        public long x10 = 0; // количество х10 бустеров
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // добавление валюты
        {
            button1.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            if (x2 == 0 && x3 == 0 && x10 == 0)
            {
                money = money + 1;
            }
            if (x2 >= 1 && x3 == 0 && x10 == 0)
            {
                money = money + 1 * (2 * x2); 
            }
            if (x2 == 0 && x3 >= 1 && x10 == 0)
            {
                money = money + 1 * (3 * x3);
            }
            if (x2 == 0 && x3 == 0 && x10 >= 1)
            {
                money = money + 1 * (10 * x10);
            }
            if(x2 >= 1 && x3 >=1 && x10 == 0)
            {
                money = money + 1 * (2 * x2) * (3 * x3);
            }
            if (x2 == 0 && x3 >= 1 && x10 >= 1)
            {
                money = money + 1 * (3 * x3) * (10 * x10);
            }
            if (x2 >= 1 && x3 == 0 && x10 >= 1)
            {
                money = money + 1 * (2 * x2) * (10 * x10);
            }
            if (x2 > 0 && x3 > 0 && x10 > 0)
            {
                money = money + 1 * (2 * x2) * (3 * x3) * (10 * x10);
            }
            textBox1.Text = money + "$";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //x3
        {
            if(money >= 70)
            {
                money = money - 70;
                textBox1.Text = money + "$";
                x3++;
                MessageBox.Show($"x3 упешно куплен, всего x3 - {x3}");
            }
            else
            {
                MessageBox.Show("Недостаточно денег для покупки.");
            }
        }

        private void button3_Click(object sender, EventArgs e) //x2
        {
            if(money >= 50)
            {
                money = money - 50;
                textBox1.Text = money + "$";
                x2++;
                MessageBox.Show($"x2 упешно куплен, всего х2 - {x2}");
            }
            else
            {
                MessageBox.Show("Недостаточно денег для покупки.");
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e) // x10
        {
            if (money >= 300)
            {
                money = money - 300;
                textBox1.Text = money + "$";
                x10++;
                MessageBox.Show($"x10 упешно куплен, всего x10 - {x10}");
            }
            else
            {
                MessageBox.Show("Недостаточно денег для покупки.");
            }
        }
    }
}
