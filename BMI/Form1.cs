using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtWeight.Text = "";
            txtHeight.Text = "";

            lblWeight.Text = "Weight: ";
            lblHeight.Text = "Height: ";

            radbtnMetric.Checked = false;
            radbtnUS.Checked = false;

            txtResult.Text = "";
            txtClassification.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(txtName.Text);
            double weight = Convert.ToDouble(txtWeight.Text);
            double height = Convert.ToDouble(txtHeight.Text);
                       
            double result = 0.0;
            string result2 = "";

            if (radbtnMetric.Checked)
            {                
                result = (weight * 2.2046) / (height * height);
            }
            else if (radbtnUS.Checked) 
            {                
                result = (weight * 703) / (height * height);
            }

            if (result < 18.5)
            {
                result2 = "Underweight - You need to bulk up some!";
            }
            else if (result < 25)
            {
                result2 = "Normal Weight - This is great! Make sure to maintain this!";
            }
            else if (result < 30)
            {
                result2 = "Overweight - You need to exercise to get into shape and watch what you eat.";
            }
            else if (result >= 30)
            {
                result2 = "Obese - Please, see either a dietician or a doctor about the best steps to get healthy.";
            }

            txtResult.Text = "Your BMI at this point in time is " + result.ToString("#.##");

            txtClassification.Text = "You are " + result2; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnMetric.Checked) 
            {
                lblWeight.Text = "Weight (kg): ";
                lblHeight.Text = "Height (m): ";
            }
        }

        private void radbtnUS_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnUS.Checked)
            {
                lblHeight.Text = "Height (in): ";
                lblWeight.Text = "Weight (lb): ";
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
