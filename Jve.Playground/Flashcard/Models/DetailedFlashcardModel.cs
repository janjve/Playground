using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flashcard.Models
{
    public class DetailedFlashcardModel
    {
        public Guid Id { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
        public int Priority { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}