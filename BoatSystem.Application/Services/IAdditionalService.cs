﻿using BoatSystem.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoatSystem.Core.Interfaces
{
    public interface IAdditionalService
    {
        Task<Addition> GetByIdAsync(int id);
        Task<IEnumerable<Addition>> GetByOwnerIdAsync(int ownerId);
        Task<Addition> AddAsync(Addition addition);
        Task<bool> UpdateAsync(Addition addition);
        Task<bool> DeleteAsync(int id);
    }
}
