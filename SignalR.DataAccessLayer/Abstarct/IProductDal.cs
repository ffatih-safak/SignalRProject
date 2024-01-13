﻿using SignalR.EntityLayer.Entities;
using SignalRApi.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstarct
{
    public interface IProductDal : IGenericDal<Product>
    {
    }
}