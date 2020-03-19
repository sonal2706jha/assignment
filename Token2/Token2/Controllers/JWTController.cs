using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Token2.Data;
using Token2.Models;

namespace Token2.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class JWTController : ControllerBase
    {
        private readonly IHelper _helper;
        public JWTController(IHelper helper)
        {
            _helper = helper;
        }

        [HttpPost]
        public IActionResult Token(Login detail)
        {
            try
            {
                return Ok(_helper.TokenGenerate(detail));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                string result = "Normal Get";
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public IActionResult GetCommon()
        {

            try
            {
                return Ok("Method can be invoked without any Authorization.");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult GetADmin()
        {
            try
            {

                return Ok("Hello!...... admin.");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        [Authorize(Roles = "user")]
        public IActionResult GetUser()
        {

            try
            {
                return Ok("Hello!....User ");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}