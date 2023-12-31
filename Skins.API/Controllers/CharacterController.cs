﻿using Microsoft.AspNetCore.Mvc;
using Skins.BLL.Services.Interfaces;
using Skins.Data.Dtos;

namespace Skins.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _service;

        public CharacterController(ICharacterService service)
        {
            _service = service;
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<CharacterDTO>> GetById(Guid id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<CharacterDTO>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpPost]
        public async Task<ActionResult> Insert([FromBody] CharacterDTO modelDTO)
        {
            return Ok(await _service.Insert(modelDTO));
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteById(Guid id)
        {
            return Ok(await _service.DeleteById(id));
        }
    }
}
