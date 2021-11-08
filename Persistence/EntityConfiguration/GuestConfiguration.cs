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
    class GuestConfiguration:IEntityTypeConfiguration<Guest>
    {
        public void Configure(EntityTypeBuilder<Guest> builder)
        {
            builder.HasKey(guest => guest.Id);
            builder.HasIndex(guest => guest.Id).IsUnique();
            builder.Property(guest => guest.Lastname).IsRequired().HasMaxLength(60);
            builder.Property(guest => guest.Firstname).IsRequired().HasMaxLength(60);
            builder.Property(guest => guest.Patronymic).IsRequired().HasMaxLength(60);
            builder.Property(guest => guest.Birth).IsRequired();
            builder.Property(guest => guest.Mobile).IsRequired().HasMaxLength(10);
            builder.Property(guest => guest.Passport).IsRequired();
            builder.HasMany(guest => guest.Checkins).WithOne(checkin => checkin.Guest);

        }
    }
}
