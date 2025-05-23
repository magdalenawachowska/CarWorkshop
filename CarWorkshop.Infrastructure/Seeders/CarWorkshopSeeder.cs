﻿using CarWorkshop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infrastructure.Seeders
{
    public class CarWorkshopSeeder
    {
        private readonly CarWorkshopDbContext _dbContext;
        public CarWorkshopSeeder(CarWorkshopDbContext context)
        {
            _dbContext = context;

        }
        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.CarWorkshops.Any())  //! - jesli nie znajduja sie zadne dane
                {
                    var mazdaAso = new Domain.Entities.CarWorkshop()
                    {
                        Name = "Mazda ASO",
                        Description = "Autoryzowany serwis Mazda",
                        ContactDetails = new()
                        {
                            City = "Krakow",
                            Street = "Szewska 2",
                            PostalCode = "30-001",
                            PhoneNumber = "+48699222888"
                        }
                    };
                    mazdaAso.EncodeName();
                    _dbContext.CarWorkshops.Add(mazdaAso);
                    await _dbContext.SaveChangesAsync(); 
                }
            }
        }
    }
}
