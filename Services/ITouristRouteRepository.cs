using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourWeb.API.Models;

namespace TourWeb.API.Services {
    public interface ITouristRouteRepository {
        IEnumerable<TouristRoute> GetTouristRoutes();
        TouristRoute GetTouristRoute(Guid touristRouteId);
    }
}