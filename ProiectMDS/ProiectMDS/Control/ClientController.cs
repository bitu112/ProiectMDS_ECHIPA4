using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Model_Fitness;
using ProiectMDS.Repositories_Fitness.ClientRepository;


namespace ProiectMDS.Control
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        public ClientController(IClientRepository repository)
        {
            IClientRepository = repository;
        }
        public IClientRepository IClientRepository { get; set; }

        // GET: api/Client
        [HttpGet]
        public ActionResult<IEnumerable<Client>> Get()
        {
            return IClientRepository.GetAll();
        }

        // GET: api/Client/5
        [HttpGet("{id}")]
        public ActionResult<Client> Get(int id)
        {
            return IClientRepository.Get(id);
        }

        // POST: api/Client
        [HttpPost]
        public Client Post(ClientDTO value)
        {
            Client model = new Client()
            {
                nume = value.Name,
                prenume = value.Prenume,
                numarTelefon = value.NumarTelefon
            };
            return IClientRepository.Create(model);
        }

        // PUT: api/Client/5
        [HttpPut("{id}")]
        public Client Put(int id, ClientDTO value)
        {
            Client model = IClientRepository.Get(id);
            if (value.Name != null)
            {
                model.nume = value.Name;
            }
            if (value.Prenume != null)
            {
                model.prenume = value.Prenume;
            }
            if (value.NumarTelefon != null)
            {
                model.numarTelefon = value.NumarTelefon;
            }
            return IClientRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Client Delete(int id)
        {
            Client model = IClientRepository.Get(id);
            return IClientRepository.Delete(model);
        }
    }
}