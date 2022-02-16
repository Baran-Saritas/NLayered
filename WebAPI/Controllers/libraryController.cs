using DataAccess;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{


    public class libraryController : ControllerBase
    {
        private readonly LibraryContext _libraryContext;

        public libraryController(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }


        [HttpPost("/api/books")]
        public async Task<IActionResult> AddBook()
        {
            await _libraryContext.Books.AddAsync(new Book
            {
                book_name = "LOTR",
                alinma_bilgisi = true,

            });
            await _libraryContext.SaveChangesAsync();
            return Ok("Add Book.");
        }

    }
}
