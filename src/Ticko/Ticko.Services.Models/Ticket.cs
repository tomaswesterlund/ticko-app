using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticko.Services.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; set; }
        public Priorities Priority { get; set; }
        public Statuses Status { get; set; }
        public DateTime Created { get; set; }
        public User AssignedTo { get; set; }
        public User ReportedBy { get; set; }
    }
}
