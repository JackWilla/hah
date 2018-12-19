using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = null;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "футбол")
            {
                label1.Text = "Все группы сформированы.\nДля точной информации позврните по номеру +7**********";
            }
            if (comboBox1.Text == "теннис")
            {
                label1.Text = "Есть запись в 3 группы.\n\nГруппа №1 занимается на станции метро ***\nТренер: Петров Петр Петрович\nТелефон: +7**********\n\nГруппа №2 занимается на станции метро *****\nТренер: Николаенкова Олеся Игоревна\nТелефон: +7**********\n\nГруппа №3 занимается на станции метро *******\nТренер: Курягин Кучер Веренский\nТелефон: +7**********";
            }
            if (comboBox1.Text == "волейбол")
            {
                label1.Text = "Есть запись в 1 группу.\n\nГруппа №1 занимается на станции метро *****\nТренер: Северова Виктория Сергеевна\nТелефон: +7**********";
            }
        }
    }
}
