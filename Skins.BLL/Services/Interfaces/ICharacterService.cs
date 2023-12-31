﻿using Skins.Data.Interfaces;
using Skins.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skins.BLL.Services.Interfaces
{
    public interface ICharacterService
    {
        Task<IBaseResponse<CharacterDTO>> GetById(Guid id);
        Task<IBaseResponse<IEnumerable<CharacterDTO>>> GetAll();
        Task<IBaseResponse<string>> Insert(CharacterDTO modelDto);
        Task<IBaseResponse<string>> DeleteById(Guid id);
    }
}
