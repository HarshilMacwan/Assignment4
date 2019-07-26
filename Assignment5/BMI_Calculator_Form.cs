using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class BMI_Calculator_Form : Form
    {
        
        public BMI_Calculator_Form()
        {
            InitializeComponent();
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            int result;
            var hight =MyHightInput.Value;
            var weight = MyWeightInput.Value;
            if(ImperialRadioButton.Checked)
            {
                result = Convert.ToInt32((weight * 703 )/(hight*hight));
            }
            else
            {
                result =Convert.ToInt32( weight / (hight * hight));

            }

            if (result <= 18.5)
            {
                ResultBox.Text = "Your BMI is:  " + result.ToString() +"\n You are underweight";

            }
            else if (result >= 18.5 && result<=24.9)
            {
                ResultBox.Text = "Your BMI is:  " + result.ToString() + "\n Your weight is normal ";

            }
            else if (result >=25 && result<=29.9)
            {
                ResultBox.Text = "Your BMI is:  " + result.ToString() + "\n You are Overweight";

            }
            else
            {
                ResultBox.Text = "Your BMI is:  " + result.ToString() + "\n You are Obese";

            }
        }  
    }
}
