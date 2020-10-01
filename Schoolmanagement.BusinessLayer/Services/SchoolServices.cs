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
        /// <summary>
        /// Creating referance variable of ISchoolRepository and injecting in SchoolServices constructor
        /// </summary>
        private readonly ISchoolRepository _sRepository;

        public SchoolServices(ISchoolRepository schoolRepository)
        {
            _sRepository = schoolRepository;
        }
        /// <summary>
        /// Get All book
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Library>> AllBook()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// get all notice
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Notice>> AllNotice()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// get all student
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Student>> AllStudent()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all teachers
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Teacher>> AllTeacher()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get list of all book
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Library>> BookList()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Place a request fro borrow book from library
        /// </summary>
        /// <param name="BookId"></param>
        /// <param name="bookBorrow"></param>
        /// <returns></returns>
        public Task<BookBorrow> BorrowBook(int BookId, BookBorrow bookBorrow)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Show book borrow information for user
        /// </summary>
        /// <param name="BorrowId"></param>
        /// <returns></returns>
        public async Task<BookBorrow> BorrowInfo(int BorrowId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Find a existing notice by its type and name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Notice>> FindNotice(string name)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Find student by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Student>> FindStudent(string name)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
