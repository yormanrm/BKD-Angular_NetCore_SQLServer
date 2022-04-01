using BKD_NetCore_SQLServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BKD_NetCore_SQLServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        public CardController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<CardController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listCards = await _context.Credit_Card.ToListAsync();
                return Ok(listCards);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }






        /* GET api/<CardController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/





        // POST api/<CardController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Credit_Card card)
        {
            try
            {
                _context.Add(card);
                await _context.SaveChangesAsync();
                return Ok(card);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<CardController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Credit_Card card)
        {
            try
            {
                if(id != card.id)
                {
                    return NotFound();
                }
                _context.Update(card);
                await _context.SaveChangesAsync();
                return Ok(new { message = "update card successfull" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<CardController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var card = await _context.Credit_Card.FindAsync(id);
                if(card == null)
                {
                    return NotFound();
                }
                _context.Credit_Card.Remove(card);
                await _context.SaveChangesAsync();
                return Ok(new { message = "delete card successfull" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
