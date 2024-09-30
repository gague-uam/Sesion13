using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Burbuja.Operaciones;

namespace Burbuja
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        int i =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number = int.Parse(tbNum.Text);
            numbers[i++] = number;
            showNumbers();
        }

        private void showNumbers()
        {
            if(numbers.Length > 0)
            {
                lbNums.Items.Clear();   
            }
            for(int i = 0; i < numbers.Length; i++)
            {
                lbNums.Items.Add(numbers[i]);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MetBurbuja burbuja = new MetBurbuja();
            burbuja.OrdenarBurbuja(numbers);
            showNumbers();
        }
    }
}
