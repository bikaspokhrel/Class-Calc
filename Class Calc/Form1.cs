using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Calc
{
    public partial class Form1 : Form
    {
        //create a new instance of the Calc class
        private Calc myCalc = new Calc();
        public Form1()
        {
            InitializeComponent();
            LoadCombobox();
        }
        private void LoadCombobox()
        {
            //pass the array across to the combobox
            cbxOperation.Items.AddRange(myCalc.LoadSymbols());
            //start at the first item
            cbxOperation.SelectedIndex = 0;
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double result;
            //Check for numbers coming in
            if (double.TryParse(txtNum1.Text, out result))
            {
                myCalc.Num1 = result;
            }
            if (double.TryParse(txtNum2.Text, out result))
            {
                myCalc.Num2 = result;
            }
            //check selected operation
            myCalc.SelectedSymbol = cbxOperation.SelectedItem.ToString();
            //output answer
            lblAnswer.Text = Convert.ToString(myCalc.SelectOperation());
            lbxOutput.Items.Add(myCalc.Num1 + " " + myCalc.SelectedSymbol + " " + myCalc.Num2 + " = " + lblAnswer.Text);
        }
    }
    
}
