using System.IO;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SuggestiveService.Interfaces;
using SuggestiveService.Models;
using SuggestiveService.Models.AvailableData;
using SuggestiveService.Services;



namespace SuggestiveService
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            //CreateMap<ArchivedData, CourseDOBAvlData>().ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.CourseCode)); ;
         
            //CreateMap<AvlDataInput, AvlArchivedData>();
        }
    }
}
