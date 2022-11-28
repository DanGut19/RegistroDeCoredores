using Registro_de_Corredores.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Registro_de_Corredores.ViewModels
{
    [Serializable]
    public class ViewModelsDistaciaRecorrida : INotifyPropertyChanged
    {

        public ViewModelsDistaciaRecorrida()
        {
            calcularDistancia = new Command(() => {

                DistanciaRecorrida c1 = new DistanciaRecorrida()
                {

                    distancia = this.distancia

                };

            });
        }

        public int distancia
        {
            get => distancia;

            set
            {
                distancia = value;
                var args = new PropertyChangedEventArgs(nameof(distancia));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command calcularDistancia { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
