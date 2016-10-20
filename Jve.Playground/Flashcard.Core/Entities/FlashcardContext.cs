using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard.Core.Entities
{
    public class FlashcardContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
    }
}
