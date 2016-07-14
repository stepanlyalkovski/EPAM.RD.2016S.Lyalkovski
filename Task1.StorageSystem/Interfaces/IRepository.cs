﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Task1.StorageSystem.Interfaces
{
    public interface IRepository<TEntity>
    {
        //TEntity GetById(int id);
        TEntity SearhByPredicate(Func<TEntity, bool> predicate);
        void Add(TEntity user);
        void SaveToXmlFile();
        void Delete(TEntity entity);
    }
}