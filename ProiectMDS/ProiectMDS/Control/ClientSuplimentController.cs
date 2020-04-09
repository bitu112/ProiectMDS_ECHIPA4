using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.Repositories_Fitness.ClientSuplimentRepository;
using ProiectMDS.DTOs;
using ProiectMDS.Model_Fitness;


namespace ProiectMDS.Control
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientSuplimentController : Controller
    {
        public ClientSuplimentController(IClientSuplimentRepository repository)
        {
            IClientSuplimentRepository = repository;
        }
        public IClientSuplimentRepository IClientSuplimentRepository { get; set; }

        // GET: api/ClientSupliment
        [HttpGet]
        public ActionResult<IEnumerable<ClientSupliment>> Get()
        {
            return IClientSuplimentRepository.GetAll();
        }

        // GET: api/ClientSupliment/5
        [HttpGet("{id}")]
        public ActionResult<ClientSupliment> Get(int id)
        {
            return IClientSuplimentRepository.Get(id);
        }

        // POST: api/ClientSupliment
        [HttpPost]
        public ClientSupliment Post(ClientSuplimentDTO value)
        {
            ClientSupliment model = new ClientSupliment()
            {
                clientId = value.ClientId,
                suplimentId = value.SuplimentId
            };
            return IClientSuplimentRepository.Create(model);
        }

        // PUT: api/ClientSupliment/5
        [HttpPut("{id}")]
        public ClientSupliment Put(int id, ClientSuplimentDTO value)
        {
            ClientSupliment model = IClientSuplimentRepository.Get(id);
            if (value.ClientId != 0)
            {
                model.clientId = value.ClientId;
            }
            if (value.SuplimentId != 0)
            {
                model.suplimentId = value.SuplimentId;
            }
            return IClientSuplimentRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ClientSupliment Delete(int id)
        {
            ClientSupliment model = IClientSuplimentRepository.Get(id);
            return IClientSuplimentRepository.Delete(model);
        }
    }
}