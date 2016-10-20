using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using Flashcard.Core.DataAccess;
using Flashcard.Core.Entities;
using Flashcard.Models;

namespace Flashcard.Controllers.API
{
    public class FlashcardController : ApiController
    {
        private readonly IFlashcardService _flashcardService;

        public FlashcardController(IFlashcardService flashcardService)
        {
            if (flashcardService == null) throw new ArgumentNullException(nameof(flashcardService));
            _flashcardService = flashcardService;
        }

        [HttpGet]
        public IList<FlashcardModel> GetBatch()
        {
            return _flashcardService
                .GetBatch(10)
                .Select(Mapper.Map<Card, FlashcardModel>)
                .ToList();
        }

        [HttpGet]
        public IList<DetailedFlashcardModel> GetAll()
        {
            return _flashcardService
                .GetAll()
                .Select(Mapper.Map<Card, DetailedFlashcardModel>)
                .ToList();
        }

    }
}
