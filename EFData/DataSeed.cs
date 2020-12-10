using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFData
{
    public class DataSeed
    {
        public static async Task SeedDataAsync(DataContext context, UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var users = new List<AppUser>
                {
                    new AppUser
                    {
                        DisplayName = "TestUserFirst",
                        UserName = "TestUserFirst",
                        Email = "testuserfirst@test.com"
                    },
                    new AppUser
                    {
                        DisplayName = "TestUserSecond",
                        UserName = "TestUserSecond",
                        Email = "testusersecond@test.com"
                    },
                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "2wsx@WSX");
                } 
            }
           
            if (!EnumerableExtensions.Any(context.HelpdeskOrders))
            {
                var helpdeskOrders = new List<HelpdeskOrder>
                {
                    new HelpdeskOrder
                    {
                        Number = "abc",
                        Title = "abc",
                        Description = "abc"
                    },
                    new HelpdeskOrder
                    {
                        Number = "abc2",
                        Title = "abc2",
                        Description = "abc2"
                    },
                    new HelpdeskOrder
                    {
                        Number = "abc3",
                        Title = "abc3",
                        Description = "abc3"
                    }
                };

                context.HelpdeskOrders.AddRange(helpdeskOrders);
                context.SaveChanges();
            }

        }

    }
}
