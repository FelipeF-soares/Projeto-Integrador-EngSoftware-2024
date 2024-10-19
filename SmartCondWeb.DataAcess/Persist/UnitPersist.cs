﻿using Microsoft.EntityFrameworkCore;
using SmartCondWeb.DataAcess.ContextPersist;
using SmartCondWeb.DataAcess.Persist.Interfaces;
using SmartCondWeb.Domain.Things;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCondWeb.DataAcess.Persist;

public class UnitPersist : IUnitPersist
{
    private readonly SmartCondContext context;

    public UnitPersist(SmartCondContext context)
    {
        this.context = context;
    }
    public void Add(Unit entity)
    {
       context.Add(entity);
    }

    public void Update(Unit entity)
    {
        context.Update(entity);
    }

    public void Delete(Unit entity)
    {
        context.Remove(entity);
    }

    public List<Unit> GetAllUnits()
    {
        List<Unit> units = context.Units.Include(owner => owner.Homeowner)
                                        .Include(resident => resident.Residents)
                                        .AsNoTracking()
                                        .ToList();
        return units;
    }

    public Unit GetUnitForId(int id)
    {
        Unit unit = context.Units.Include(owner => owner.Homeowner)
                                 .Include(resident => resident.Residents)
                                 .AsNoTracking()
                                 .FirstOrDefault(unit => unit.Id == id);
        return unit;                        
    }

    public bool SaveChange()
    {
        return (context.SaveChanges()) > 0;
    }
}
