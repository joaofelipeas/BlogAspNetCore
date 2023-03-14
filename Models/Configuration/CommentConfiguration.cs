using Blog.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Models.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Content");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Title).HasColumnName("Title");
            builder.Property(p => p.Description).HasColumnName("Description");
            builder.Property(p => p.DtCreate).HasColumnName("DtCreate").HasDefaultValueSql("getdate()");
            builder.Property(p => p.Author).HasColumnName("Author");
            builder.Property(p => p.Image).HasColumnName("Image");
        }
    }
}