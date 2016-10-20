using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flashcard.Models
{
    public class CreateCardModel
    {
        public Guid? Id { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
    }
}