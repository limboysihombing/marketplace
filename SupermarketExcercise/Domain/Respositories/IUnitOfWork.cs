using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketExcercise.Domain.Respositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
