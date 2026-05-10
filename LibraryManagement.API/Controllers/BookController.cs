using LibraryManagement.API.Data;
using LibraryManagement.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<IEnumerable<Book>>> Get()
        {
            var books = await _context.Books.AsNoTracking().ToListAsync();
            return Ok(books);
        }
        // GET: api/Book/5   To get a book by id
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> Get(int id)
        {
            var book = await _context.Books.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id);
            if (book is null)
            {
                return NotFound();
            }
            return Ok(book);
        }
        // POST: api/Book   To add a book
        [HttpPost]
        public async Task<ActionResult<Book>> Create(Book book)
        {
            var newBook = new Book
            {
                Title = book.Title,
                Author = book.Author,
                Description = book.Description,
                PhotoUrl = book.PhotoUrl
            };
            _context.Books.Add(newBook);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = newBook.Id }, newBook);
        }
        // PUT: api/Book/5   To update a book
        [HttpPut("{id}")]
        public async Task<ActionResult<Book>> Update(int id, Book updatedBook)
        {
            var book = await _context.Books.FindAsync(id);
            if (book is null)
            {
                return NotFound();
            }
            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.Description = updatedBook.Description;
            book.PhotoUrl = updatedBook.PhotoUrl;


            await _context.SaveChangesAsync();
            return Ok(book);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book is null)
            {
                return NotFound();
            }
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
