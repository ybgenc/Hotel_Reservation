﻿using AutoMapper;
using Hotel.DtoLayer.Dtos.RoomDto;
using Hotel.EntityLayer.Concrete;

namespace Hotel.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateRoomDto, Room>().ReverseMap();

            CreateMap<UpdateRoomDto, Room>().ReverseMap();

        }
    }
}
