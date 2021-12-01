using AutoMapper;
using GestionStock.Data.Models;
using GestionStock.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Controller
{
    class ArticlesController
    {

        private readonly ArticlesServices _service;
        private readonly IMapper _mapper;

        public ArticlesController(ArticlesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Articles
        [HttpGet]
        public ActionResult<IEnumerable<ArticlesDTO>> GetAllArticles()
        {
            IEnumerable<Article> listeArticles = _service.GetAllArticles();
            return Ok(_mapper.Map<IEnumerable<ArticlesDTO>>(listeArticles));
        }

        //GET api/Articles/{i}
        [HttpGet("{id}", Name = "GetArticleById")]
        public ActionResult<ArticlesDTO> GetArticleById(int id)
        {
            Article commandItem = _service.GetArticleById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<ArticlesDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Articles
        [HttpPost]
        public ActionResult<ArticlesDTO> CreateArticle(ArticlesDTOIn objIn)
        {
            Article obj = _mapper.Map<Article>(objIn);
            _service.AddArticle(obj);
            return CreatedAtRoute(nameof(GetArticleById), new { Id = obj.IdArticle }, obj);
        }

        //POST api/Articles/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateArticle(int id, ArticlesDTOIn obj)
        {
            Article objFromRepo = _service.GetArticleById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateArticle(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Articles/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialArticleUpdate(int id, JsonPatchDocument<Article> patchDoc)
        {
            Article objFromRepo = _service.GetArticleById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Article objToPatch = _mapper.Map<Article>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateArticle(objFromRepo);
            return NoContent();
        }

        //DELETE api/Articles/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteArticle(int id)
        {
            Article obj = _service.GetArticleById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteArticle(obj);
            return NoContent();
        }


    }
}
