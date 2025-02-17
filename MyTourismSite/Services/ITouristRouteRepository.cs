﻿using MyTourismSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTourismSite.Services
{
    public interface ITouristRouteRepository
    {
        IEnumerable<TouristRoute> GetTouristRoutes();
       TouristRoute GetTouristRoute(Guid touristRouteId);
    }
}
