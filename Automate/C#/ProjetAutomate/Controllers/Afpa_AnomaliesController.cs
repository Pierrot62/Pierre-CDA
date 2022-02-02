using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjetAutomate.Data.Dtos;
using ProjetAutomate.Data.Models;
using ProjetAutomate.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class Afpa_AnomaliesController:ControllerBase
    {

        private readonly Afpa_AnomaliesServices _service;
        private readonly IMapper _mapper;

        public Afpa_AnomaliesController(Afpa_AnomaliesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Afpa_Anomalies
        [HttpGet]
        public ActionResult<IEnumerable<Afpa_AnomaliesDTOOut>> GetAllAfpa_Anomalies()
        {
            IEnumerable<Afpa_Anomalie> listeAfpa_Anomalies = _service.GetAllAfpa_Anomalies();
            return Ok(_mapper.Map<IEnumerable<Afpa_AnomaliesDTOOut>>(listeAfpa_Anomalies));
        }

        //GET api/Afpa_Anomalies/{i}
        [HttpGet("{id}", Name = "GetAfpa_AnomalieById")]
        public ActionResult<Afpa_AnomaliesDTOOut> GetAfpa_AnomalieById(int id)
        {
            Afpa_Anomalie commandItem = _service.GetAfpa_AnomalieById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<Afpa_AnomaliesDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Afpa_Anomalies
        [HttpPost]
        public ActionResult<Afpa_AnomaliesDTOIn> CreateAfpa_Anomalie(Afpa_AnomaliesDTOIn objIn)
        {
            Afpa_Anomalie obj = _mapper.Map<Afpa_Anomalie>(objIn);
            _service.AddAfpa_Anomalie(obj);
            return CreatedAtRoute(nameof(GetAfpa_AnomalieById), new { Id = obj.IdAnomalie }, obj);
        }

        //POST api/Afpa_Anomalies/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateAfpa_Anomalie(int id, Afpa_AnomaliesDTOIn obj)
        {
            Afpa_Anomalie objFromRepo = _service.GetAfpa_AnomalieById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateAfpa_Anomalie(objFromRepo);
            return NoContent();
        }

        //DELETE api/Afpa_Anomalies/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteAfpa_Anomalie(int id)
        {
            Afpa_Anomalie obj = _service.GetAfpa_AnomalieById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteAfpa_Anomalie(obj);
            return NoContent();
        }


    }
}
