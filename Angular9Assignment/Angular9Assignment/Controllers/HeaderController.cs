namespace Angular9Assignment.Controllers
{
    using Angular9Assignment.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    public class HeaderController
    {
        [HttpGet]
        public ActionResult<List<HeaderModel>> Get()
        {
            List<HeaderModel> response = new List<HeaderModel>
            {
                new HeaderModel()
                {
                    Title = "Priorities",
                    Sublinks = new string[]
                {
                    "Drive tech intensity",
                    "Earn trust every day",
                    "Ensure the responsible use of technology",
                    "Address the impact of technology"
                }
                },
                new HeaderModel()
                {
                    Title = "About",
                    Sublinks = new string[]
                {
                    "FAQ",
                }
                }
            };

            return response;
        }
    }
}
