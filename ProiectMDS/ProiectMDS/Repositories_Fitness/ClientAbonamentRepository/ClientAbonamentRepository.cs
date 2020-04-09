using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Contexts_Fitness;
using ProiectMDS.Model_Fitness;


namespace ProiectMDS.Repositories_Fitness.ClientAbonamentRepository
{
    public class ClientAbonamentRepository : IClientAbonamentRepository
    {
        public Context _context { get; set; }
        public ClientAbonamentRepository(Context context)
        {
            _context = context;
        }
        public ClientAbonament Create(ClientAbonament ClientAbonament)
        {
            var result = _context.Add<ClientAbonament>(ClientAbonament);
            _context.SaveChanges();
            return result.Entity;
        }
        public ClientAbonament Get(int Id)
        {
            return _context.ClientAbonamente.SingleOrDefault(x => x.clientId == Id);
        }
        public List<ClientAbonament> GetAll()
        {
            return _context.ClientAbonamente.ToList();
        }
        public ClientAbonament Update(ClientAbonament ClientAbonament)
        {
            _context.Entry(ClientAbonament).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return ClientAbonament;
        }
        public ClientAbonament Delete(ClientAbonament ClientAbonament)
        {
            var result = _context.Remove(ClientAbonament);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
