﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace LeaveManagement.Models
{
    public class ConnectionStringClass : DbContext
    {
        public ConnectionStringClass(DbContextOptions<ConnectionStringClass> options) : base(options)
        {

        }
        public DbSet<EmpClass> Employee { get; set; }
    }
}
