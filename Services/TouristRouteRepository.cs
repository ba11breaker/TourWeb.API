using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourWeb.API.Models;
using TourWeb.API.DataBase;

namespace TourWeb.API.Services {
    public class TouristRouteRepository: ITouristRouteRepository {
        private readonly AppDbContext _context;
        public TouristRouteRepository(AppDbContext context) {
            _context = context;
        }

        public IEnumerable<TouristRoute> GetTouristRoutes() {
            return this._context.TouristRoutes;
        }   

        public TouristRoute GetTouristRoute(Guid touristRouteId) {
            return this._context.TouristRoutes.FirstOrDefault(n => n.Id == touristRouteId);
        }        
    }
}