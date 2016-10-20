using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace Flashcard.Models
{
    public class FlashcardModel
    {
        public Guid Id { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
        public int Priority { get; set; }
    }
}