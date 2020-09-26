using Microsoft.EntityFrameworkCore;
using Schoolmanagement.DataLayer;
using Schoolmanagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolmanagement.BusinessLayer.Services.Repository
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly SchoolDbContext _schoolDbContext;

        public SchoolRepository(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public async Task<IEnumerable<Library>> AllBook()
        {
            var book = await _schoolDbContext.Libraries.OrderByDescending(x => x.BookName).ToListAsync();
            return book;
        }

        public async Task<IEnumerable<Notice>> AllNotice()
        {
            var notice = await _schoolDbContext.Notices.OrderByDescending(x => x.NoticeDate).ToListAsync();
            return notice;
        }

        public async Task<IEnumerable<Student>> AllStudent()
        {
            var student = await _schoolDbContext.Students.OrderByDescending(x => x.Name).ToListAsync();
            return student;
        }

        public async Task<IEnumerable<Teacher>> AllTeacher()
        {
            var teacher = await _schoolDbContext.Teachers.OrderByDescending(x => x.Name).ToListAsync();
            return teacher;
        }

        public async Task<IEnumerable<Library>> BookList()
        {
            var book = await _schoolDbContext.Libraries.OrderByDescending(x => x.BookId).ToListAsync();
            return book;
        }

        public async Task<BookBorrow> BorrowBook(int BookId, BookBorrow bookBorrow)
        {
            if (bookBorrow.BookId == BookId)
            {
                _schoolDbContext.BookBorrows.Add(bookBorrow);
                await _schoolDbContext.SaveChangesAsync();
            }
            return bookBorrow;
        }

        public async Task<BookBorrow> BorrowInfo(int BorrowId)
        {
            var result = await _schoolDbContext.BookBorrows
                                 .Where(x => x.BorrowId == BorrowId)
                                 .FirstOrDefaultAsync();
            return result;
        }

        public async Task<IEnumerable<Notice>> FindNotice(string name)
        {
            var result = await _schoolDbContext.Notices.
                Where(x => x.Name == name || x.Event == name).Take(10).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<Student>> FindStudent(string name)
        {
            var result = await _schoolDbContext.Students.
                Where(x => x.Name == name).Take(10).ToListAsync();
            return result;
        }
    }
}
