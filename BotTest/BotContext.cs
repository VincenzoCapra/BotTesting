﻿using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TextCommandFramework;

public class BotContext : DbContext
{
    public DbSet<Profile> Profile { get; set; }
    public DbSet<UserList> List { get; set; }

    public BotContext(DbContextOptions<BotContext> options) : base(options)
    {
    }
}

public class UserList
{
    public string UserListId { get; set; }
    public List<Profile> Profiles { get; set; }
}

public class Profile
{
    public string ProfileId { get; set; }
    public string Name { get; set; }
    public ulong DiscordId { get; set; }
    public int Money { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public int InventorySpace { get; set; }
}