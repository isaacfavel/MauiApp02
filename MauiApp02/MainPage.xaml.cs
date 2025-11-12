using System.Runtime.InteropServices.ObjectiveC;

namespace MauiApp02
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSumarClicked(object? sender, EventArgs e)
        {
            try
            {

                double numwero1 = double.Parse(txtNumero1.Text);
                double numwero2 = double.Parse(txtNumero2.Text);
                double resultado = numwero1 + numwero2;
                lblResultado.Text = $"Resultado: {resultado}";
                
            }
            catch (Exception ex) { 
            
            }

            
        }

        private void OnRestarClicked(object? sender, EventArgs e)
        {
            try
            {

                double numwero1 = double.Parse(txtNumero1.Text);
                double numwero2 = double.Parse(txtNumero2.Text);
                double resultado = numwero1 - numwero2;
                lblResultado.Text = $"Resultado: {resultado}";
            }
            catch (Exception ex)
            {

            }


        }
        private void OnMultiplicarClicked(object? sender, EventArgs e)
        {
            try
            {

                double numwero1 = double.Parse(txtNumero1.Text);
                double numwero2 = double.Parse(txtNumero2.Text);
                double resultado = numwero1 * numwero2;
                lblResultado.Text = $"Resultado: {resultado}";
            }
            catch (Exception ex)
            {

            }


        }
        private void OnDividirClicked(object? sender, EventArgs e)
        {
            try
            {

                double numwero1 = double.Parse(txtNumero1.Text);
                double numwero2 = double.Parse(txtNumero2.Text);
                double resultado = numwero1 / numwero2;
                lblResultado.Text = $"Resultado: {resultado}";
            }
            catch (Exception ex)
            {

            }


        }

        private void OnBorrarClicked(Object? sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "Resultado";
            txtNumero1.Focus();
            
        }


    }
}
