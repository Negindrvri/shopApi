using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shopApi.Entities;

namespace shopApi.Data.Efconfiguration
{
    public class UserRoleEntityConfiguration
    : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRoles");

            //ToDo : add in future

        }
    }
}