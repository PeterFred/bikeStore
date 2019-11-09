using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BikeStoreDataAccess;

namespace BikeStoreProject.Controllers
{
    public class BikeStoreController : ApiController
    {
        public virtual IEnumerable<customers> Get()
        {
            using (BikeStoresEntities entities = new BikeStoresEntities())
            {
                return entities.customers.ToList();
            }
        }

        public virtual customers Get(int id)
        {
            using(BikeStoresEntities entities = new BikeStoresEntities())
            {
                return entities.customers.FirstOrDefault(e => e.customer_id == id);
            }
        }
    }
}
