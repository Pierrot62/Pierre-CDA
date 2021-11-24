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
    [Route("api/Employer")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        private readonly EmployerServices _service;
        private readonly IMapper _mapper;

        public EmployerController(EmployerServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<EmployerDTO>> GetAllEmployers()
        {
            IEnumerable<Employer> listeEmployers = _service.GetAllEmployers();
            return Ok(_mapper.Map<IEnumerable<EmployerDTO>>(listeEmployers));
        }

        [HttpGet("{id}", Name = "GetEmployerById")]
        public ActionResult<EmployerDTO> GetEmployerById(int id)
        {
            var commandItem = _service.GetEmployerById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<EmployerDTO>(commandItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<EmployerDTO> CreateEmployer(Employer employer)
        {
            _service.AddEmployer(employer);
            return CreatedAtRoute(nameof(GetEmployerById), new { IdEmployer = employer.IdEmployer }, employer);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateEmployer(int id, EmployerDTO employer)
        {
            var employerFromRepo = _service.GetEmployerById(id);
            if (employerFromRepo == null)
            {
                return NotFound();
            }
            employerFromRepo.Dump();
            _mapper.Map(employer, employerFromRepo);
            employerFromRepo.Dump();
            employer.Dump();
            _service.UpdateEmployer(employerFromRepo);
            return NoContent();
        }


        //DELETE
        [HttpDelete("{id}")]
        public ActionResult DeleteEmployer(int id)
        {
            var employerModelFromRepo = _service.GetEmployerById(id);
            if (employerModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteEmployer(employerModelFromRepo);
            return NoContent();
        }
    }
}
