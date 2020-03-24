using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api.Entities
{
    public class Player
    {
        public string id;
        public Location currentLocation;
        public long currentTimestamp;
        public Location previousLocation;
        public long previousTimestamp;
        public bool tracked;
        public bool atHome;
    }
}
