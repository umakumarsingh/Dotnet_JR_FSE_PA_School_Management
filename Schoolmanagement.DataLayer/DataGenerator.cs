using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Schoolmanagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schoolmanagement.DataLayer
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SchoolDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<SchoolDbContext>>()))
            {
                if (context.Notices.Any())
                {
                    return;   // Data was already seeded
                }
                context.Notices.AddRange(
                new Notice
                {
                    Name = "26 January",
                    NoticeDate = new DateTime(2021, 1, 26),
                    classList = ClassList.FIVE,
                    Event = "Republic Day",
                    ChiefGuest = "Donald Trump",
                    Remarks = "Happy republic day! Wishing you India, you have a great future and enjoy your everlasting independence. Today we are free because of the hardships faced by our freedom fighters. Let us salute them."
                },
                new Notice
                {
                    Name = "Basant Panchami",
                    NoticeDate = new DateTime(2021, 2, 16),
                    classList = ClassList.All,
                    Event = "Saraswati pooja",
                    ChiefGuest = "All Parents",
                    Remarks = "Vasant Panchami also spelled Basant Panchami, is a festival that marks the preparation for the arrival of spring. The festival is celebrated by people in various ways depending upon the region in the life in the Indian subcontinent."
                });
                context.SaveChanges();
                if (context.Students.Any())
                {
                    return;   // Data was already seeded
                }
                context.Students.AddRange(
                new Student
                {
                    Name = "Uma Kumar",
                    DOB = new DateTime(1990, 03,01),
                    Phone = 9631438113,
                    FatherName = "Gopal PD Singh",
                    classList = ClassList.TEN,
                    Section = "A"
                },
                new Student
                {
                    Name = "Sonoo Kumar",
                    DOB = new DateTime(1994, 10, 20),
                    Phone = 9631432345,
                    FatherName = "Gopal PD Singh",
                    classList = ClassList.NINE,
                    Section = "B"
                });
                context.SaveChanges();
                if (context.Libraries.Any())
                {
                    return;   // Data was already seeded
                }
                context.Libraries.AddRange(
                new Library
                {
                    BookName = "Deploying And Devloping .Net core",
                    Publication = "Microsoft-Press",
                    Writer = "Tim Cook",
                    Stock = 10
                },
                new Library
                {
                    BookName = "Work with Angular",
                    Publication = "Microsoft-Press",
                    Writer = "Yasvant K",
                    Stock = 6
                },
                new Library
                {
                    BookName = "Microsoft Azure Devlopment",
                    Publication = "Microsoft-Press",
                    Writer = "Marshall Copeland, David Golobde",
                    Stock = 5
                });
                context.SaveChanges();
                if (context.Teachers.Any())
                {
                    return;   // Data was already seeded
                }
                context.Teachers.AddRange(
                new Teacher
                {
                    Name = "Santosh Kumar",
                    Address = "South Block 9/11, New Delhi-09",
                    Email = "santosh@iiht.com",
                    PhoneNumber = 9635244510,
                    Subject = "Hindi, Sience, SST",
                    Experience = 6,
                    Remark = ""
                },
                new Teacher
                {
                    Name = "Yogesh Pandey",
                    Address = "Kamala Nagar 11/3, New Delhi-70",
                    Email = "Yogeshpandey@iiht.com",
                    PhoneNumber = 9635244896,
                    Subject = "Computer, Sience, English",
                    Experience = 7,
                    Remark = "@"
                });
                context.SaveChanges();
            }
        }
    }
}
