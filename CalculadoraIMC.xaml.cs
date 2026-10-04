namespace PracticaUI;

public partial class CalculadoraIMC : ContentPage
{
	public CalculadoraIMC()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (!double.TryParse(txtPeso.Text,out double peso) || !double.TryParse(txtAltura.Text, out double altura) || altura<=0) {
            await DisplayAlert("Error", "Por favor ingrese valores numericos validos", "Ok");
            return;

        }
        double imc = peso / (altura * altura);

        lblValorIMC.Text = imc.ToString("F1");

        if(imc < 18.5)
        {
            lblDiagnostico.Text = "Bajo peso";
            lblDiagnostico.TextColor = Colors.Red;
            brResultado.BackgroundColor = Color.FromArgb("#0F3123");
            brResultado.Stroke = Colors.Orange;
        }
        else if(imc <= 24.9)
        {
            lblDiagnostico.Text = "Peso normal";
            lblDiagnostico.TextColor = Colors.Green;
            brResultado.BackgroundColor = Colors.LightGreen;
            brResultado.Stroke = Colors.Green;
        }
        else if (imc <= 29.9)
        {
            lblDiagnostico.Text = "Sobrepeso";
            lblDiagnostico.TextColor = Colors.Blue;
            brResultado.BackgroundColor = Colors.LightBlue;
            brResultado.Stroke = Colors.Green;
        }
        else if (imc <= 34.9)
        {
            lblDiagnostico.Text = "Obesidad leve";
            lblDiagnostico.TextColor = Colors.Red;
            brResultado.BackgroundColor = Colors.LightPink;
            brResultado.Stroke = Colors.Red;
        }
        else if (imc <= 39.9)
        {
            lblDiagnostico.Text = "Obesidad Moderada";
            lblDiagnostico.TextColor = Colors.Black;
            brResultado.BackgroundColor = Colors.Red;
            brResultado.Stroke = Colors.Black;
        }
        else if (imc >= 40)
        {
            lblDiagnostico.Text = "Obesidad Morbida";
            lblDiagnostico.TextColor = Colors.DarkRed;
            brResultado.BackgroundColor = Colors.Red;
            brResultado.Stroke = Colors.DarkRed;
        }
        brResultado.IsVisible = true;

    }
}