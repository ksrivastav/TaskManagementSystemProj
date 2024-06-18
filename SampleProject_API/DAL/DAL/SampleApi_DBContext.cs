using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleAPI_Core.Entities;

namespace DAL
{
    public class SampleApi_DBContext: DbContext
    {
        public SampleApi_DBContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<City> City { get; set; }
        public DbSet<Weather> Weather { get; set; }

        public DbSet<Board> Board { get; set; }
        public DbSet<SampleAPI_Core.Entities.Tasks> Task { get; set; }

        public DbSet<User> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            City city = new City();
            city.CityCode = "DEL";
            city.Name = "New Delhi";
            city.State = "New Delhi";
            city.Country = "India";

            modelBuilder.Entity<Weather>().HasData(
                 new Weather
                 {
                     City = city,
                     Temprature = 35,
                     TempratureUnit = "Degree",
                     DateTime = DateTime.Now

                 }
                ) ;

            User user = new User();
            user.UserName = "TestUser";
            user.UserEmail = "TestUser@gmail.com";
            user.UserPassword= "Password";

            modelBuilder.Entity<User>().HasData(user);

            Board board = new Board();
            board.BoardStatus = "New";
            board.Description = "Sprint 1 Board";
            board.Title = "Sprint 1 Board";
            board.DeadLine = System.DateTime.Now;

            //SampleAPI_Core.Entities.Task task = new SampleAPI_Core.Entities.Task();
            //task.Name = "New Task";
            //task.Description = "Task for new user creation";
            //task.DeadLine = System.DateTime.Now;
            //task.CreatedByUser = user;
            //task.Board = board;

        }
    }
}