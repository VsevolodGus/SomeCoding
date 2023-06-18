using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.DAL.ConfigurationEntities;
using Store.DAL.Entities;

namespace Store.DAL.PGSQL.Configurations;
internal sealed class UserConfiguration : UserConfigurationBase
{
    protected override string KeyName => "pk_user";

    protected override void ConfigureDataBase(EntityTypeBuilder<User> builder)
    {
        builder.Property(c=> c.ID).HasColumnName("id");
        builder.Property(c => c.FirstName).HasColumnName("first_name");
        builder.Property(c => c.SecondName).HasColumnName("second_name");
        builder.Property(c => c.LastName).HasColumnName("last_name");
    }
}
