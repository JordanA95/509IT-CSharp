﻿using HarrisContactManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactManager.Data
{
    public class HarrisDbContext : DbContext
    {
        public HarrisDbContext(DbContextOptions<HarrisDbContext> options) : base(options)
        {
        }

        public DbSet<PersonalContact> PersonalContacts { get; set; }
        public DbSet<BusinessContact> BusinessContacts { get; set; }

        protected override void 
    }
}
