using System;
using Xunit;

namespace DemoApp.Tests
{
    public class HotelStoreTest
    {
        [Fact]
        public void TestGetHotels()
        {
            var hotelStore = new HotelStore();
            var hotels = hotelStore.GetHotels();
            Assert.Equal(4, hotels.Count);
        }
    }
}
