using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular9Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular9Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tier1Controller : ControllerBase
    {
        private readonly string[] tier1Names = new string[] { "Drive tech intensity", "Earn trust every day", "Ensure the responsible use of technology", "Address the impact of technology" };
        private readonly string[][] tier2Names = new string[][]
        {
            new string[] {"Digital Transformation","Digital Stewardship","Open Data Initiative"},
            new string[] { "Privacy Operations and Policy", "Security Operations and Policy", "Digital Safety"},
            new string[] { "AI Governance Across Microsoft", "Responsible AI Around the World", "Facial Recognition"},
            new string[] { "Learning and the Future of Work", "Connectivity and Broadband Access", "TSI and the Non-Profit Community"},
        };
        [HttpGet]
        public ActionResult<Tier1Model> Get(string tier1Name = "")
        {
            var index = Array.FindIndex(tier1Names, t => t.ToLowerInvariant().Equals(tier1Name.ToLowerInvariant()));
            if (index == -1)
                return BadRequest(); 
            Random rnd = new Random();
            return new Tier1Model()
            {
                KeyResources = new KeyResourceModel[]
                {
                    new KeyResourceModel()
                    {
                        DocumentLink = "https://maqsoftware.com/",
                        LastModified = DateTime.Now.ToLongDateString(),
                        Type = rnd.Next(1, 4),
                        Title = "A sample document"
                    },
                    new KeyResourceModel()
                    {
                        DocumentLink = "https://maqsoftware.com/",
                        LastModified = DateTime.Now.ToLongDateString(),
                        Type = rnd.Next(1, 4),
                        Title = "A sample document"
                    },new KeyResourceModel()
                    {
                        DocumentLink = "https://maqsoftware.com/",
                        LastModified = DateTime.Now.ToLongDateString(),
                        Type = rnd.Next(1, 4),
                        Title = "A sample document"
                    },new KeyResourceModel()
                    {
                        DocumentLink = "https://maqsoftware.com/",
                        LastModified = DateTime.Now.ToLongDateString(),
                        Type = rnd.Next(1, 4),
                        Title = "A sample document"
                    },new KeyResourceModel()
                    {
                        DocumentLink = "https://maqsoftware.com/",
                        LastModified = DateTime.Now.ToLongDateString(),
                        Type = rnd.Next(1, 4),
                        Title = "A sample document"
                    },new KeyResourceModel()
                    {
                        DocumentLink = "https://maqsoftware.com/",
                        LastModified = DateTime.Now.ToLongDateString(),
                        Type = rnd.Next(1, 4),
                        Title = "A sample document"
                    },new KeyResourceModel()
                    {
                        DocumentLink = "https://maqsoftware.com/",
                        LastModified = DateTime.Now.ToLongDateString(),
                        Type = rnd.Next(1, 4),
                        Title = "A sample document"
                    },new KeyResourceModel()
                    {
                        DocumentLink = "https://maqsoftware.com/",
                        LastModified = DateTime.Now.ToLongDateString(),
                        Type = rnd.Next(1, 4),
                        Title = "A sample document"
                    },new KeyResourceModel()
                    {
                        DocumentLink = "https://maqsoftware.com/",
                        LastModified = DateTime.Now.ToLongDateString(),
                        Type = rnd.Next(1, 4),
                        Title = "A sample document"
                    },new KeyResourceModel()
                    {
                        DocumentLink = "https://maqsoftware.com/",
                        LastModified = DateTime.Now.ToLongDateString(),
                        Type = rnd.Next(1, 4),
                        Title = "A sample document"
                    }
                }.Take(rnd.Next(1, 10)).ToArray(),
                OverviewText = "",
                Title = tier1Names[index],
                Tier2Items = tier2Names[index]
            };
        }
    }
}