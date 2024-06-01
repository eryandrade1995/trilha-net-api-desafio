using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Context.Interfaces;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Context
{
    public class TarefasContext : BaseContext, ITarefasContext
    {
        private new readonly OrganizadorContext _context;
        public TarefasContext(OrganizadorContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Tarefa> Get(int id) => await _context.Tarefas.FindAsync(id);

        public async Task<IEnumerable<Tarefa>> GetAll() => await _context.Tarefas.ToListAsync();

        public async Task<IEnumerable<Tarefa>> GetByDate(DateTime date) => await _context.Tarefas.Where(x => x.Data.Date == date.Date).ToListAsync();

        public async Task<IEnumerable<Tarefa>> GetByStatus(int status) => await _context.Tarefas.Where(x => ((int)x.Status) == status).ToListAsync();

        public async Task<IEnumerable<Tarefa>> GetByTittle(string tittle) => await _context.Tarefas.Where(x => x.Titulo == tittle).ToListAsync();
    }
}