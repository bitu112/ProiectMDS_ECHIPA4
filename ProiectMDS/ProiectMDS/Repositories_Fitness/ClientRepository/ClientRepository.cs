using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Contexts_Fitness;
using ProiectMDS.Model_Fitness;


namespace ProiectMDS.Repositories_Fitness.ClientRepository
{
    public class ClientRepository : IClientRepository
    {
        public Context _context { get; set; }
        public ClientRepository(Context context)
        {
            _context = context;
        }
        public Client Create(Client Client)
        {
            var result = _context.Add<Client>(Client);
            _context.SaveChanges();
            return result.Entity;
        }
        public Client Get(int Id)
        {
            return _context.Clienti.SingleOrDefault(x => x.clientId == Id);
        }
        public List<Client> GetAll()
        {
            return _context.Clienti.ToList();
        }
        public Client Update(Client Client)
        {
            _context.Entry(Client).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Client;
        }
        public Client Delete(Client Client)
        {
            var result = _context.Remove(Client);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
