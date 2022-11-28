using System;
using System.Collections.Generic;
using System.Text;

namespace Registro_de_Corredores.Models
{
    [Serializable]
    public class RegistroDeCorredores
    {
        public string Nombre { get; set; }

        public string Campo { get; set; }

        public string Edad { get; set; }

        public string Correr { get; set; }

        public double distancia { get; set; }

    }
}
