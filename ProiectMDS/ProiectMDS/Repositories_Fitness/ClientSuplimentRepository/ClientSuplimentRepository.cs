using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Contexts_Fitness;
using ProiectMDS.Model_Fitness;


namespace ProiectMDS.Repositories_Fitness.ClientSuplimentRepository
{
    public class ClientSuplimentRepository : IClientSuplimentRepository
    {
        public Context _context { get; set; }
        public ClientSuplimentRepository(Context context)
        {
            _context = context;
        }
        public ClientSupliment Create(ClientSupliment ClientSupliment)
        {
            var result = _context.Add<ClientSupliment>(ClientSupliment);
            _context.SaveChanges();
            return result.Entity;
        }
        public ClientSupliment Get(int Id)
        {
            return _context.ClientSuplimente.SingleOrDefault(x => x.clientSuplimentId == Id);
        }
        public List<ClientSupliment> GetAll()
        {
            return _context.ClientSuplimente.ToList();
        }
        public ClientSupliment Update(ClientSupliment ClientSupliment)
        {
            _context.Entry(ClientSupliment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return ClientSupliment;
        }
        public ClientSupliment Delete(ClientSupliment ClientSupliment)
        {
            var result = _context.Remove(ClientSupliment);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
