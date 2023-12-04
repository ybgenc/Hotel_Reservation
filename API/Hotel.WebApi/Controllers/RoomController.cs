using Hotel.BusinessLayer.Abstract;
using Hotel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoomController : ControllerBase
	{
		private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }
        [HttpGet]
		public IActionResult List()
		{
			var values = _roomService.TGetList();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateRoom(Room room)
		{
			_roomService.TInsert(room);
			return Ok();
		}
		[HttpDelete]
		public IActionResult DeleteRoom(int id)
		{
			var values = _roomService.TGetByID(id);
			_roomService.TDelete(values);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateRoom(Room room)
		{
			_roomService.TUpdate(room);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetRoom(int id)
		{
			var values = _roomService.TGetByID(id);
			return Ok(values);
		}
	}
}
