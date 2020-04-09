using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Contexts_Fitness;
using ProiectMDS.Model_Fitness;


namespace ProiectMDS.Repositories_Fitness.AngajatRepository
{
    public class AngajatRepository : IAngajatRepository
    {
        public Context _context { get; set; }
        public AngajatRepository(Context context)
        {
            _context = context;
        }
        public Angajat Create(Angajat Angajat)
        {
            var result = _context.Add<Angajat>(Angajat);
            _context.SaveChanges();
            return result.Entity;
        }
        public Angajat Get(int Id)
        {
            return _context.Angajati.SingleOrDefault(x => x.angajatId == Id);
        }
        public List<Angajat> GetAll()
        {
            return _context.Angajati.ToList();
        }
        public Angajat Update(Angajat Angajat)
        {
            _context.Entry(Angajat).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Angajat;
        }
        public Angajat Delete(Angajat Angajat)
        {
            var result = _context.Remove(Angajat);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
