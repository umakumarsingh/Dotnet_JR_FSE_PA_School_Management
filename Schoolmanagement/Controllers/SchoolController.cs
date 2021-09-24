using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Schoolmanagement.BusinessLayer.Interfaces;
using Schoolmanagement.BusinessLayer.ViewModels;
using Schoolmanagement.Entities;

namespace Schoolmanagement.Controllers
{
    public class SchoolController : Controller
    {
        /// <summary>
        /// Creating referance variable of ISchoolServices and injecting in SchoolController constructor
        /// </summary>
        private readonly ISchoolServices _schoolServices;
        public SchoolController(ISchoolServices schoolServices)
        {
            _schoolServices = schoolServices;
        }
        /// <summary>
        /// Get all School Notice and using this method find notice ny Notice name and Event type
        /// </summary>
        /// <param name="search"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AllNotice(string search, int page = 1)
        {
            if (search != null)
            {
                var intView = new NoticeViewModel
                {
                    NoticePerPage = 5,
                    Notices = await _schoolServices.FindNotice(search),
                    CurrentPage = page
                };
                return View(intView);
            }
            else
            {
                var intView = new NoticeViewModel
                {
                    NoticePerPage = 5,
                    Notices = await _schoolServices.AllNotice(),
                    CurrentPage = page
                };
                return View(intView);
            }
        }
        /// <summary>
        /// Get all School student and using this method find student by name
        /// </summary>
        /// <param name="search"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AllStudent(string search, int page = 1)
        {
            if (search != null)
            {
                var intView = new StudentViewModel
                {
                    StudentPerPage = 5,
                    Students = await _schoolServices.FindStudent(search),
                    CurrentPage = page
                };
                return View(intView);
            }
            else
            {
                var intView = new StudentViewModel
                {
                    StudentPerPage = 5,
                    Students = await _schoolServices.AllStudent(),
                    CurrentPage = page
                };
                return View(intView);
            }
        }
        /// <summary>
        /// Get all teachers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AllTeacher()
        {
            IEnumerable<Teacher> teacher = await _schoolServices.AllTeacher();
            return View(teacher);
        }
        /// <summary>
        /// Get all book from library
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Library()
        {
            IEnumerable<Library> library = await _schoolServices.AllBook();
            return View(library);
        }
        /// <summary>
        /// Borrow/take book from library
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Borrowbook()
        {
            return View();
        }
        /// <summary>
        /// Borrow/take book from library
        /// </summary>
        /// <param name="BookId"></param>
        /// <param name="borrow"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Borrowbook(int BookId, BookBorrow borrow)
        {
            if (ModelState.IsValid)
            {
                var borrowresult = await _schoolServices.BorrowBook(BookId, borrow);
                return RedirectToAction("Thanks","School", new { BorrowId = borrowresult.BorrowId });
            }
            return View();
        }
        /// <summary>
        /// Get the borrow book info and Id to use while returning
        /// </summary>
        /// <param name="BorrowId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Thanks(int BorrowId)
        {
            var bookinfo = await _schoolServices.BorrowInfo(BorrowId);
            return View(bookinfo);
        }
    }
}
