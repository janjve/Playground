using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Flashcard.Models;

namespace Flashcard.Controllers.API
{
    public class FlashcardController : ApiController
    {
        [HttpGet]
        public IList<FlashcardModel> GetBatch()
        {
            // dummy
            return new List<FlashcardModel>
            {
                new FlashcardModel
                {
                    Front = "How many planets are there in our solar system, excluding Pluto?",
                    Back = "There are eight planets. They are: Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus and Neptune.",
                    Order = 1
                },
                new FlashcardModel
                {
                    Front = "What are the three primary architectual layers in a Lambda architecture?",
                    Back = "The three layers are: the speed, the serving and the batch layer",
                    Order = 2,
                },
            };
        }
    }
}
