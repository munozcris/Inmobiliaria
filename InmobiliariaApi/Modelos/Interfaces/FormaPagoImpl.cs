using Microsoft.EntityFrameworkCore;
using Modelos.DataAccess.Context;
using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Interfaces
{
    public class FormaPagoImpl : IFormaPago
    {
        public readonly ApplicationDbContext _context;

        public FormaPagoImpl(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<FormaPagoData>> GetAllFormaPago()
        {
            return await _context.Pagos.ToListAsync();
        }

    }
}
