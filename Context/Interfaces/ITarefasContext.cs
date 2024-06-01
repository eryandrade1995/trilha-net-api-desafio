using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Context.Interfaces
{
    public interface ITarefasContext : IBaseContext
    {
        Task<Tarefa> Get(int id);
        Task<IEnumerable<Tarefa>> GetAll();
        Task<IEnumerable<Tarefa>> GetByTittle(string tittle);
        Task<IEnumerable<Tarefa>> GetByDate(DateTime date);
        Task<IEnumerable<Tarefa>> GetByStatus(int status);
    }
}