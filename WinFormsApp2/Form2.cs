using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1.1 ¿Cuánto vale r?
            int a = 10;
            int b = 3;
            int r = a / b;

            //1.2 ¿Cuánto vale r?
            decimal r = 10 / 4m;

            //1.3 ¿Cuánto vale x al final?

            int x = 5;
            x = x + 2;
            x = x * 3;

            //1.4 ¿Cuánto vale r?
            decimal p = 200m;
            decimal r = p * 0.18m;

            //1.5 ¿Cuánto vale d al final?
            int n = 7;
            decimal d = 0m;
            if (n > 7)
            {
                d = 50m;
            }

            //1.6 ¿Qué valor tiene larga?
            int n = 7;
            bool larga = n >= 7;

            //1.7 ¿Qué texto tiene s?
            string s = "Villa" + "Coral";

            //1.8 ¿Cuánto vale total?
            int n = 4;
            decimal t = 100m;
            decimal total = n * t * 1.28m;

            //1.9 ¿Cuánto vale t al final?
            decimal t = 120m;
            t = t + t * 0.25m;

            //1.10 ¿Cuánto vale noches?
            int noches = (int)8.9m;
        }
    }
}
