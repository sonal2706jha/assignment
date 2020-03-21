using _dFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _dFirst.Data
{
    public class DFirst : IDFirst
    {
        public IEnumerable<Customers> Show()
        {
            try
            {
                var context = new EntityContext();

                var cus = (from e in context.Customers.Include("Orders") select e);
                return cus.ToList();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Customers> GetId(int id)
        {
            try
            {
                var context = new EntityContext();
                var cus = (from c in context.Customers.Where(c => c.CustomerId == id).Include(s => s.Orders).ThenInclude(s => s.Product) select c);
                return cus.ToList();
            }

            catch (Exception ex)
            {
                throw ex;
            }


        }

        public string Insert(Orders orders)
        {
            var context = new EntityContext();
            try
            {

                context.Orders.Add(orders);
                context.Customers.Add(orders.Customer);
                context.Products.Add(orders.Product);
                context.SaveChanges();
                return "Done";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Update(Orders orders)
             
        {
            try
            {
                var context = new EntityContext();

                var result = context.Customers.FirstOrDefault(c => c.CustomerId ==orders.CustomerId);
                    
                context.Customers.Update(result);
                context.SaveChanges();

                return "Updated data";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string Delete(Orders orders)
        {
            try
            {

                var context = new EntityContext();

                var result = context.Customers.FirstOrDefault(i => i.CustomerId == orders.CustomerId);
                context.Customers.Remove(result);

                var result1 = context.Orders.FirstOrDefault(i => i.OrderId == orders.CustomerId);
                context.Orders.Remove(result1);



                context.SaveChanges();

                return "Delete";

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}
