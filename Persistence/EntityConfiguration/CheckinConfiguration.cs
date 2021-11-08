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
    class CheckinConfiguration:IEntityTypeConfiguration<Checkin>
    {
        public void Configure(EntityTypeBuilder<Checkin> builder)
        {
            builder.HasKey(checkin => checkin.Id);
            builder.HasIndex(checkin => checkin.Id).IsUnique();
            builder.Property(checkin => checkin.Check_in).IsRequired().HasDefaultValue(false);
            builder.Property(checkin => checkin.Check_out).IsRequired().HasDefaultValue(false);
            builder.Property(checkin => checkin.StartDate).IsRequired();
            builder.Property(checkin => checkin.EndDate).IsRequired();
            builder.HasOne(checkin => checkin.Room).WithMany(room => room.Checkins);
            builder.HasOne(checkin => checkin.Guest).WithMany(guest => guest.Checkins);
        }
}
    }
