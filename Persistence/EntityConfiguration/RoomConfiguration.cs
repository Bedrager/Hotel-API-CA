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
    class RoomConfiguration:IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(room  => room.Id);
            builder.HasIndex(room => room.Id).IsUnique();
            builder.Property(room => room.Number).IsRequired();
            builder.HasOne(room => room.Category).WithMany(category => category.Rooms).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(room => room.Checkins).WithOne(checkin => checkin.Room).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
