using System;
using Microsoft.AspNetCore.Mvc;

namespace TeaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Coffees = new[]
        {
            "Green", "Pepermint", "Earl Grey", "English Breakfast", "Camomile"
        };

        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();
            return Ok(Coffees[rng.Next(Coffees.Length)]);
        }
    }
}