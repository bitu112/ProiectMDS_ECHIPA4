using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.DTOs
{
    public class AbonamentDetailsDTO
    {
        public string Tip { get; set; }
        public double Pret { get; set; }
        
        public List<string> ClientNume { get; set; }
        public List<string> AngajatNume { get; set; }

    }
}
