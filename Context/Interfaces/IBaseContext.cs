using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrilhaApiDesafio.Context.Interfaces
{
    public interface IBaseContext : IDisposable
    {
        Task Save<T>(T model) where T : class;

        Task<bool> Update<T>(T model) where T : class;

        Task<bool> Delete<T>(T model) where T : class;
    }
}