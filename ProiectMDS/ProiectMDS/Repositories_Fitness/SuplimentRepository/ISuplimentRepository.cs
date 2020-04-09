using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Model_Fitness;

namespace ProiectMDS.Repositories_Fitness.SuplimentRepository
{
    public interface ISuplimentRepository
    {
        List<Supliment> GetAll();
        Supliment Get(int Id);
        Supliment Create(Supliment Supliment);
        Supliment Update(Supliment Supliment);
        Supliment Delete(Supliment Supliment);
    }
}
