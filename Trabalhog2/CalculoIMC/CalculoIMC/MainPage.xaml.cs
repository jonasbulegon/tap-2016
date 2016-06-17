using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace CalculoIMC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double peso = 0, altura = 0, imc = 0;
            try
            {
                //Valida se Altura e Peso foram informados
                if (txtPeso.Text=="")
                {
                    lblResultado.Text = "Digite o peso e a altura!";
                    return;
                }
                if (txtAltura.Text == "")
                {
                    lblResultado.Text = "Digite o peso e a altura!";
                    return;
                }

                //Converte os textos em doubles para fazer as contas
                peso = double.Parse(txtPeso.Text);
                altura = double.Parse(txtAltura.Text);

                //Calcula o imc com a fórmula peso/(altura²) e arredonda com 2 casas decimais
                imc = Math.Round(peso / (Math.Pow(altura, 2)), 2);
                lblResultado.Text = imc.ToString();

                //Os valores e classificações abaixo foram retirados do site http://pt.wikipedia.org/wiki/%C3%8Dndice_de_massa_corporal
                if (imc < 18.5)
                {
                    lblResultado.Text = "Abaixo do Peso"; lblResultado.Foreground = new SolidColorBrush(Colors.Orange);
                }
                else if (imc > 18.5 && imc < 25)
                {
                    lblResultado.Text = "Saudável"; lblResultado.Foreground = new SolidColorBrush(Colors.Green);
                }
                else if (imc >= 25 && imc < 30)
                {
                    lblResultado.Text = "Sobrepeso"; lblResultado.Foreground = new SolidColorBrush(Colors.Orange);
                }
                else if (imc >= 30 && imc < 35)
                {
                    lblResultado.Text = "Obesidade Grau I"; lblResultado.Foreground = new SolidColorBrush(Colors.Red);
                }
                else if (imc >= 35 && imc < 40)
                {
                    lblResultado.Text = "Obesidade Grau II (severa)"; lblResultado.Foreground = new SolidColorBrush(Colors.Red);
                }
                else if (imc >= 40)
                {
                    lblResultado.Text = "Obesidade Grau III (mórbida)"; lblResultado.Foreground = new SolidColorBrush(Colors.Red);
                }

            }
            catch (Exception)
            {
                //Se ocorrer erro durante o calculo retorna erro
                txtPeso.Text = "0";
                txtAltura.Text = "0";
                lblResultado.Text = "Digite o peso e a altura!";
            }


        }
    }
}
