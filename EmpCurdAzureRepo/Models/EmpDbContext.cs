﻿using Microsoft.EntityFrameworkCore;

namespace EmpCurdAzureRepo.Models
{
    public class EmpDbContext:DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
