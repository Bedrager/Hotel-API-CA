using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfiguration
{
    class CategoryConfiguration:IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(category => category.Id);
            builder.HasIndex(category => category.Id).IsUnique();
            builder.Property(category => category.Name).IsRequired();
            builder.Property(category => category.Beds).IsRequired();
            builder.HasMany(category => category.Rooms).WithOne(room => room.Category).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(category => category.CategoryPrices).WithOne(categoryprice => categoryprice.Category)
                .OnDelete(DeleteBehavior.SetNull);
            
        }
    }
}
