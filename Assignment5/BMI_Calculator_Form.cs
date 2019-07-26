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
            ResultBox.Text = result.ToString();

        }  
    }
}
