using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourWeb.API.Models;

namespace TourWeb.API.Services {
    public class MockTouristRouteRepository : ITouristRouteRepository {
        private List<TouristRoute> _routes;

        public MockTouristRouteRepository() {
            if (this._routes == null) {
                this.InitializeTouristRoutes();
            }
        }
        public IEnumerable<TouristRoute> GetTouristRoutes() {
            return this._routes;
        }

        private void InitializeTouristRoutes() {
            this._routes = new List<TouristRoute>
            {
                new TouristRoute {
                    Id = Guid.NewGuid(),
                    Title = "黄山",
                    Description = "黄山真好玩",
                    OriginalPrice = 1299,
                    Features = "<p>吃住行游购娱</p>",
                    Fees = "<p>交通费用自理</p>",
                    Notes = "<p>小心危险</p>"
                },
                new TouristRoute {
                    Id = Guid.NewGuid(),
                    Title = "华山",
                    Description = "华山真好玩",
                    OriginalPrice = 1299,
                    Features = "<p>吃住行游购娱</p>",
                    Fees = "<p>交通费用自理</p>",
                    Notes = "<p>小心危险</p>"
                },
            };
        }

        public TouristRoute GetTouristRoute(Guid touristRouteId) {
            return this._routes.FirstOrDefault(n => n.Id == touristRouteId);
        }
    }
}