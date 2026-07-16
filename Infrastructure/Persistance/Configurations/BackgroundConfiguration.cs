using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations
{
    public class BackgroundConfiguration : IEntityTypeConfiguration<Background>
    {
        public void Configure(EntityTypeBuilder<Background> builder)
        {
            throw new NotImplementedException();
        }
    }
}
