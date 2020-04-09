using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Model_Fitness;
using ProiectMDS.Repositories_Fitness.AngajatRepository;


namespace ProiectMDS.Control
{
    [Route("api/[controller]")]
    [ApiController]
    public class AngajatController : Controller
    {
        // GET: Angajat
        public AngajatController(IAngajatRepository repository)
        {
            IAngajatRepository = repository;
        }
        public IAngajatRepository IAngajatRepository { get; set; }
        // GET: api/Provider
        [HttpGet]
        public ActionResult<IEnumerable<Angajat>> Get()
        {
            return IAngajatRepository.GetAll();
        }

        // GET: api/Provider/5
        [HttpGet("{id}")]
        public ActionResult<Angajat> Get(int id)
        {
            return IAngajatRepository.Get(id);
        }

        // POST: api/Provider
        [HttpPost]
        public Angajat Post(AngajatDTO value)
        {
            Angajat model = new Angajat()
            {
                nume = value.Nume,
                prenume = value.Prenume,
                numarTelefon = value.numarTelefon,
                salariu = value.Salariu
            };
            return IAngajatRepository.Create(model);
        }

        // PUT: api/Provider/5
        [HttpPut("{id}")]
        public Angajat Put(int id, AngajatDTO value)
        {
            Angajat model = IAngajatRepository.Get(id);
            if (value.Nume != null)
            {
                model.nume = value.Nume;
            }
            if (value.Prenume != null)
            {
                model.prenume = value.Prenume;
            }
            if (value.numarTelefon != null)
            {
                model.numarTelefon = value.numarTelefon;
            }
            if (value.Salariu != 0)
            {
                model.salariu = value.Salariu;
            }

            return IAngajatRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Angajat Delete(int id)
        {
            Angajat model = IAngajatRepository.Get(id);
            return IAngajatRepository.Delete(model);
        }
    }
}