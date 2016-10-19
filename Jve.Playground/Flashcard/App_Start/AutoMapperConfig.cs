using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Flashcard.Models;

namespace Flashcard
{
    public class AutoMapperConfig
    {
        public static void InitializeMappers()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Core.Entities.Card, FlashcardModel>());
        }
    }
}