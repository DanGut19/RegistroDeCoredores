using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Registro_de_Corredores.ViewModels
{
    public class ViewModelsValiadrDistancia : INotifyPropertyChanged
    {
        public new void Vdistancia()
        {
            var kilometros = double.Parse(Kilometros.Text);
            var horas = double.Parse(Horas.Text);

            var imc = horas / (kilometros * kilometros);
            IMC.Text = imc.ToString();

            string resultado = "";

            if (imc < 100)
            {
                resultado = "Recorristes una Distancia Corta";
            }
            else if (imc >= 110 && imc <= 120)
            {
                resultado = "Recorristes una Distancia Medio";
            }
            else if (imc >= 120 && imc <= 130)
            {
                resultado = "Recorristes una Distancia Larga";
            }
            else
            {
                resultado = "Felicidades has recorrido la distancia planeada";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
