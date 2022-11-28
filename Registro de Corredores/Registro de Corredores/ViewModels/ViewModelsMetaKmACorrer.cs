using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Registro_de_Corredores.ViewModels
{
    public class ViewModelsMetaKmACorrer : INotifyPropertyChanged
    {
        public new void Button_Command()
        {
            var km = double.Parse(Km.Text);
            var horas = double.Parse(Horas.Text);

            var imc = horas / (km * km);
            IMC.Text = imc.ToString();

            string resultado = "";

            if (imc < 14)
            {
                resultado = "No cumplistes la meta";
            }
            else if(imc >=20 && imc <=26)
            {
                resultado = "Llegastes a la mita de la meta";
            }
            else if (imc >=27 && imc <= 33)
            {
                resultado = "Cumplistes la meta";
            }
            else
            {
                resultado = "Felicidades has completado tu meta";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
