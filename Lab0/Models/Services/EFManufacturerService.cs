using Lab0.Data;
using Lab0.Data.Entities;
using Lab0.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Lab0.Models.Services
{
    public class EFManufacturerService : IManufacturerService
    {
        private readonly AppDbContext _context;

        public EFManufacturerService(AppDbContext context)
        {
            _context = context;
        }
        
        public void Add(ManufacturerModel model)
        {
            var entity = new ManufacturerEntity
            {
                Name = model.Name
            };

            _context.Manufacturers.Add(entity);
            _context.SaveChanges();

            model.Id = entity.Id; 
        }

        public List<ManufacturerModel> GetAll()
        {
            return _context.Manufacturers
                .AsNoTracking()
                .Select(m => new ManufacturerModel
                {
                    Id = m.Id,
                    Name = m.Name
                })
                .ToList();
        }

    }
}