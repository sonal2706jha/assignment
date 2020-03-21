using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _dFirst.Data;
using _dFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DB_First.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class ActionController : ControllerBase
    {
        private readonly IDFirst _first;

        public ActionController(IDFirst first)
        {
            _first =first;
        }

        [HttpGet]

        public IActionResult Show()
        {
            try
            {
                var result= _first.Show();
                return Ok(result);
            }

            catch (Exception ex)
            {
                throw (ex);
            }


        }

        [HttpGet("{id}")]

        public IActionResult GetId(int id)
        {
            try
            {
                var result = _first.GetId(id);
                return Ok(result);
            }

            catch (Exception ex)
            {
                throw (ex);
            }


        }

        [HttpPost]

        public IActionResult Insert(Orders orders)
        {
            try
            {
               var result = _first. Insert(orders); 
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw(ex);
            }

        }
        [HttpPut]
        public IActionResult Update(Orders orders)
        {
            try
            {
                var result = _first.Update(orders);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpDelete]

        public IActionResult Delete(Orders orders)
        {
            try
            {
                var result = _first.Delete(orders);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }




    }

}
