﻿using Microsoft.AspNetCore.Mvc;
using CursosOnline.Infraestructure.Interfaces;


namespace CursosOnline.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository categoriaRepository;
        
        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            this.categoriaRepository = categoriaRepository;
           
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            
            var categories =  await this.categoriaRepository.GetAll();

            return Ok(categories);
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
