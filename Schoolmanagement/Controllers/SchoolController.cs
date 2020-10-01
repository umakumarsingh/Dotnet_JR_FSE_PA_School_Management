using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
        /// Creating a referance variable of ISchoolServices and injecting in SchoolController constructor
        /// </summary>
        private readonly ISchoolServices _schoolServices;

        public SchoolController(ISchoolServices schoolServices)
        {
            _schoolServices = schoolServices;
        }
        /// <summary>
        /// Get all School Notice and using this method find notice by Notice name and Event type
        /// </summary>
        /// <param name="search"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AllNotice(string search, int page = 1)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all School Student and using this method find Student by name
        /// </summary>
        /// <param name="search"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AllStudent(string search, int page = 1)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all teachers list.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AllTeacher()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all book list
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Library()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Borrow book get method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Borrowbook()
        {
            return View();
        }
        /// <summary>
        /// Borrow book from library and save borrow infromation under BookBorrow class.
        /// </summary>
        /// <param name="BookId"></param>
        /// <param name="borrow"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Borrowbook(int BookId, BookBorrow borrow)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get book borrow infromation and use while collecting book
        /// </summary>
        /// <param name="BorrowId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Thanks(int BorrowId)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
