﻿using Abaya_Store.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abaya_Store.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                 new ApplicationUser
                 {
                     Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                     Email = "admin@localhost.com",
                     NormalizedEmail = "ADMIN@LOCALHOST.COM",
                     FirstName = "System",
                     LastName = "Admin",
                     UserName = "admin@localhost.com",
                     NormalizedUserName = "ADMIN@LOCALHOST.COM",
					 PasswordHash = "AQAAAAEAACcQAAAAEEw7rQNH35D/qqLqAA1SJO/FMXvPfuwajcZPP/ynC7bAvbIUkbRzt7WaZvl03MI+Yw==",
					 EmailConfirmed = true,

					 ConcurrencyStamp = "11111111-1111-1111-1111-111111111111",
					 SecurityStamp = "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"
				 },
                 new ApplicationUser
                 {
                     Id = "9e224968-33e4-4652-b7b7-8574d048cdb9",
                     Email = "user@localhost.com",
                     NormalizedEmail = "USER@LOCALHOST.COM",
                     FirstName = "System",
                     LastName = "User",
                     UserName = "user@localhost.com",
                     NormalizedUserName = "USER@LOCALHOST.COM",
					 PasswordHash = "AQAAAAEAACcQAAAAEDcK5SVd5YfrftrBGZ2r8vMQxvCwhuEtRDcARcNZJf6KRrbMCD8T1MZ/Fuor6Gyqdg==",
					 EmailConfirmed = true,

					 ConcurrencyStamp = "22222222-2222-2222-2222-222222222222",
					 SecurityStamp = "bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"
				 }
            );
        }
    }
}
