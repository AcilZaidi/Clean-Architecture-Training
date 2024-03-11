﻿using AutoMapper;
using Postland.Domain;
using PostLand.Application.Features.Posts.Queries.GetPostList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Post,GetPostListViewModel>().ReverseMap();
        }
    }
}