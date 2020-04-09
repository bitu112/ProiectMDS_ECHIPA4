using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Model_Fitness;


namespace ProiectMDS.Repositories_Fitness.AngajatRepository
{
    public interface IAngajatRepository
    {
        List<Angajat> GetAll();
        Angajat Get(int Id);
        Angajat Create(Angajat Angajat);
        Angajat Update(Angajat Angajat);
        Angajat Delete(Angajat Angajat);

    }
}
