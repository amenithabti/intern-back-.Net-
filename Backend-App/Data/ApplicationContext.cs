﻿using Backend_App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Backend_App.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options) { }
        public DbSet<User> users { get; set; }

        public DbSet<Formateur> formateurs { get; set; }
    }
}
