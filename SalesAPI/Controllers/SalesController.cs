﻿using SalesAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Newtonsoft.Json;


namespace SalesAPI.Controllers
{
    public class SalesController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class ListingController : ControllerBase
        {
            // GET api/<ValuesController>/5
            [HttpGet("{id}")]
            public SalesInterface Get(int id)
            {
                //Testing Get
                List<SalesInterface> listings = new List<SalesInterface>();

                for (int i = 0; i < 10; i++)
                {
                    listings.Add(new SalesInterface()
                    {
                        UserID = Guid.NewGuid(),
                        Title = $"Title for {id}",
                        ContactInfo = i.ToString(),
                        Description = $"Description for {id}",
                        Images = new List<string>() { "Image1" },
                        ListingTime = DateTime.Now.AddDays(i),
                        Location = DateTime.Now.AddDays(i).DayOfWeek.ToString()
                    });
                }

                // If Id isn't found
                SalesInterface def = new SalesInterface()
                {
                    UserID = new Guid(),
                    Title = $"ID {id} NOT FOUND",
                    Description = string.Empty,
                    Images = new(),
                    ListingTime = DateTime.MinValue,
                    Location = string.Empty,
                    ContactInfo = string.Empty
                };

                return listings.FirstOrDefault(l => l.ContactInfo == id.ToString()) ?? def;
            }

            // POST api/<ValuesController>
            [HttpPost]
            public void Post([FromBody] SalesInterface post)
            {
                Debug.WriteLine(JsonConvert.SerializeObject(post));
            }

            // PUT api/<ValuesController>/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] string value)
            {

            }

            // DELETE api/<ValuesController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {

            }
        }
    }
}