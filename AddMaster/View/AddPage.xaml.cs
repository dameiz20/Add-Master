using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AddMaster.View
{
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        void Add_Clicked(System.Object sender, System.EventArgs e)
        {
            double dblFirstNum, dblSecondNum;

            Double.TryParse(txtFirstNumber.Text, out dblFirstNum);
            Double.TryParse(txtSecondNumber.Text, out dblSecondNum);
            lblDisplay.Text = (dblFirstNum + dblSecondNum).ToString();

        }
        void Clear_Clicked(System.Object sender, System.EventArgs e)
        {
            lblDisplay.Text = "0";
            txtFirstNumber.Text = string.Empty;
            txtSecondNumber.Text = string.Empty; 
        }
    }
}
