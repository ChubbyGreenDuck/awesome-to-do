using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class AppUser
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<ToDoItem> Items { get; set; }

    }
}
