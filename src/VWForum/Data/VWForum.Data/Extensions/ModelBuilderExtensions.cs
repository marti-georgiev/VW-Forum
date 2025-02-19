using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using VWForum.Data.Models;

namespace VWForum.Data.Extensions
{
    internal static class ModelBuilderExtensions
    {
        public static void ConfigureMetadataEntity<TEntity>(this ModelBuilder builder) where TEntity : MetadataBaseEntity
        {
            builder.Entity<TEntity>()
               .HasOne(u => u.CreatedBy)
               .WithMany()
               .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TEntity>()
                .HasOne(u => u.UpdatedBy)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TEntity>()
                .HasOne(u => u.DeletedBy)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
