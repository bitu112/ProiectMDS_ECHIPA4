using ProiectMDS.Model_Fitness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Model_Fitness
{
    public class Client
    {
        public int clientId { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string numarTelefon { get; set; }
        public List<ClientAbonament> ClientAbonament { get; set; }
        public List<ClientSupliment> ClientSupliment { get; set; }

    }
}
