
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Model_Fitness
{
    public class ClientSupliment
    {
        public int clientSuplimentId { get; set; }
        public int clientId { get; set; }
        public int suplimentId { get; set; }        
        public virtual Supliment Supliment { get; set; }
        public virtual Client Client { get; set; }
    }
}
