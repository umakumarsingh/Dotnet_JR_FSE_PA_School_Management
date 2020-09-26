using Schoolmanagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Schoolmanagement.BusinessLayer.ViewModels
{
    public class NoticeViewModel
    {
        public string Name { get; set; }
        [Display(Name = "Notice Date")]
        public DateTime NoticeDate { get; set; }
        [Display(Name = "Notice For")]
        public ClassList classList { get; set; }
        public string Event { get; set; }
        [Display(Name = "Chief Guest")]
        public string ChiefGuest { get; set; }
        public string Remarks { get; set; }

        public IEnumerable<Notice> Notices { get; set; }
        public int NoticePerPage { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount()
        {
            return Convert.ToInt32(Math.Ceiling(Notices.Count() / (double)NoticePerPage));
        }
        public IEnumerable<Notice> PaginatedNotice()
        {
            int start = (CurrentPage - 1) * NoticePerPage;
            return Notices.OrderBy(b => b.NoticeId).Skip(start).Take(NoticePerPage);
        }
    }
}
