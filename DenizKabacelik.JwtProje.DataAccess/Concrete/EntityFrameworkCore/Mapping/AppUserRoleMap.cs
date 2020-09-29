﻿using DenizKabacelik.JwtProje.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKabacelik.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class AppUserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(I=>I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.HasIndex(I => new { I.AppUserId, I.AppRoleId }).IsUnique();

        }
    }
}
