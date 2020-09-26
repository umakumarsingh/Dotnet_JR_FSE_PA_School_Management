using Schoolmanagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Schoolmanagement.BusinessLayer.ViewModels
{
    public class StudentViewModel
    {
        public string Name { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }
        public long Phone { get; set; }
        [Display(Name = "Father Name")]
        public string FatherName { get; set; }
        [Display(Name = "Class List")]
        public ClassList? classList { get; set; }
        public string Section { get; set; }

        public IEnumerable<Student> Students { get; set; }
        public int StudentPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount()
        {
            return Convert.ToInt32(Math.Ceiling(Students.Count() / (double)StudentPerPage));
        }
        public IEnumerable<Student> PaginatedStudent()
        {
            int start = (CurrentPage - 1) * StudentPerPage;
            return Students.OrderBy(b => b.StudentId).Skip(start).Take(StudentPerPage);
        }
    }
}
