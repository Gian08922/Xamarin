using System;
using System.Collections.Generic;
using System.Text;

namespace DagZaf.ViewModel
{
    public class Restaurante
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }
        public string ImgUrl { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
