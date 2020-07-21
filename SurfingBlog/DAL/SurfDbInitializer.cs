using SurfingBlog.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SurfingBlog.DAL
{
    public class SurfDbInitializer : DropCreateDatabaseAlways<SurfDbContext>
    {
        protected override void Seed(SurfDbContext context)
        {
            var user = new User
            {
                Nickname = "vsel",
                Password = "123456",
                LastName = "Старозубов",
                Name = "Всеволод",
                Email = "vsel@star.ru",
                About = "Я такой хороший!"
            };

            var post1 = new Post
            {
                Text = "Первый текстовый пост",
                PublishDate = DateTime.Now,
                Author = user
            };

            var post2 = new Post
            {
                Text = "Второй текстовый пост",
                PublishDate = DateTime.Now,
                Author = user
            };

            context.Users.Add(user);
            context.Posts.Add(post1);
            context.Posts.Add(post2);
            context.SaveChanges();

        }
    }
}