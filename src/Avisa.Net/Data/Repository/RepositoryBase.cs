using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Avisa.Net.Data.Repository
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        
    }
}