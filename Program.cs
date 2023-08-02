using System;
using Blog.Data;
using Blog.Models;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new BlogDataContext())
            {
                // CREATE
                // var tag = new Tag { Name = ".NET", Slug = "dotnet" };
                // context.Tags.Add(tag);
                // context.SaveChanges();

                // var tag2 = new Tag { Name = "ASP.NET", Slug = "asp-net" };
                // context.Tags.Add(tag2);
                // context.SaveChanges();

                // UPDATE
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                // tag.Name = ".NET";
                // tag.Slug = "dotnet";

                // context.Update(tag);
                // context.SaveChanges();

                //DELETE
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                // context.Tags.Remove(tag);
                // context.SaveChanges();

                //READ
                var tags = context.Tags.ToList();

                foreach(var tag in tags)
                {
                    Console.WriteLine(tag.Name);
                }

            }
        }
    }
}
