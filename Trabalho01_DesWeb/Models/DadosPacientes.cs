using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho01_DesWeb.Models
{
    public class DadosPacientes
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string sexo { get; set; }
        public string estadoCivil { get; set; }
        public bool possuiComorbidade { get; set; }
        public DateTime data { get; set; }

    }
}
