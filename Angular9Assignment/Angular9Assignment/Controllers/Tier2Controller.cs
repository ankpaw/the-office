using Angular9Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Angular9Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tier2Controller : ControllerBase
    {
        private readonly string[] tier2Names = new string[] { "Digital Transformation", "Digital Stewardship", "Open Data Initiative", "Privacy Operations and Policy", "Security Operations and Policy", "Digital Safety", "AI Governance Across Microsoft", "Responsible AI Around the World", "Facial Recognition", "Learning and the Future of Work", "Connectivity and Broadband Access", "TSI and the Non-Profit Community" };

        [HttpGet]
        public ActionResult<Tier2Model> Get(string tier2Name = "")
        {
            var index = Array.FindIndex(tier2Names, t => t.Equals(tier2Name));
            if (index == -1)
                return BadRequest();
            Random rnd = new Random();
            int columns = rnd.Next(2, 7);
            ProgramCards[] cards = new ProgramCards[columns];
            string[] columnHeaders = new string[columns + 1];
            columnHeaders[0] = "Region";
            for (int i = 1; i <= columns; i++)
            {
                cards[i - 1] = new ProgramCards() { Title = $"Card-{i}", Value = $"{rnd.Next(1, 9999999)}", Unit = "Millions of units", Descrioption = rnd.Next(1, 7) % 2 != 0 ? "A special description for this card" : string.Empty };
                columnHeaders[i] = $"{tier2Name} | Column-{i}";
            };

            var data = GetData(columns);


            Tier2Model response = new Tier2Model()
            {
                Title = tier2Names[index],
                ProgramCards = cards,
                DataTable = new DataTableModel()
                {
                    Headers = columnHeaders,
                    Data = data
                },
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
                }.Take(rnd.Next(1, 10)).ToArray()
            };

            return response;
        }

        private string[][] GetData(int count)
        {
            List<string[]> result = new List<string[]>();
            string[][] valueSet = new string[][]
                {
                    new string [] {"$56,718,484.40", "$50,727,048.50","$23,248,823.90","$42,880,587","$46,602,538.50","$11,989,444.60","$6,707,278.70","$4,265,296.20","$27,767,885.50","$20,450,394.60","$86,348,822.20","$402,083,570.40","$105,749,016.40","$14,842,793.40" },
                    new string []{"$694,100","$2,245,000","$750,000","$831,250","$525,000","$185,000","$475,000","$720,000","$1,061,756.40","$1,544,033","$513,192.70","$37,332,448.40","$1,188,000","$1,188,000" ,"$3,052,762.40"},
                    new string [] { "14,276", "15,223", "7,050", "9,263", "15,304", "2,036", "1,239", "2,264", "4,885", "4,445", "24,636", "141,836", "26,601", "2,694" },
                    new string [] { "$56,718,484.40", "$50,727,048.50", "$23,248,823.90", "$42,880,587", "$46,602,538.50", "$11,989,444.60", "$6,707,278.70", "$4,265,296.20", "$27,767,885.50", "$20,450,394.60", "$86,348,822.20", "$402,083,570.40", "$105,749,016.40", "$14,842,793.40" },
                    new string []{"3","0","1","0","0","0","2","4","1","1","0","9","11","22",},
                    new string []{"2","0","1","0","1","0","4","8","1","1","1","3","1","7",}
                };
            result.Add(new string[] {"Asia Pacific (APAC)","Australia and New Zealand (ANZ)","Canada","Central and Eastern Europe (CEE)","France","Germany","Greater China","India","Japan","Latin America (LATAM)","Middle East and Africa (MEA)","United Kingdom","United States","Western Europe (WE)",});
            while (count > 1)
            {
                // Create a Random object  
                Random rand = new Random();
                // Generate a random index less than the size of the array.  
                int index = rand.Next(valueSet.Length);
                result.Add(valueSet[index]);
                count--;
            }
            return result.ToArray();
        }
    }
}
