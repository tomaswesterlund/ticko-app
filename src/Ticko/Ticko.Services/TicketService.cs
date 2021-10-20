using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticko.Services.Models;

namespace Ticko.Services
{
    public class TicketService
    {
        private UserService _userService;
        private List<Ticket> _tickets;

        public TicketService(UserService userService)
        {
            _userService = userService;

            _tickets = new List<Ticket>
            {
                new Ticket()
                {
                    Id = 1,
                    Title = "My first ticket!",
                    Description = "The issue is that there are no more tickets. Is this good or bad? No more work but at the same time no more work?",
                    Comments = new List<Comment>(),
                    Priority = Priorities.Normal,
                    Status = Statuses.InProgress,
                    Created = DateTime.Now,
                    AssignedTo = _userService.GetById(1),
                    ReportedBy = _userService.GetById(2)
                }
            };
        }

        public List<Ticket> GetAll() 
        {
            return _tickets;
        }

        public List<Ticket> GetAllOrderedByPriority()
        {
            return GetAll().OrderBy(c => c.Priority).ToList();
        }

        public Ticket GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
