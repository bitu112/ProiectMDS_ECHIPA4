using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Model_Fitness
{
    public class Abonament
    {
        public int abonamentId { get; set; }
        public string tip { get; set; }
        public double pret { get; set; }
        public List <ClientAbonament> ClientAbonament { get; set; }
        public List <Angajat> Angajat { get; set; }  
    }
}
