﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GestorChamados.Models
{
    public class GestorChamadosContext : DbContext
    {
        public GestorChamadosContext (DbContextOptions<GestorChamadosContext> options)
            : base(options)
        {
        }

        public DbSet<GestorChamados.Models.Department> Department { get; set; }
    }
}
