using System.Collections.Generic;

namespace DemoApp
{
    public class HotelStore
    {
        public List<Hotel> GetHotels()
        {
            return new List<Hotel>
            {
                new Hotel{Name = "MGM", CityName = "Las Vegas", CountryCode = "US", StarRating = 5},
                new Hotel{ Name = "Venetian", CityName = "Las Vegas", CountryCode = "US", StarRating = 4.5f },
                new Hotel{ Name = "Bellagio", CityName = "Las Vegas", CountryCode = "US", StarRating = 5 },
                new Hotel{ Name = "Mirage", CityName = "Las Vegas", CountryCode = "US", StarRating = 4 }
            };
        }
    }
}
