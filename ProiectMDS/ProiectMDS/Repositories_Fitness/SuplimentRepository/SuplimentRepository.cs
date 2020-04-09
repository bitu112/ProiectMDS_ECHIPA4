using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Contexts_Fitness;
using ProiectMDS.Model_Fitness;

namespace ProiectMDS.Repositories_Fitness.SuplimentRepository
{
    public class SuplimentRepository : ISuplimentRepository
    {
        public Context _context { get; set; }
        public SuplimentRepository(Context context)
        {
            _context = context;
        }
        public Supliment Create(Supliment Supliment)
        {
            var result = _context.Add<Supliment>(Supliment);
            _context.SaveChanges();
            return result.Entity;
        }
        public Supliment Get(int Id)
        {
            return _context.Suplimente.SingleOrDefault(x => x.suplimentId == Id);
        }
        public List<Supliment> GetAll()
        {
            return _context.Suplimente.ToList();
        }
        public Supliment Update(Supliment Supliment)
        {
            _context.Entry(Supliment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Supliment;
        }
        public Supliment Delete(Supliment Supliment)
        {
            var result = _context.Remove(Supliment);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
