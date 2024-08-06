﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using QLSVVV.Models;

namespace QLSVVV.Data
{
    public interface IQLSVVVContext : IStudentContext, ITeacherContext, ICourseContext
    {
       
       
        EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class;
        EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class;
        EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class;
       

    }
}