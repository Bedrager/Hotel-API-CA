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
    class CategoryPriceConfiguration:IEntityTypeConfiguration<CategoryPrice>
    {
        public void Configure(EntityTypeBuilder<CategoryPrice> builder)
        {
            builder.HasKey(categoryprice => categoryprice.Id);
            builder.HasIndex(categoryprice => categoryprice.Id).IsUnique();
            builder.Property(categoryprice => categoryprice.StartDate).IsRequired();
            builder.Property(categoryprice => categoryprice.EndDate).IsRequired();
            builder.Property(categoryprice => categoryprice.Price).IsRequired();
            builder.HasOne(categoryprice => categoryprice.Category).WithMany(category => category.CategoryPrices);
        }
    }
}
