using LibraryManagement.API.Data;
using LibraryManagement.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly AppDbContext _context;
        public BookController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/Book   To get all books
        [HttpGet]
        public IActionResult Get()
        {
            var books = _context.Books;
            return Ok(books);
        }
        // GET: api/Book/5   To get a book by id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
        // POST: api/Book   To add a book
        [HttpPost]
        public IActionResult Create(Book book)
        {
            book = new Book
            {
                Title = book.Title,
                Author = book.Author,
                Description = book.Description,
                PhotoUrl = book.PhotoUrl
            };
            _context.Books.Add(book);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
        // PUT: api/Book/5   To update a book
        [HttpPut("{id}")]
        public IActionResult Update(int id, Book updatedBook)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.Description = updatedBook.Description;
            book.PhotoUrl = updatedBook.PhotoUrl;


            _context.SaveChanges();
            return Ok(book);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            _context.Books.Remove(book);
            _context.SaveChanges();
            return Ok();
        }
    }
}
