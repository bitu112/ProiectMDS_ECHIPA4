using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.DTOs
{
    public class AbonamentDTO
    {
        public string Tip { get; set; }

        public double Pret { get; set; }

        public List<int> ClinetId { get; set; }
        public List<int> AngajatId { get; set; }

    }
}
