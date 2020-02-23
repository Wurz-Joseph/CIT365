using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;
using System;
using System.Linq;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(serviceProvider.GetRequiredService<
                DbContextOptions<MyScriptureJournalContext>>()))
            {
                if (context.Scripture.Any())
                {
                    return;
                }
                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "Matthew",
                        Chapter = 28,
                        Verse = 6,
                        Note = "He is risen.",
                        DateCreated = DateTime.Parse("2019-04-21")
                    },
                     new Scripture
                     {
                         Book = "1 Nephi",
                         Chapter = 10,
                         Verse = 4,
                         Note = "Prophecy that Christ would come as Savior of the world.",
                         DateCreated = DateTime.Parse("2019-12-25")
                     },
                      new Scripture
                      {
                          Book = "1 Corinthians",
                          Chapter = 10,
                          Verse = 13,
                          Note = "God will not try/tempt you above what you can bear.",
                          DateCreated = DateTime.Parse("2020-01-30")
                      },
                       new Scripture
                       {
                           Book = "D&C",
                           Chapter = 121,
                           Verse = 7,
                           Note = "We can find peace in knowing that adversity is temporary.",
                           DateCreated = DateTime.Parse("2019-09-12")
                       }
                    );
                context.SaveChanges();
            }

        }
    }
}
