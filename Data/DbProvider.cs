using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DbProvider
    {

        //DbProvider-ToDo
        //TODO Initialize DB-Model Object 
        ProjectDbEntities dbmodel = new ProjectDbEntities();
        //TODO Write Linq-Queries


        //TODO LinqQueryAll
        public List<Person> QueryAll()
        {
            var query = (from b in dbmodel.People
                         select new
                         {
                             Id = b.Id,
                             Name = b.Name,
                         }).ToList().Select(x => new Person
                         {
                             Id = x.Id,
                             Name = x.Name
                         });
            return query.ToList();
        }


        //TODO LinqInsert
        public int Add(string b)
        {
            dbmodel.People.Add(new Person()
            {
                Name = b
            });

            return dbmodel.SaveChanges();
        }
    }
}
