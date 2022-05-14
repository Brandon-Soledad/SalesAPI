using SalesAPI.Data.Extensions;
using SalesAPI.Data.Models;
using Microsoft.AspNetCore.Mvc;



namespace SalesAPI.Controllers
{


    [Route("/api[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {

        public DataContext _context { get; }

        public SalesController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<SalesItem>>> Get()
        {
            return Ok(await _context.SalesItems.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<SalesItem>>> Get(int id)
        {
            var listing = await _context.SalesItems.FindAsync(id);
            if (listing == null)
            {
                return BadRequest("Listing not found");
            }
            return Ok(listing);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult<List<SalesItem>>> Post(SalesItem salesPost)
        {
            _context.SalesItems.Add(salesPost);
            await _context.SaveChangesAsync();
            return Ok(await _context.SalesItems.ToListAsync());
        }

        // PUT api/<ValuesController>
        [HttpPut("Update/{id}")]
        public async Task<ActionResult<List<SalesItem>>> Put(int id, [FromBody]SalesItem salesPost)
        {
            var listing = await _context.SalesItems.FindAsync(id);

            if (ModelState.IsValid && listing != null)
            {
                _context.SalesItems.Update(listing, salesPost);
                await _context.SaveChangesAsync();

                return Ok(listing);
            }
            return NotFound();
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var listing = await _context.SalesItems.FindAsync(id);

            if (listing != null)
            {
                _context.SalesItems.Remove(listing);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }
    }
}
