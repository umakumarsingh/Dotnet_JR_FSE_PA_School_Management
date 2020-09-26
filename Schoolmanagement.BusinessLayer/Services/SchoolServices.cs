using Schoolmanagement.BusinessLayer.Interfaces;
using Schoolmanagement.BusinessLayer.Services.Repository;
using Schoolmanagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Schoolmanagement.BusinessLayer.Services
{
    public class SchoolServices : ISchoolServices
    {
        private readonly ISchoolRepository _sRepository;

        public SchoolServices(ISchoolRepository schoolRepository)
        {
            _sRepository = schoolRepository;
        }

        public async Task<IEnumerable<Library>> AllBook()
        {
            var book = await _sRepository.AllBook();
            return book;
        }

        public async Task<IEnumerable<Notice>> AllNotice()
        {
            var result = await _sRepository.AllNotice();
            return result;
        }

        public Task<IEnumerable<Student>> AllStudent()
        {
            var result = _sRepository.AllStudent();
            return result;
        }

        public Task<IEnumerable<Teacher>> AllTeacher()
        {
            var result = _sRepository.AllTeacher();
            return result;
        }

        public Task<IEnumerable<Library>> BookList()
        {
            var result = _sRepository.BookList();
            return result;
        }

        public Task<BookBorrow> BorrowBook(int BookId, BookBorrow bookBorrow)
        {
            var result = _sRepository.BorrowBook(BookId, bookBorrow);
            return result;
        }

        public async Task<BookBorrow> BorrowInfo(int BorrowId)
        {
            var bookinfo = await _sRepository.BorrowInfo(BorrowId);
            return bookinfo;
        }

        public async Task<IEnumerable<Notice>> FindNotice(string name)
        {
            var findresult = await _sRepository.FindNotice(name);
            return findresult;
        }

        public async Task<IEnumerable<Student>> FindStudent(string name)
        {
            var findstudent = await _sRepository.FindStudent(name);
            return findstudent;
        }
    }
}
