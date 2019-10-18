﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using ToDoApi.Models.Entities;

namespace ToDoApi.Models.Map
{
    public class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("dbo.Users");

            HasMany(i => i.Logs).WithRequired(i => i.User).HasForeignKey(i => i.UserID);
            HasMany(i => i.Tasks).WithRequired(i => i.User).HasForeignKey(i => i.UserID);
        }
    }
}