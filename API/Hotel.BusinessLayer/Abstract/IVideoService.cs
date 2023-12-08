﻿using Hotel.DataAccessLayer.Abstract;
using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BusinessLayer.Abstract
{
    public interface IVideoService : IGenericService<Video>
    {
    }
}