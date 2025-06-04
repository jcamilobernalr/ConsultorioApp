using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioApp
{
    public class MedicamentoRecetado
    {
        public string Nombre { get; set; }
        public string Dosis { get; set; }
        public string Frecuencia { get; set; }
        public string Duracion { get; set; }

        public override string ToString()
        {
            return $"℞ {Nombre}: {Dosis}, {Frecuencia}, durante {Duracion}.";
        }
    }
}
