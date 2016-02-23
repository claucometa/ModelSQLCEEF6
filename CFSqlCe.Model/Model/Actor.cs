using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CFSqlCe.Domain.Model
{
    public class Actor
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Note { get; set; }
        public virtual List<ActorRole> Roles { get; set; }

        public Actor()
        {
            Roles = new List<ActorRole>();
        }
    }
}
