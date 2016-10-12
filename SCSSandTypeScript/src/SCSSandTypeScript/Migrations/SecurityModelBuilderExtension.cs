using HD.Station.Data.Security;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station.Data
{
    public static class SecurityModelBuilderExtension
    {
        public static void ConfigureSecurity(this ModelBuilder builder)
        {
            var schema = "Security";

            builder.Entity<User>(b =>
            {
                b.HasIndex(u => u.NormalizedUserName).HasName("UIX_User_NormalizedUserName").IsUnique();
                b.HasIndex(u => u.NormalizedEmail).HasName("IX_User_NormalizedEmail");
                b.ToTable("Users", schema);
                b.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

                b.HasMany(u => u.Claims).WithOne().HasForeignKey(uc => uc.UserId).IsRequired();
                b.HasMany(u => u.Logins).WithOne().HasForeignKey(ul => ul.UserId).IsRequired();
                b.HasMany(u => u.Roles).WithOne().HasForeignKey(ur => ur.UserId).IsRequired();
            });

            builder.Entity<Role>(b =>
            {
                b.HasIndex(r => r.NormalizedName).HasName("UIX_Role_NormalizedName");
                b.ToTable("Roles", schema);
                b.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

                b.Property(u => u.Name).HasMaxLength(256);
                b.Property(u => u.NormalizedName).HasMaxLength(256);

                b.HasMany(r => r.Users).WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();
                b.HasMany(r => r.Claims).WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();
            });

            builder.Entity<IdentityUserClaim<Guid>>(b =>
            {
                b.HasKey(uc => uc.Id);
                b.ToTable("UserClaims", schema);
            });

            builder.Entity<IdentityRoleClaim<Guid>>(b =>
            {
                b.HasKey(rc => rc.Id);
                b.ToTable("RoleClaims", schema);
            });

            builder.Entity<IdentityUserRole<Guid>>(b =>
            {
                b.HasKey(r => new { r.UserId, r.RoleId });
                b.ToTable("UserRoles", schema);
            });

            builder.Entity<IdentityUserLogin<Guid>>(b =>
            {
                b.HasKey(l => new { l.LoginProvider, l.ProviderKey });
                b.ToTable("UserLogins", schema);
            });

            builder.Entity<IdentityUserToken<Guid>>(b =>
            {
                b.HasKey(l => new { l.UserId, l.LoginProvider, l.Name });
                b.ToTable("UserTokens", schema);
            });

            builder.Entity<MenuItem>(b =>
            {
                b.HasKey(m => m.MenuId);
                b.ToTable("Menus", schema);

                b.HasOne(m => m.Action).WithMany().HasForeignKey(m => m.ActionId);
            });

            builder.Entity<Security.Action>(b =>
            {
                b.HasKey(a => a.ActionId);
                b.ToTable("Actions", schema);

                b.HasOne(a => a.Function).WithMany().HasForeignKey(a => a.FunctionId);
            });

            builder.Entity<Function>(b =>
            {
                b.HasKey(f => f.FunctionId);
                b.ToTable("Functions", schema);

                b.HasOne(f => f.Group).WithMany(g => g.Functions).HasForeignKey(f => f.GroupId).IsRequired();
            });

            builder.Entity<FunctionGroup>(b =>
            {
                b.HasKey(g => g.GroupId);
                b.ToTable("FunctionGroups", schema);
            });
        }
    }
}