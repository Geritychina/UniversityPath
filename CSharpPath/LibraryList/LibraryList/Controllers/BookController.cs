﻿using LibraryList.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryList.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public  async Task <IActionResult> GetAll()
        {
            return Json(new { data = await _db.Book.ToListAsync()});
        }

        [HttpDelete]
        public async Task <IActionResult> Delete(int id)
        {
            var BookFromDb = await _db.Book.FirstOrDefaultAsync(u=>u.Id==id);
            if (BookFromDb==null)
            {
                return Json(new {success = false, message = "Error while Deleting" });
            }
            _db.Book.Remove(BookFromDb);
            await _db.SaveChangesAsync();
            return Json(new {success = true, message = "Delete successful" });
        }
    }
}
