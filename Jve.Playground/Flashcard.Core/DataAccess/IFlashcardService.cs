using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flashcard.Core.Entities;

namespace Flashcard.Core.DataAccess
{
    public interface IFlashcardService
    {
        IEnumerable<Card> GetBatch(int batchSize);
        IEnumerable<Card> GetAll();
        void SaveCard(Card card);
    }
}
