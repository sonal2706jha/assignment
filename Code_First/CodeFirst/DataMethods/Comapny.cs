

using Codefirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codefirst.DataMethods
{
    public class Comapny
    {
        //CodeFirstContext db;

        Customer customers = new Customer();
        Orders orders = new Orders();

        public IEnumerable<Customer> GetData()
        {

            var context = new CodeFirstContext();
            try
            {


                var result = context.Customers.Include(s => s.Orders).ToList();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public Customer GetId(int id)
        {
            var context = new CodeFirstContext();


            try
            {
                var result = context.Customers.Where(c => c.CustomerId == id).Include(s => s.Orders).ThenInclude(s => s.Product).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool InsertData(Customer customer)
        {
            var context = new CodeFirstContext();
            try
            {

                context.Add(customer);
                context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool DeleteData(Orders orders)
        {
            try
            {
                var context = new CodeFirstContext();

                
                var c = context.Orders.First(d => d.OrderId == orders.OrderId);
                context.Orders.Remove(c);
                var o = context.Customers.First(d => d.CustomerId == orders.CustomerId);
                context.Customers.Remove(o);


                var p = context.Products.First(d => d.ProductId == orders.ProductId);
                context.Products.Remove(p);


                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateData(int id, Orders orders)
        {
            try
            {
                var context = new CodeFirstContext();
                var std = context.Orders.Include(o => o.Customer).Include(p => p.Product).FirstOrDefault(s => s.OrderId == id);


                std.OrderAddress = orders.OrderAddress;

               



                context.Entry(std).State = EntityState.Modified;
                context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
