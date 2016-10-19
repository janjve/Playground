using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard.Core.DataAccess
{
    public interface IFlashcardService
    {
        IEnumerable<Entities.Card> GetBatch(int batchSize);
        IEnumerable<Entities.Card> GetAll();
    }
}
