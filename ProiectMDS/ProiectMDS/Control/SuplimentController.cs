using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.Repositories_Fitness.SuplimentRepository;
using ProiectMDS.Model_Fitness;
using ProiectMDS.DTOs;


namespace ProiectMDS.Control
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuplimentController : ControllerBase
    {
        public SuplimentController(ISuplimentRepository repository)
        {
            ISuplimentRepository = repository;
        }
        public ISuplimentRepository ISuplimentRepository { get; set; }
        // GET: api/Supliment
        [HttpGet]
        public ActionResult<IEnumerable<Supliment>> Get()
        {
            return ISuplimentRepository.GetAll();
        }

        // GET: api/Supliment/5
        [HttpGet("{id}")]
        public ActionResult<Supliment> Get(int id)
        {
            return ISuplimentRepository.Get(id);
        }

        // POST: api/Supliment
        [HttpPost]
        public Supliment Post(SuplimentDTO value)
        {
            Supliment model = new Supliment()
            {
                denumire = value.Denumire,
                pret =  value.Pret,
                tip = value.Tip
            };
            return ISuplimentRepository.Create(model);
        }

        // PUT: api/Supliment/5
        [HttpPut("{id}")]
        public Supliment Put(int id, SuplimentDTO value)
        {
            Supliment model = ISuplimentRepository.Get(id);
            if (value.Denumire != null)
            {
                model.denumire = value.Denumire;
            }
            if (value.Pret != 0)
            {
                model.pret = value.Pret;
            }
            if (value.Tip != null)
            {
                model.tip = value.Tip;
            }
            return ISuplimentRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Supliment Delete(int id)
        {
            Supliment model = ISuplimentRepository.Get(id);
            return ISuplimentRepository.Delete(model);
        }
    }
}
