using BookStore_API.Contracts;
using BookStore_API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore_API.Controllers
{
    /// <summary>
    /// This is a test API Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILoggerService _logger;

        public HomeController(ILoggerService logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get books
        /// </summary>
        /// <returns></returns>
        // GET: api/Home
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Accessed HomeController");
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a single book
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/Home/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            _logger.LogDebug("Got a value");
            return "value";
        }

        // POST api/Home
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _logger.LogError("This is a post error");
        }

        // PUT api/Home/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            _logger.LogDebug("Put a value");
        }

        // DELETE api/Home/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _logger.LogWarn("This is a delete warning");
        }
    }
}
