using System;
using System.Collections.Generic;
using System.Text;

namespace Registro_de_Corredores.Models
{
    [Serializable]
    public class DistanciaRecorrida : RegistroDeCorredores
    {

        public double tiempo { get; set; }

        public double velocidad { get; set; }


        public void calcularDistancia()
        {
            distancia = tiempo * velocidad;
        }
    }
}
