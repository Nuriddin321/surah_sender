using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SurahSender.Entities;

public class QuranConfiguration : IEntityTypeConfiguration<Quran>
{
    public void Configure(EntityTypeBuilder<Quran> builder)
    {
        builder.HasIndex(q => q.IdOfMessage).IsUnique();
        builder.Property(q => q.Name);
        builder.Property(q => q.Size);
    }
}