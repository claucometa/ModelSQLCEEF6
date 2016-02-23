using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CFSqlCe.Domain.Model
{
    public class ActorRole
    {
        public int Id { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public String Character { get; set; }
        public String Description { get; set; }
    }
}
