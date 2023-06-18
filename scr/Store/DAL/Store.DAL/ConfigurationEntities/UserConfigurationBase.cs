using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.DAL.Entities;

namespace Store.DAL.ConfigurationEntities;
public abstract class UserConfigurationBase : IEntityTypeConfiguration<User>
{
    protected abstract string KeyName { get; }
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(c=> c.ID).HasName(KeyName);

        builder.Property(c=> c.ID).ValueGeneratedOnAdd();
        builder.Property(c=> c.FirstName).HasMaxLength(100).IsRequired();
        builder.Property(c=> c.SecondName).HasMaxLength(100).IsRequired();
        builder.Property(c=> c.LastName).HasMaxLength(100);

        ConfigureDataBase(builder);
    }

    protected abstract void ConfigureDataBase(EntityTypeBuilder<User> builder);
}
