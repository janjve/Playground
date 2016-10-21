using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flashcard.Core.Entities;

namespace Flashcard.Core.DataAccess
{
    public class FlashcardService : IFlashcardService
    {
        public IEnumerable<Card> GetBatch(int batchSize)
        {
            using (var db = new FlashcardContext())
            {
                return db.Cards
                    .Where(x => true) // TODO: Predicate.
                    .OrderBy(x => x.Priority) // TODO: Ordering.
                    .Take(batchSize);
            }
        }

        public IEnumerable<Card> GetAll()
        {
            using (var db = new FlashcardContext())
            {
                return db.Cards;
            }
        }

        public void SaveCard(Card card)
        {
            using (var db = new FlashcardContext())
            {
                db.Cards.AddOrUpdate(card);
                db.SaveChanges();
            }
        }
    }
}
