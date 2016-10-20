using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard.Core.Entities
{
    public class Card
    {
        public Guid Id { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
        public int Priority { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
