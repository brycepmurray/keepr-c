using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using card_c.Models;
using card_c.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace card_c.Controllers
{

    [Route("api/[controller]")]
    public class CardController : Controller
    {
        private readonly CardRepository db;
        public CardsController(CardRepository cardRepo)
        {
            db = cardRepo;
        }
        [HttpGet]

      
       [HttpGet("{id}")]
       public Card Get(int id)
       {
           return db.GetById(id);
       }

      
       [HttpPost]
       public Card Post([FromBody]Card card)
       {
           return db.Add(card);
       }

      
       [HttpPut("{id}")]
       public Card Put(int id, [FromBody]Card card)
       {
           if (ModelState.IsValid)
           {
               return db.GetOneByIdAndUpdate(id, card);
           }
           return null;
       }

       
       [HttpDelete("{id}")]
       public string Delete(int id)
       {
           return db.FindByIdAndRemove(id);
       }
    }
}