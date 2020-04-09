using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Model_Fitness;
using ProiectMDS.Repositories_Fitness.AbonamentRepository;
using ProiectMDS.Repositories_Fitness.ClientAbonamentRepository;
using ProiectMDS.Repositories_Fitness.ClientRepository;
using ProiectMDS.Repositories_Fitness.AngajatRepository;


namespace ProiectMDS.Control
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbonamentController : ControllerBase
    {
        public IAbonamentRepository IAbonamentRepository { get; set; }
        public IClientAbonamentRepository IClientAbonamentRepository { get; set; }
        public IClientRepository IClientRepository { get; set; }
        public IAngajatRepository IAngajatRepository { get; set; }

        public AbonamentController(IAbonamentRepository abonament, IClientAbonamentRepository clientAbonament, IClientRepository client, IAngajatRepository angajat)
        {
            IAbonamentRepository = abonament;
            IClientAbonamentRepository = clientAbonament;
            IClientRepository = client;
            IAngajatRepository = angajat;

        }
        // GET: api/Album
        [HttpGet]
        public ActionResult<IEnumerable<Abonament>> Get()
        {
            return IAbonamentRepository.GetAll();
        }

        [HttpGet("{id}", Name = "Get")]

        public AbonamentDetailsDTO Get(int id)
        {
            Abonament Abonament = IAbonamentRepository.Get(id);
            AbonamentDetailsDTO MyAbonament = new AbonamentDetailsDTO()
            {
                Tip = Abonament.tip,
                Pret = Abonament.pret,
            };

            IEnumerable<ClientAbonament> MyClientAbonaments = IClientAbonamentRepository.GetAll().Where(x => x.abonamentId == Abonament.abonamentId);
            if (MyClientAbonaments != null)
            {
                List<string> ClientNumeList = new List<string>();
                foreach (ClientAbonament MyClientAbonament in MyClientAbonaments)
                {
                    Client MyClient = IClientRepository.GetAll().SingleOrDefault(x => x.clientId == MyClientAbonament.clientId);
                    ClientNumeList.Add(MyClient.nume);
                }
                MyAbonament.ClientNume = ClientNumeList;
            }
            
            return MyAbonament;
        }

        // POST: api/Abonament
        [HttpPost]
        public void Post(AbonamentDTO value)
        {
            Abonament model = new Abonament()
            {
                tip = value.Tip,
                pret = value.Pret
            };
            IAbonamentRepository.Create(model);
            for (int i = 0; i < value.ClinetId.Count; i++)
            {
                ClientAbonament ClientAbonament = new ClientAbonament()
                {
                    abonamentId = model.abonamentId,
                    Id = value.ClinetId[i]
                };
                IClientAbonamentRepository.Create(ClientAbonament);
            }

        }


        [HttpPut("{id}")]
        public void Put(int id, AbonamentDTO value)
        {
            Abonament model = IAbonamentRepository.Get(id);

            if(value.Tip != null)
            {
                model.tip = value.Tip;
            }
            if(value.Pret != 0)
            {
                model.pret = value.Pret;
            }

            IAbonamentRepository.Update(model);
            if(value.ClinetId != null)
            {
                IEnumerable<ClientAbonament> MyArtistAlbums = IClientAbonamentRepository.GetAll().Where(x => x.abonamentId == id);
                foreach (ClientAbonament MyClientAbonament in MyArtistAlbums)
                {
                    IClientAbonamentRepository.Delete(MyClientAbonament);
                }
                for (int i = 0; i < value.ClinetId.Count; i++)
                {
                    ClientAbonament ClientAbonament = new ClientAbonament()
                    {
                        abonamentId = model.abonamentId,
                        clientId = value.ClinetId[i]
                    };
                    IClientAbonamentRepository.Create(ClientAbonament);
                }


            }

        }
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Abonament Delete(int id)
        {
            Abonament abonament = IAbonamentRepository.Get(id);
            return IAbonamentRepository.Delete(abonament);
        }



    }
}
