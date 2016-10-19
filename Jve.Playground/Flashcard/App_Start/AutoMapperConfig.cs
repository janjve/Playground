using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Flashcard.Core.Entities;
using Flashcard.Models;

namespace Flashcard
{
    public class AutoMapperConfig
    {
        public static void InitializeMappers()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Card, FlashcardModel>());
        }
    }
}