using Schoolmanagement.BusinessLayer.Interfaces;
using Schoolmanagement.BusinessLayer.Services.Repository;
using Schoolmanagement.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Schoolmanagement.BusinessLayer.Services
{
    public class SchoolServices : ISchoolServices
    {
        /// <summary>
        /// Creating referance variable of ISchoolRepository and injecting in SchoolServices controller
        /// </summary>
        private readonly ISchoolRepository _sRepository;
        public SchoolServices(ISchoolRepository schoolRepository)
        {
            _sRepository = schoolRepository;
        }
        /// <summary>
        /// Get all book from database
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Library>> AllBook()
        {
            var book = await _sRepository.AllBook();
            return book;
        }
        /// <summary>
        /// Get all notice from databse and show on main page
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Notice>> AllNotice()
        {
            var result = await _sRepository.AllNotice();
            return result;
        }
        /// <summary>
        /// get all student from database
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Student>> AllStudent()
        {
            var result = _sRepository.AllStudent();
            return result;
        }
        /// <summary>
        /// Get all teacher from databse
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Teacher>> AllTeacher()
        {
            var result = _sRepository.AllTeacher();
            return result;
        }
        /// <summary>
        /// Get all book list from databse
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Library>> BookList()
        {
            var result = _sRepository.BookList();
            return result;
        }
        /// <summary>
        /// Borrow a book
        /// </summary>
        /// <param name="BookId"></param>
        /// <param name="bookBorrow"></param>
        /// <returns></returns>
        public Task<BookBorrow> BorrowBook(int BookId, BookBorrow bookBorrow)
        {
            var result = _sRepository.BorrowBook(BookId, bookBorrow);
            return result;
        }
        /// <summary>
        /// Get borrow book info and use while returining book
        /// </summary>
        /// <param name="BorrowId"></param>
        /// <returns></returns>
        public async Task<BookBorrow> BorrowInfo(int BorrowId)
        {
            var bookinfo = await _sRepository.BorrowInfo(BorrowId);
            return bookinfo;
        }
        /// <summary>
        /// Find a book from Db by its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Notice>> FindNotice(string name)
        {
            var findresult = await _sRepository.FindNotice(name);
            return findresult;
        }
        /// <summary>
        /// Find an existing student from db
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Student>> FindStudent(string name)
        {
            var findstudent = await _sRepository.FindStudent(name);
            return findstudent;
        }
    }
}
