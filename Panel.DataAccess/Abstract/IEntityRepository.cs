﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel.DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll();
        void Add(T entity);
        void Delete(T entity);




    }
}
