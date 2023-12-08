using AutoMapper;
using Hotel.DtoLayer.Dtos.RoomDto;
using Hotel.EntityLayer.Concrete;
using Hotel.DtoLayer.Dtos.VideoDto;

namespace Hotel.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();

            CreateMap<CreateVideoDto, Video>().ReverseMap();
            CreateMap<UpdateVideoDto,Video>().ReverseMap();

        }
    }
}
