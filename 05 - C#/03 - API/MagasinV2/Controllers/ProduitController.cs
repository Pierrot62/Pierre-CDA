using AutoMapper;
using Magasin.Data.Dtos;
using Magasin.Data.Models;
using Magasin.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magasin.Controllers
{   
    //URL Permettant d'arriver sur le controller
    [Route("api/Produit")]
    [ApiController]

    public class ProduitController : ControllerBase
    {
        private readonly ProduitServices _service;
        private readonly IMapper _mapper;

        public ProduitController(ProduitServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProduitDTO>> GetAllProduit()
        {
            //Appel de la fonction GetAllProtuit qui ce trouver dans ProduitServices
            IEnumerable<Produit> listeProduit = _service.GetAllProduit();
            return Ok(_mapper.Map<IEnumerable<ProduitDTO>>(listeProduit));
        }

        [HttpGet("{idProd}", Name = "GetProduitById")]
        public ActionResult<Produit> GetProduitByid(int idProd)
        {
            Produit prod = _service.GetProduitById(idProd);
            return Ok(_mapper.Map<ProduitDTO>(prod));
        }

        [HttpPost]
        public ActionResult CreateProduit(Produit prod)
        {
            //Appel de la fonction AddProduit dans ProduitServices avec en parametre un objet produit
            _service.AddProduit(prod);

            return NoContent();
        }

        [HttpPut("{idProd}")]
        //prod = Nouvelle valeur a set au produit dont l'Id et passer en parametre
        public ActionResult UpdateProduit(int idProduit, Produit prod)
        {
            var ProduitAModif = _service.GetProduitById(idProduit);
            if (ProduitAModif == null)
            {
                return NotFound();
            }
            _mapper.Map(prod, ProduitAModif);
            _service.UpdateProduit(prod);
            return NoContent();
        }
    }
}
