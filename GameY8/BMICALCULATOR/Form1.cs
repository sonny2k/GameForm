using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btncompute.Click += btncompute_Click;
        }

        void btncompute_Click(object sender, EventArgs e)
        {
            int Height = int.Parse(this.txtHeight.Text);
            int Weight = int.Parse(this.txtWeight.Text);
            double BMI = Math.Floor(Weight / (Math.Pow(Height, 2) / 10000));
            this.txtBMI.Text = BMI.ToString();
        }
    }
}
