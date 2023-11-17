﻿using PetShower.Domain.Models;

namespace PetShower.Infrastructure.Repositories.Interfaces
{
    public interface IBreedRepository
    {
        Task<Breed?> GetByIdAsync(long id);
        Task<List<Breed?>> GetAllAsync();
        Task<Breed?> CreateAsync(Breed breed);
        Task<Breed?> UpdateAsync(Breed breed);
        Task DeleteAsync(long id);
    }
}
