using MyTemplate.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTemplate.DAL
{
    public class TestData
    {
        public static void Initialize(MyTemplateDbContext context)
        {
            context.Database.EnsureCreated();
            //if (context.Users.Any())
            //{
            //    return;   // DB has been seeded
            //}
            var Users = new User[]
            {
                new User{Name="Jack",Password="test",PhoneNumber="0925333626",EmailAddress="wl02638153@gmail.com"}
            };
            foreach (User s in Users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();

            //if (context.Products.Any())
            //{
            //    return;   // DB has been seeded
            //}
            var Products = new Product[30];
            var j = 1;
            for (var i = 0; i < 30; i++)
            {
                Products[i] = new Product { Name="testData"+i,Category= "Category"+j };
                if (i>1&& i%10 == 0)
                    j++;
            }
            foreach (Product s in Products)
            {
                context.Products.Add(s);
            }
            context.SaveChanges();
        }
    }
}
