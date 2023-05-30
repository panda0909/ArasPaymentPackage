using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InnoPayApi.Models;

namespace InnoPayApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InUserPaymentsController : ControllerBase
    {
        private readonly ArasContext _context;

        public InUserPaymentsController(ArasContext context)
        {
            _context = context;
        }

        // GET: api/InUserPayments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InUserPayment>>> GetInUserPayments()
        {
          if (_context.InUserPayments == null)
          {
              return NotFound();
          }
            return await _context.InUserPayments.ToListAsync();
        }

        // GET: api/InUserPayments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InUserPayment>> GetInUserPayment(string id)
        {
          if (_context.InUserPayments == null)
          {
              return NotFound();
          }
            var inUserPayment = await _context.InUserPayments.FindAsync(id);

            if (inUserPayment == null)
            {
                return NotFound();
            }

            return inUserPayment;
        }

        // PUT: api/InUserPayments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInUserPayment(string id, InUserPayment inUserPayment)
        {
            if (id != inUserPayment.Id)
            {
                return BadRequest();
            }

            _context.Entry(inUserPayment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InUserPaymentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/InUserPayments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InUserPayment>> PostInUserPayment(InUserPayment inUserPayment)
        {
          if (_context.InUserPayments == null)
          {
              return Problem("Entity set 'ArasContext.InUserPayments'  is null.");
          }
            _context.InUserPayments.Add(inUserPayment);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (InUserPaymentExists(inUserPayment.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInUserPayment", new { id = inUserPayment.Id }, inUserPayment);
        }

        // DELETE: api/InUserPayments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInUserPayment(string id)
        {
            if (_context.InUserPayments == null)
            {
                return NotFound();
            }
            var inUserPayment = await _context.InUserPayments.FindAsync(id);
            if (inUserPayment == null)
            {
                return NotFound();
            }

            _context.InUserPayments.Remove(inUserPayment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InUserPaymentExists(string id)
        {
            return (_context.InUserPayments?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
