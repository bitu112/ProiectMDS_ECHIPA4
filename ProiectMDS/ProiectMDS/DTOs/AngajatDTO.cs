using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Model_Fitness;

namespace ProiectMDS.DTOs
{
    public class AngajatDTO
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string numarTelefon { get; set; }
        public double Salariu { get; set; }

        public List<Abonament> abonaments { get; set; } 

    }
}
