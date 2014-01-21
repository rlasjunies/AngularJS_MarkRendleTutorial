using System;
using System.Collections.Generic;
using System.Linq;

namespace BedAndBroadband.Services
{
    using Simple.Data;
    using Simple.Web;
    using Simple.Web.Behaviors;

    [UriTemplate("/hotels/recentlyrated")]
    public class GetRecentlyRatedHotels : IGet, IOutput<IEnumerable<Hotel>>
    {
        private readonly dynamic _db = Database.OpenConnection("Default");
        public Status Get(){
            //throw new NotImplementedException();

            Output = _db.Hotels.All().OrderByLastRatingDateDescending().Take(5);

            return Status.Success.OK;
        }

        public IEnumerable<Hotel> Output { get; private set; }
    }

    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }    
    }
}
