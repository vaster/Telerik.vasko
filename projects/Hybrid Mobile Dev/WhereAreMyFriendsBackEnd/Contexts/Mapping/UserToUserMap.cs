using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Contexts.Mapping
{
    public class UserToUserMap : EntityTypeConfiguration<UserToUser>
    {
        public UserToUserMap()
        {
            this.HasKey(t => new { t.UserId, t.FriendId });

            this.Property(t => t.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FriendId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.ToTable("UserToUser");

            this.Property(t=>t.UserId).HasColumnName("UserId");
            this.Property(t=>t.FriendId).HasColumnName("FriendId");

           //this.HasRequired(t => t.User)
           //    .WithMany(t=>t.UserToUser)
           //    .HasForeignKey(d=>d.UserId);
           //
           //this.HasRequired(t => t.Friend)
           //    .WithMany(t => t.UserToUser)
           //    .HasForeignKey(d => d.FriendId);
        } 
    }
}
