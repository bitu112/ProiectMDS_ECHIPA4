using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Model_Fitness
{
    public class Supliment
    {
        public int suplimentId { get; set; }
        public string denumire { get; set; }
        public double pret { get; set; }
        public string tip { get; set; }
        public List<ClientSupliment> ClientSupliment { get; set; }
    }
}
