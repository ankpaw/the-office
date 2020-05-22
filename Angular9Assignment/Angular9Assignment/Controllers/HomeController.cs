using Angular9Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Angular9Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<HomeModel>> Get()
        {
            return new List<HomeModel>()
            {
                new HomeModel()
                {
                    Tier1Name = "Drive tech intensity",
                    Tier2Names = new string[] { "Digital Transformation", "Digital Stewardship", "Open Data Initiative" }

                },
                new HomeModel()
                {
                    Tier1Name = "Earn trust every day",
                    Tier2Names = new string[] { "Privacy Operations and Policy", "Security Operations and Policy", "Digital Safety" }

                },
                new HomeModel()
                {
                    Tier1Name = "Ensure the responsible use of technology",
                    Tier2Names = new string[] {  "AI Governance Across Microsoft", "Responsible AI Around the World", "Facial Recognition"}

                },
                new HomeModel()
                {
                    Tier1Name = "Address the impact of technology",
                    Tier2Names = new string[] { "Learning and the Future of Work", "Connectivity and Broadband Access", "TSI and the Non-Profit Community" }

                },
            };
        }
    }
}
