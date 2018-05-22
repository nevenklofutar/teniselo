using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenisElo.Entities.Model;

namespace TenisElo.Data.Configuration
{
    public class PlayerConfiguration : EntityTypeConfiguration<Player>
    {
        public PlayerConfiguration()
        {
//PlayerId    int Unchecked
//Email nvarchar(250)	Unchecked
//Name    nvarchar(50)    Checked
//LastName    nvarchar(50)    Checked
//Phone   nvarchar(50)    Checked
//Password    nvarchar(50)    Checked
//Elo decimal(6, 2)   Unchecked


            ToTable("Player");

            HasKey(p => p.PlayerId);

            Property(p => p.PlayerId).IsRequired();
            Property(p => p.Email).IsRequired().HasMaxLength(250);
            Property(p => p.FirstName).HasMaxLength(50);
            Property(p => p.LastName).HasMaxLength(50);
            Property(p => p.Phone).HasMaxLength(50);
            Property(p => p.Password).HasMaxLength(50);
            Property(p => p.Elo).IsRequired();



            //Property(c => c.Description)
            //    .IsRequired()
            //    .HasMaxLength(2000);

            //Property(c => c.Name)
            //    .IsRequired()
            //    .HasMaxLength(255);

            //HasRequired(c => c.Author)
            //    .WithMany(a => a.Courses)
            //    .HasForeignKey(c => c.AuthorId)
            //    .WillCascadeOnDelete(false);

            //HasRequired(c => c.Cover)
            //    .WithRequiredPrincipal(c => c.Course);

            //HasMany(c => c.Tags)
            //    .WithMany(t => t.Courses)
            //    .Map(m =>
            //    {
            //        m.ToTable("CourseTags");
            //        m.MapLeftKey("CourseId");
            //        m.MapRightKey("TagId");
            //    });
        }
    }
}
