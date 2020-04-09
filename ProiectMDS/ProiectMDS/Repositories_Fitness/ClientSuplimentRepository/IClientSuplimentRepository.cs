using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Model_Fitness; 

namespace ProiectMDS.Repositories_Fitness.ClientSuplimentRepository
{
    public interface IClientSuplimentRepository
    {
        List<ClientSupliment> GetAll();
        ClientSupliment Get(int Id);
        ClientSupliment Create(ClientSupliment ClientSupliment);
        ClientSupliment Update(ClientSupliment ClientSupliment);
        ClientSupliment Delete(ClientSupliment ClientSupliment);
    }
}
