using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.Model_Fitness;
using ProiectMDS.DTOs;
using ProiectMDS.Repositories_Fitness.ClientAbonamentRepository;


namespace ProiectMDS.Control
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientAbonamentController : ControllerBase
    {
        public ClientAbonamentController(IClientAbonamentRepository repository)
        {
            IClientAbonamentRepository = repository;
        }
        public IClientAbonamentRepository IClientAbonamentRepository { get; set; }

        // GET: api/ClientAbonament
        [HttpGet]
        public ActionResult<IEnumerable<ClientAbonament>> Get()
        {
            return IClientAbonamentRepository.GetAll();
        }

        // GET: api/ClientAbonament/5
        [HttpGet("{id}")]
        public ActionResult<ClientAbonament> Get(int id)
        {
            return IClientAbonamentRepository.Get(id);
        }

        // POST: api/ClientAbonament
        [HttpPost]
        public ClientAbonament Post(ClientAbonamentDTO value)
        {
            ClientAbonament model = new ClientAbonament()
            {
                clientId = value.ClientId,
                abonamentId = value.AbonamentId
            };
            return IClientAbonamentRepository.Create(model);
        }

        // PUT: api/ClientAbonament/5
        [HttpPut("{id}")]
        public ClientAbonament Put(int id, ClientAbonamentDTO value)
        {
            ClientAbonament model = IClientAbonamentRepository.Get(id);
            if (value.ClientId != 0)
            {
                model.clientId = value.ClientId;
            }
            if (value.AbonamentId != 0)
            {
                model.abonamentId = value.AbonamentId;
            }
            return IClientAbonamentRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ClientAbonament Delete(int id)
        {
            ClientAbonament model = IClientAbonamentRepository.Get(id);
            return IClientAbonamentRepository.Delete(model);
        }
    }
}
