using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Server.Houses;
using Server.Player;
using Server.PlayerVehicles;

namespace Server
{
    public class MaindbServer : DbContext
    {
        // Connection string, more details below 
        private const string connectionString = "Server=localhost;Database=server;Uid=root;Pwd=";

        // Initialize a new MySQL connection with the given connection parameters 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString);
        }
        public DbSet<AccountModel> accounts { get; set; }
    }
    public class ServerdbServer : DbContext
    {
        // Connection string, more details below 
        private const string connectionString = "Server=localhost;Database=server_01;Uid=root;Pwd=";

        // Initialize a new MySQL connection with the given connection parameters 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString);
        }

        // Account model class created somewhere else 
        //public DbSet<AccountModel> accounts { get; set; }
        public DbSet<PlayerModel> characters { get; set; }
        public DbSet<HouseInfo> houses { get; set; }
        public DbSet<PlayerVehicle> vehicles_p { get; set; }
    }
}