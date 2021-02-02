using AutoMapper;
using System;
using System.Collections.Generic;
using TwitterAPI.Core.Context;
using TwitterAPI.Core.Posts;

namespace TwitterAPI.Core.Mapper
{
    public class CustomMapperProfile : Profile
    {
        public CustomMapperProfile()
        {
            CreateMap<Post, PostDto>().ReverseMap();
            CreateMap<PostRequestModel, Post>()
                .ForMember(dest => dest.CreateDate , opt => opt.MapFrom(src => DateTime.Now));
        }
    }
}
