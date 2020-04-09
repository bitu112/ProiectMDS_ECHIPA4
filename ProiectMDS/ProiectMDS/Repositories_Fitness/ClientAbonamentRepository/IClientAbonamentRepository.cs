using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ProiectMDS.Model_Fitness;

namespace ProiectMDS.Repositories_Fitness.ClientAbonamentRepository
{
    public interface IClientAbonamentRepository
    {
        List<ClientAbonament> GetAll();
        ClientAbonament Get(int Id);
        ClientAbonament Create(ClientAbonament ClientAbonament);
        ClientAbonament Update(ClientAbonament ClientAbonament);
        ClientAbonament Delete(ClientAbonament ClientAbonament);

    }
}
