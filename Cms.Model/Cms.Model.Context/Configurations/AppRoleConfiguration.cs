using Cms.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Model.Context.Configurations
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable("app_roles");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ConcurrencyStamp).HasColumnName("concurrency_stamp");
            builder.Property(x => x.NormalizedName).HasColumnName("normalized_name");
            builder.Property(x => x.Name).HasColumnName("name");
            builder.Property(x => x.Id).HasColumnName("id");
        }
    }
}
