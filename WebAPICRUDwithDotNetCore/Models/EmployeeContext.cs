﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICRUDwithDotNetCore.Models
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {

        }
        public DbSet<TblEmployee> TblEmployee { get; set; }
        public DbSet<TblDesignation> TblDesignation { get; set; }
    }
}
