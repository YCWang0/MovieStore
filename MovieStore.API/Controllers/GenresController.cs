﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.ServiceInterfaces;

namespace MovieStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public GenresController(IGenreService genreService)
        {
            _genreService = genreService;
        }
        [HttpGet]
        [Route("genres")]
       public async Task<IActionResult> GetAllGenres([FromBody]IGenreService genreService)
        {
            var genres = await _genreService.GetAllGenres();
            return Ok(genres);
        }
        
    }
}