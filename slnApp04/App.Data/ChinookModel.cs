﻿using App.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class ChinookModel : DbContext
    {
        public ChinookModel() : base("name=cnxChinookDB")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Artist> Artist { get; set; }

        public virtual DbSet<Customer> Customer { get; set; }

        public virtual DbSet<Album> Album { get; set; }
    }
}
