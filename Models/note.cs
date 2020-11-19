using System;
using System.Collections.Generic;

namespace stickynotes.Models
{
    public class Note
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime EntryDate { get; set; }

    }
}