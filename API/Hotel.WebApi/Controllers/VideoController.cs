using AutoMapper;
using Hotel.BusinessLayer.Abstract;
using Hotel.DtoLayer.Dtos.VideoDto;
using Hotel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private readonly IVideoService _videoService;
        private readonly IMapper _mapper;
        public VideoController(IVideoService videoService , IMapper mapper)
        {
            _videoService = videoService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = _videoService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateVideo(CreateVideoDto createVideoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Video>(createVideoDto);
            _videoService.TInsert(values);
            return Ok(values);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateVideo(UpdateVideoDto updateVideoDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Video>(updateVideoDto);
            _videoService.TUpdate(values);
            return Ok(values);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteVideo(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Video>(id);
            _videoService.TDelete(values);
            return Ok(values);
        }
    }
}
