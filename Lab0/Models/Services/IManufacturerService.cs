using Lab0.Data.Entities;
using System.Collections.Generic;

namespace Lab0.Models.Services;

public interface IManufacturerService
{
    void Add(ManufacturerEntity manufacturer);
    List<ManufacturerEntity> GetAll();
}