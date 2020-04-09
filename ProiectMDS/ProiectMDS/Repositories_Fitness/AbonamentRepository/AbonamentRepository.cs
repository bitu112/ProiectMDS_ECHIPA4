using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Contexts_Fitness;
using ProiectMDS.Model_Fitness;

namespace ProiectMDS.Repositories_Fitness.AbonamentRepository
{
    public class AbonamentRepository:IAbonamentRepository
    {
        public Context _context { get; set; }
        public AbonamentRepository(Context context)
        {
            _context = context;
        }
        public Abonament Create(Abonament Abonament)
        {
            var result = _context.Add<Abonament>(Abonament);
            _context.SaveChanges();
            return result.Entity;
        }
        public Abonament Get(int Id)
        {
            return _context.Abonamente.SingleOrDefault(x => x.abonamentId == Id);
        }
        public List<Abonament> GetAll()
        {
            return _context.Abonamente.ToList();
        }
        public Abonament Update(Abonament Abonament)
        {
            _context.Entry(Abonament).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Abonament;
        }
        public Abonament Delete(Abonament Abonament)
        {
            var result = _context.Remove(Abonament);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
