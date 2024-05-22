using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrilhaApiDesafio.Context.Interfaces;

namespace TrilhaApiDesafio.Context
{
    public class BaseContext : IBaseContext
    {
        protected readonly OrganizadorContext _context;

        public BaseContext(OrganizadorContext context)
        {
            _context = context;
        }
        public async Task Save<T>(T model) where T : class
        {
            await _context.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Update<T>(T model) where T : class
        {
            _context.Update(model);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete<T>(T model) where T : class
        {
            _context.Remove(model);

            try
            {
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                await _context.DisposeAsync();
                return false;
            }
            return true;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}