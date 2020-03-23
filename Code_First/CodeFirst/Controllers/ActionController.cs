

using Codefirst.DataMethods;
using Codefirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Codefirst.Controllers
{
    public class ActionController : ApiController
    {
        Customer customer = new Customer();
        Orders orders = new Orders();
        Comapny _customer = new Comapny();

        [HttpGet]
        public IHttpActionResult GetData()
        {
            try
            {
                var result = _customer.GetData();
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpGet]
        public IHttpActionResult GetId(int id)
        {
            try
            {
                var result = _customer.GetId(id);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public IHttpActionResult InsertData(Customer customer)
        {

            try
            {
                if (customer == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _customer.InsertData(customer);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " Can't Insert" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut]
        public IHttpActionResult UpdateData(int id, Orders orders)
        {

            try
            {
                if (orders == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _customer.UpdateData(id, orders);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " Can't update" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpDelete]

        public IHttpActionResult DeleteData(Orders orders)
        {

            try
            {

                bool result = _customer.DeleteData(orders);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " Can't Delete" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}

    

