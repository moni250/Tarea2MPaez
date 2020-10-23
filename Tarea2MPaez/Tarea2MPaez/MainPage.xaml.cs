using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea2MPaez
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double Parcial1 = Convert.ToDouble(txtDato1.Text);
                double Examen1 = Convert.ToDouble(txtExamen1.Text);
                double Parcial2 = Convert.ToDouble(txtDato2.Text);
                double Examen2 = Convert.ToDouble(txtExamen2.Text);
                double Resultado = 0;
                string Estado = "";


                if ((Parcial1 >= 0 && Parcial1 <= 10) && (Examen1 >= 0 && Examen1 <= 10) &&
                    (Parcial2 >= 0 && Parcial2 <= 10) && (Examen2 >= 0 && Examen2 <= 10))
                {
                    Resultado = ((Parcial1 * 0.3) + (Examen1 * 0.2)) + ((Parcial2 * 0.3) + (Examen2 * 0.2));

                    if (Resultado >= 7 && Resultado <= 10)
                    {
                        Estado = "Aprobado";
                    }
                    else if (Resultado >= 5 && Resultado < 7)
                    {
                        Estado = "Suspenso";
                    }
                    else if (Resultado >= 0 && Resultado < 5)
                    {
                        Estado = "Reprobado";
                    }

                    txtResultado.Text = Resultado.ToString();

                    DisplayAlert("Mensaje de Alerta", Estado, "Aceptar");
                }
                else
                {
                    Estado = "Valores no correspondientes";
                    DisplayAlert("Mensaje de Alerta", Estado, "Aceptar");
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", ex.Message, "Aceptar");
            }
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            // Abrir vista dos
            string user = txtUser.Text;
            string pass = txtPass.Text;

            await Navigation.PushAsync(new Vista_dos(user,pass));
        }
    }
}

