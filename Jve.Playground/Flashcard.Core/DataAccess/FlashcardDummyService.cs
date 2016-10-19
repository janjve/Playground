using System.Collections.Generic;
using Flashcard.Core.Entities;

namespace Flashcard.Core.DataAccess
{
    public class FlashcardDummyService : IFlashcardService
    {
        public IEnumerable<Card> GetBatch(int batchSize)
        {
            return new List<Card>
            {
                new Card
                {
                    Front = "How many planets are there in our solar system, excluding Pluto?",
                    Back = "There are eight planets. They are: Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus and Neptune.",
                    Order = 1
                },
                new Card
                {
                    Front = "What are the three primary architectual layers in a Lambda architecture?",
                    Back = "The three layers are: the speed, the serving and the batch layer",
                    Order = 2,
                },
            };
        }

        public IEnumerable<Card> GetAll()
        {
            return new List<Card>
            {
                new Card
                {
                    Front = "How many planets are there in our solar system, excluding Pluto?",
                    Back = "There are eight planets. They are: Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus and Neptune.",
                    Order = 1
                },
                new Card
                {
                    Front = "What are the three primary architectual layers in a Lambda architecture?",
                    Back = "The three layers are: the speed, the serving and the batch layer",
                    Order = 2,
                },
                new Card
                {
                    Front = "Why is this question only showing up on the flashcards list?",
                    Back = "The card has been answered recently.",
                    Order = 5,
                },
            };
        }
    }
}
