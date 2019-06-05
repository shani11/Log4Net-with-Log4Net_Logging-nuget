using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Log4Net_Logging;
using Microsoft.AspNetCore.Mvc;

namespace Log4NetLogging_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        public ValuesController()
        {
            LogFourNet.SetUp(Assembly.GetEntryAssembly(), "log4net.config");
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            LogFourNet.Info(this, "This is Info logging");
            LogFourNet.Debug(this, "This is Debug logging");
            LogFourNet.Error(this, "This is Error logging");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
