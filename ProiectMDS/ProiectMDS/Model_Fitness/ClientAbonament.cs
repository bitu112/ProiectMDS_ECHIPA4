using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Model_Fitness;


namespace ProiectMDS.Model_Fitness
{
    public class ClientAbonament
    {
        public int Id { get; set; }
        public int clientId { get; set; }
        public int abonamentId { get; set; }
        public virtual Client Client { get; set; }
        public virtual Abonament Abonament { get; set; }


    }
}
