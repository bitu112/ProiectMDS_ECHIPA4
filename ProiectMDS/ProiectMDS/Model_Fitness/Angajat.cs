using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Model_Fitness
{
    public class Angajat
    {
        public int angajatId { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public double salariu { get; set; }
        public string numarTelefon { get; set; }
        public virtual Abonament Abonament { get; set; }
    }
}
