﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW4.Entities;

namespace Module4HW4.EntityConfigurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client").HasKey(t => t.Id);
            builder.Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(c => c.FirstName).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(c => c.LastName).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(c => c.Email).IsRequired().HasColumnType("nvarchar").HasMaxLength(100);

            ////builder.HasData(new List<Client>()
            ////{
            ////    new Client() { FirstName = "Elon", LastName = "Musk", Email = "boss@tesla.com" },
            ////    new Client() { FirstName = "Mark", LastName = "Zuckerberg", Email = "boss@facebook.com" },
            ////    new Client() { FirstName = "Linus", LastName = "Torvalds", Email = "boss@linux.com" },
            ////    new Client() { FirstName = "Bill", LastName = "Gates", Email = "boss@microsoft.com" },
            ////    new Client() { FirstName = "Jeffrey", LastName = "Bezos", Email = "boss@amazon.com" }
            ////});
        }
    }
}
