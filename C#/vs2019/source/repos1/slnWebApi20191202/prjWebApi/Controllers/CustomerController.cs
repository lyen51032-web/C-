using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using prjWebApi.Models;

namespace prjWebApi.Controllers
{
    public class CustomerController : ApiController
    {
        dbCustomerEntities db = new dbCustomerEntities();
        // GET: api/Customer
        public List<tCustomer> Get()
        {
            var customers = db.tCustomer;
            return customers.ToList();
        }

        // GET: api/Customer/5
        public tCustomer Get(int fid)
        {
            var customer = db.tCustomer.Where(m => m.fId == fid).FirstOrDefault();
            return customer;
        }

        // POST: api/Customer
        public int Post(string fname, string fphone, string femail, string faddress)
        {
            int num = 0;
            try
            {
                tCustomer customer = new tCustomer();
                customer.fName = fname;
                customer.fPhone = fphone;
                customer.fEmail = femail;
                customer.fAddress = faddress;
                db.tCustomer.Add(customer);
                num = db.SaveChanges();
            }
            catch (Exception ex)
            {
                num = 0;
            }
            return num;
        }

        // PUT: api/Customer/5
        public int Put(int fid, string fname, string fphone, string femail, string faddress)
        {
            int num = 0;
            try
            {
                var customer = db.tCustomer.Where(m => m.fId == fid).FirstOrDefault();
                customer.fName = fname;
                customer.fPhone = fphone;
                customer.fEmail = femail;
                customer.fAddress = faddress;
                num = db.SaveChanges();
            }
            catch (Exception ex)
            {
                num = 0;
            }
            return num;
        }

        // DELETE: api/Customer/5
        public int Delete(int fId)
        {
            int num = 0;
            try
            {
                var customer = db.tCustomer.Where(m => m.fId == fId).FirstOrDefault();
                db.tCustomer.Remove(customer);
                num = db.SaveChanges();
            }
            catch (Exception ex)
            {
                num = 0;
            }
            return num;
        }
    }
}
