using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.DAL.ConfigurationEntities;
using Store.DAL.Entities;

namespace Store.DAL.MSSQL.Configurations;
internal sealed class UserConfiguration : UserConfigurationBase
{
    protected override string KeyName => "PK_User";

    protected override void ConfigureDataBase(EntityTypeBuilder<User> builder)
    {
        builder.Property(c => c.ID).HasColumnName("ID");
        builder.Property(c => c.FirstName).HasColumnName("FirstName");
        builder.Property(c => c.SecondName).HasColumnName("SecondName");
        builder.Property(c => c.LastName).HasColumnName("LastName");
    }
}
