﻿using System.Collections;
using System.Collections.Generic;
using PetShop.Core.Entities;

namespace PetShop.Core.DomainService
{
    public interface IPetRepository
    {
        IEnumerable<Pet> GetAllPets();
        IEnumerable<Pet> GetFiveCheapest();
        IEnumerable<Pet> GetPetsPriceSort(bool ascend);
        IEnumerable<Pet> SearchPetsByType(string type);

        Pet CreatePet(Pet pet);
        void DeletePet(Pet pet);
        void SavePet(Pet newPet);

    }


}