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
        /// <summary>
        /// Creating Referance variable of DbContext and Injecting in Constructor
        /// </summary>
        private readonly SchoolDbContext _schoolDbContext;

        public SchoolRepository(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }
        /// <summary>
        /// Get all book from InMemory Db
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Library>> AllBook()
        {
            var book = await _schoolDbContext.Libraries.OrderByDescending(x => x.BookName).ToListAsync();
            return book;
        }
        /// <summary>
        /// Get all Notice from InMemory Db
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Notice>> AllNotice()
        {
            var notice = await _schoolDbContext.Notices.OrderByDescending(x => x.NoticeDate).ToListAsync();
            return notice;
        }
        /// <summary>
        /// Get all Student from InMemory Db
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Student>> AllStudent()
        {
            var student = await _schoolDbContext.Students.OrderByDescending(x => x.Name).ToListAsync();
            return student;
        }
        /// <summary>
        /// Get all Teachers from InMemory Db
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Teacher>> AllTeacher()
        {
            var teacher = await _schoolDbContext.Teachers.OrderByDescending(x => x.Name).ToListAsync();
            return teacher;
        }
        /// <summary>
        /// Get all book from InMemory Db
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Library>> BookList()
        {
            var book = await _schoolDbContext.Libraries.OrderByDescending(x => x.BookId).ToListAsync();
            return book;
        }
        /// <summary>
        /// Borrow a book from libray, this methos place a borrow request
        /// </summary>
        /// <param name="BookId"></param>
        /// <param name="bookBorrow"></param>
        /// <returns></returns>
        public async Task<BookBorrow> BorrowBook(int BookId, BookBorrow bookBorrow)
        {
            if (bookBorrow.BookId == BookId)
            {
                _schoolDbContext.BookBorrows.Add(bookBorrow);
                await _schoolDbContext.SaveChangesAsync();
            }
            return bookBorrow;
        }
        /// <summary>
        /// Get Borrow Book and Book Id information
        /// </summary>
        /// <param name="BorrowId"></param>
        /// <returns></returns>
        public async Task<BookBorrow> BorrowInfo(int BorrowId)
        {
            var result = await _schoolDbContext.BookBorrows
                                 .Where(x => x.BorrowId == BorrowId)
                                 .FirstOrDefaultAsync();
            return result;
        }
        /// <summary>
        /// Find a notice by its name and event
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Notice>> FindNotice(string name)
        {
            var result = await _schoolDbContext.Notices.
                Where(x => x.Name == name || x.Event == name).Take(10).ToListAsync();
            return result;
        }
        /// <summary>
        /// Find a sytudent by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Student>> FindStudent(string name)
        {
            var result = await _schoolDbContext.Students.
                Where(x => x.Name == name).Take(10).ToListAsync();
            return result;
        }
    }
}
