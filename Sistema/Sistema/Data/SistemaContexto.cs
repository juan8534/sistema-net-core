﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sistema.Models
{
    public class SistemaContexto : DbContext
    {
        public SistemaContexto (DbContextOptions<SistemaContexto> options)
            : base(options)
        {
        }

        public DbSet<Sistema.Models.Categoria> Categoria { get; set; }
    }
}
