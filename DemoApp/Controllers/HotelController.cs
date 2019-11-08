using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    [Route("hotel")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        [Route("list")]
        [HttpGet]
        public ActionResult<IEnumerable<Hotel>> Get()
        {
            var hotelStore = new HotelStore();
            var hotels = hotelStore.GetHotels();
            return Ok(hotels);
        }
    }
}
