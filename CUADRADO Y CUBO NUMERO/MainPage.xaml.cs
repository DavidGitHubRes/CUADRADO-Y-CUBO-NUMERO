using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CUADRADO_Y_CUBO_NUMERO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void potenciar_Clicked(object sender, EventArgs e)
        {
            try
            {
                double n = Convert.ToDouble(num.Text);

                cua.Text = "CUADRADO: " + Math.Pow(n, 2);
                cubo.Text = "CUBO: " + Math.Pow(n, 3);
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR","OCURRIO UN ERROR: " + ex.Message,"ACEPTAR");
            }
        }
    }
}
