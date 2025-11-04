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

                int numwero1 = int.Parse(txtNumero1.Text);
                int numwero2 = int.Parse(txtNumero1.Text);
                int resultado = numwero1 + numwero2;
                lblResultado.Text = $"Resultado: {resultado}";
            }
            catch (Exception ex) { 
            
            }

            
        }

        private void OnRestarClicked(object? sender, EventArgs e)
        {
            try
            {

                int numwero1 = int.Parse(txtNumero1.Text);
                int numwero2 = int.Parse(txtNumero1.Text);
                int resultado = numwero1 - numwero2;
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

                int numwero1 = int.Parse(txtNumero1.Text);
                int numwero2 = int.Parse(txtNumero1.Text);
                int resultado = numwero1 * numwero2;
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

                int numwero1 = int.Parse(txtNumero1.Text);
                int numwero2 = int.Parse(txtNumero1.Text);
                int resultado = numwero1 / numwero2;
                lblResultado.Text = $"Resultado: {resultado}";
            }
            catch (Exception ex)
            {

            }


        }
        
    }
}
