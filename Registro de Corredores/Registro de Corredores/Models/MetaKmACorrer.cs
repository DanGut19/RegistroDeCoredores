using System;
using System.Collections.Generic;
using System.Text;

namespace Registro_de_Corredores.Models
{
    [Serializable]

    public class MetaKmACorrer : RegistroDeCorredores
    {
        public double Km { get; set; }

        public double Horas { get; set; }



    }
}
