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
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Card, FlashcardModel>();
                cfg.CreateMap<Card, DetailedFlashcardModel>();
                cfg.CreateMap<CreateCardModel, Card>().AfterMap((src, dest) =>
                {
                    dest.Priority = 3;
                    dest.createdAt = DateTime.Now;
                    dest.Id = src.Id ?? Guid.NewGuid();
                });
            });
        }
    }
}