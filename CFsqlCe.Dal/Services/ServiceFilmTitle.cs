using CFSqlCe.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFSqlCe.Dal.Services
{
    public class ServiceActor
    {
        CrudRepo<Actor> repo = new CrudRepo<Actor>();

        public void Add()
        {
            var f = new Actor()
           {
               Name = "Angelina Julie",
           };

            var role = new ActorRole()
            {
                Actor = f,
                Character = "Lara Croft",
                Description = "Tomb Rider"
            };

            repo.Add(f);
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
