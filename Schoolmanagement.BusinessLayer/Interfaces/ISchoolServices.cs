using Schoolmanagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Schoolmanagement.BusinessLayer.Interfaces
{
    public interface ISchoolServices
    {
        Task<IEnumerable<Notice>> AllNotice();
        Task<IEnumerable<Notice>> FindNotice(string name);
        Task<IEnumerable<Student>> AllStudent();
        Task<IEnumerable<Student>> FindStudent(string name);
        Task<IEnumerable<Library>> BookList();
        Task<IEnumerable<Teacher>> AllTeacher();
        Task<IEnumerable<Library>> AllBook();
        Task<BookBorrow> BorrowBook(int BookId, BookBorrow bookBorrow);
        Task<BookBorrow> BorrowInfo(int BorrowId);
    }
}
