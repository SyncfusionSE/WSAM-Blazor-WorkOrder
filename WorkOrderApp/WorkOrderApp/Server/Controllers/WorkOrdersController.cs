

using WorkOrderApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkOrderApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkOrdersController : ControllerBase
    {
        private OrderDataContext _context;
        public WorkOrdersController(OrderDataContext context)
        {
            _context = context;
        }

        // GET: api/<WorkOrderController>
        [HttpGet]
        public object Get()
        {
            return new { Items = _context.WorkOrder, Count = _context.WorkOrder.Count() };
        }

        //// POST api/<BooksController>
        //[HttpPost]
        //public void Post([FromBody] Book book)
        //{
        //    _context.Books.Add(book);
        //    _context.SaveChanges();
        //}

        //// PUT api/<BooksController>
        //[HttpPut]
        //public void Put(long id, [FromBody] Book book)
        //{
        //    Book _book = _context.Books.Where(x => x.Id.Equals(book.Id)).FirstOrDefault();
        //    _book.Name = book.Name;
        //    _book.Author = book.Author;
        //    _book.Price = book.Price;
        //    _book.Quantity = book.Quantity;
        //    _book.Available = book.Available;
        //    _context.SaveChanges();
        //}

        //// DELETE api/<BooksController>
        //[HttpDelete("{id}")]
        //public void Delete(long id)
        //{
        //    Book _book = _context.Books.Where(x => x.Id.Equals(id)).FirstOrDefault();
        //    _context.Books.Remove(_book);
        //    _context.SaveChanges();
        //}
    }
}
