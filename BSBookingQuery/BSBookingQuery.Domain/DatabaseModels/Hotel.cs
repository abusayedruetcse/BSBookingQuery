using System;

namespace BSBookingQuery.Domain.DatabaseModels
{
    public class Hotel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Rating Rating { get; set; }
    }
}
