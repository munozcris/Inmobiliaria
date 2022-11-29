﻿using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Interfaces
{
    public interface ICliente
    {
        Task<List<ClienteData>> GetAllClientes();
    }
}
