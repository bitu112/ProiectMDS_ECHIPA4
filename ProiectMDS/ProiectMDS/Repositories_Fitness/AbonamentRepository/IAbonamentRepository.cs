using ProiectMDS.Model_Fitness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Repositories_Fitness.AbonamentRepository
{
    public interface IAbonamentRepository
    {
        List<Abonament> GetAll();
        Abonament Get(int Id);
        Abonament Create(Abonament Abonament);
        Abonament Update(Abonament Abonament);
        Abonament Delete(Abonament Abonament);
    }
}
