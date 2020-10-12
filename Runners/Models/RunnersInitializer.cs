using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Runners.Models
{
    public class RunnersInitializer : DropCreateDatabaseIfModelChanges<RunnersContext>
    {
        protected override void Seed(RunnersContext context)
        {
            List<Users> users = new List<Users>()
            {
                new Users() {Username="User1", Age=24 , Gender=false},
                new Users() {Username="Ahmet", Age=21 , Gender=false},
                new Users() {Username="Yunus", Age=28 , Gender=false},
                new Users() {Username="John", Age=34 , Gender=false},
                new Users() {Username="Adam", Age=31 , Gender=false},
                new Users() {Username="Brian", Age=41 , Gender=false},
                new Users() {Username="Tyler", Age=26 , Gender=false},
                new Users() {Username="Ceren", Age=35 , Gender=true},
                new Users() {Username="Hasan", Age=43 , Gender=false},
                new Users() {Username="Selen", Age=29 , Gender=true},
                new Users() {Username="Diana", Age=45 , Gender=true},
                new Users() {Username="Thomas", Age=44 , Gender=false},
                new Users() {Username="James", Age=39 , Gender=false},
                new Users() {Username="Janet", Age=36 , Gender=true},
            };

            foreach (var item in users)
            {
                context.Users.Add(item);
            }
            context.SaveChanges();

            List<Pace> pace = new List<Pace>()
            {
                new Pace() {Total_Time=25 , UserId = 1 , Distance = 5000},
                new Pace() {Total_Time=24 , UserId = 2 , Distance = 4800},
                new Pace() {Total_Time=28 , UserId = 3 , Distance = 6000},
                new Pace() {Total_Time=40 , UserId = 4 , Distance = 10000},
                new Pace() {Total_Time=12 , UserId = 5 , Distance = 2000},
                new Pace() {Total_Time=42 , UserId = 6 , Distance = 10000},
                new Pace() {Total_Time=20 , UserId = 7 , Distance = 5000},
                new Pace() {Total_Time=21 , UserId = 8 , Distance = 5000},
                new Pace() {Total_Time=30 , UserId = 9 , Distance = 5000},
                new Pace() {Total_Time=22 , UserId = 10 , Distance = 5000},
                new Pace() {Total_Time=30 , UserId = 11 , Distance = 6000},
                new Pace() {Total_Time=28 , UserId = 12 , Distance = 4500},
                new Pace() {Total_Time=18 , UserId = 13 , Distance = 5000},
                new Pace() {Total_Time=60 , UserId = 14 , Distance = 10000},
            };
            foreach (var item in pace)
            {
                context.Pace.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}