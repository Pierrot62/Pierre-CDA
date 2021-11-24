using APISurPlusieurTables.Data.Dtos;
using APISurPlusieurTables.Data.Models;
using APISurPlusieurTables.Data.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISurPlusieurTables.Controllers
{   
    [Route("api/Voiture")]
    [ApiController]
    public class VoitureController : ControllerBase
    {
        private readonly VoitureServices _service;
        private readonly IMapper _mapper;

        public VoitureController(VoitureServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VoitureDTO>> GetAllVoitures()
        {
            var listeVoitures = _service.GetAllVoitures();
            return Ok(_mapper.Map<IEnumerable<VoitureDTO>>(listeVoitures));
        }

        [HttpGet("id", Name = "GetVoitureById")]
        public ActionResult<VoitureDTO> GetVoitureById(int id)
        {
            var commandItem = _service.GetVoitureById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<VoitureDTO>(commandItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<VoitureDTO> CreateVoiture(Voiture voiture)
        {
            _service.AddVoiture(voiture);
            return CreatedAtRoute(nameof(GetVoitureById), new { IdVoiture = voiture.IdVoiture }, voiture);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateVoiture(int id, VoitureDTO voiture)
        {
            var voitureFromRepo = _service.GetVoitureById(id);
            if (voitureFromRepo == null)
            {
                return NotFound();
            }
            voitureFromRepo.Dump();
            _mapper.Map(voiture, voitureFromRepo);
            voitureFromRepo.Dump();
            voiture.Dump();
            _service.UpdateVoiture(voitureFromRepo);
            return NoContent();
        }


        //DELETE
        [HttpDelete("{id}")]
        public ActionResult DeleteVoiture(int id)
        {
            var voitureModelFromRepo = _service.GetVoitureById(id);
            if (voitureModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteVoiture(voitureModelFromRepo);
            return NoContent();
        }
    }
}
