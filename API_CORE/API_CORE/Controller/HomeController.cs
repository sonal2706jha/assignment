using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using API_CORE.Data;
using API_CORE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_CORE
{
    [Route("api/{Controller}/{Action}/{EMP_ID?}")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IEmployee _data;

        public HomeController(IEmployee data)
        {
            _data = data;

        }

        
        [HttpGet]
        public IActionResult GetData()
        {
            DataSet ds = _data.GetData();
            return Ok(ds);
        }

        
        [HttpGet]
        public IActionResult GetDataId(int EMP_ID)
        {
            DataSet ds = _data.GetDataId(EMP_ID);
            return Ok(ds);
        }

      
        [HttpPost]
        public IActionResult InsertData(EMP E)
        {
            var ds = _data.InsertData(E);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateData(int EMP_ID,EMP E)
        {
            var ds = _data.UpdateData(EMP_ID,E);
            return Ok(ds);
        }
        [HttpDelete]
        public IActionResult DeleteData(EMP E)
        {
            DataSet ds = _data.DeleteData(E);
            return Ok(ds);
        }
    }

}