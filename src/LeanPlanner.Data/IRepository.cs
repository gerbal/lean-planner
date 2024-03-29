﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace LeanPlanner.Data
{
    public interface IRepository
    {
        void Commit();
        void Rollback();

        void Save<T>(T item);

        IQueryable<T> All<T>();

        void Delete<T>(T item);
        void Delete<T>(Expression<Func<T, bool>> expression);
    }
}
