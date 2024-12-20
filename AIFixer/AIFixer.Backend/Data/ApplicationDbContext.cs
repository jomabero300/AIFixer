﻿using AIFixer.Shared.Entites;
using Microsoft.EntityFrameworkCore;

namespace AIFixer.Backend.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Country> Countries { get; set; }
    public DbSet<ComponentType> ComponentTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
        modelBuilder.Entity<ComponentType>().HasIndex(x => x.Name).IsUnique();
    }
}