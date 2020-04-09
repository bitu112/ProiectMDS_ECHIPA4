using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.DTOs
{
    public class ClientDTO
    {
        public string Name { get; set; }

        public string Prenume { get; set; }

        public string NumarTelefon { get; set; }

        public List<string> ClientAbonament { get; set; }
        public List<string> ClientSupliment { get; set; }

    }
}
