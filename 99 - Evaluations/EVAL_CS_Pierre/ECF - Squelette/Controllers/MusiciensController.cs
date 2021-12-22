using AutoMapper;
using GestionGroupeDeMusique.Data;
using GestionGroupeDeMusique.Data.Dtos;
using GestionGroupeDeMusique.Data.Models;
using GestionGroupeDeMusique.Data.Profiles;
using GestionGroupeDeMusique.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGroupeDeMusique.Controllers
{
    class MusiciensController : ControllerBase
    {

        private readonly MusiciensServices _service;
        private readonly IMapper _mapper;

        public MusiciensController(EcfContext _context)
        {
            _service = new MusiciensServices(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MusiciensProfiles>();
            });
            _mapper = config.CreateMapper();
        }

        //GET api/Musiciens
        [HttpGet]
        public IEnumerable<MusiciensDTOOut> GetAllMusiciens()
        {
            IEnumerable<Musicien> listeMusiciens = _service.GetAllMusiciens();
            return _mapper.Map<IEnumerable<MusiciensDTOOut>>(listeMusiciens);
        }

        [HttpGet]
        public IEnumerable<MusiciensDTOOutAvecGroupe> GetAllMusiciensAvecGroupe()
        {
            IEnumerable<Musicien> listeMusiciens = _service.GetAllMusiciensAvecGroupe();
            return _mapper.Map<IEnumerable<MusiciensDTOOutAvecGroupe>>(listeMusiciens);
        }

        //GET api/Musiciens/{i}
        [HttpGet("{id}", Name = "GetMusicienById")]
        public ActionResult<MusiciensDTOOut> GetMusicienById(int id)
        {
            Musicien commandItem = _service.GetMusicienById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<MusiciensDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Musiciens
        [HttpPost]
        public ActionResult<MusiciensDTOIn> CreateMusicien(MusiciensDTOIn objIn)
        {
            Musicien obj = _mapper.Map<Musicien>(objIn);
            _service.AddMusicien(obj);
            return CreatedAtRoute(nameof(GetMusicienById), new { Id = obj.IdMusicien }, obj);
        }

        //POST api/Musiciens/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateMusicien(int id, MusiciensDTOIn obj)
        {
            Musicien objFromRepo = _service.GetMusicienById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateMusicien(objFromRepo);
            return NoContent();
        }

        //DELETE api/Musiciens/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteMusicien(int id)
        {
            Musicien obj = _service.GetMusicienById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteMusicien(obj);
            return NoContent();
        }


    }
}
