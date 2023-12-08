using Hotel.BusinessLayer.Abstract;
using Hotel.DataAccessLayer.Abstract;
using Hotel.DataAccessLayer.EntityFramework;
using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BusinessLayer.Concrete
{
    public class VideoManager : IVideoService
    {
        private readonly IVideoDal _videoService;   
        public VideoManager(IVideoDal videoDal)
        {
            _videoService = videoDal;
        }

        public void TDelete(Video t)
        {
            _videoService.Delete(t);
        }

        public Video TGetByID(int id)
        {
            return _videoService.GetByID(id);
        }

        public List<Video> TGetList()
        {
            return _videoService.GetList();
        }

        public void TInsert(Video t)
        {
           _videoService.Insert(t);
        }

        public void TUpdate(Video t)
        {
            _videoService.Update(t);
        }
    }
}
