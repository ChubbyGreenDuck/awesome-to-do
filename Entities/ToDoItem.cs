using System;

namespace Entities
{
    public class ToDoItem
    {
        public Guid ItemId { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public DateTime CompletionTime { get; set; }
        public Guid AppUserId { get; set; }

    }
}