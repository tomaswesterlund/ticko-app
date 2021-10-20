using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticko.Services.Models
{
    public class Comment
    {
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public User WrittenBy { get; set; }
    }
}
