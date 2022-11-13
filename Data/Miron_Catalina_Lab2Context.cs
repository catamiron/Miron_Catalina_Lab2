﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Miron_Catalina_Lab2.Models;

namespace Miron_Catalina_Lab2.Data
{
    public class Miron_Catalina_Lab2Context : DbContext
    {
        public Miron_Catalina_Lab2Context (DbContextOptions<Miron_Catalina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Miron_Catalina_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Miron_Catalina_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
