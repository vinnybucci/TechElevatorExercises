using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;
using System.Reflection.Metadata;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionDao();
            }
            else
            {
                dao = auctionDao;
            }
        }
        
        [HttpGet("{id}")]
        public Auction GetAuctionsId(int id)
        {
            Auction auction = dao.Get(id);
            if (auction != null)
            {
            return auction;

            }
            return null;
        }
        [HttpGet]
        public List<Auction> SearchTitle(string title_like = "")
        {
            List<Auction> output = dao.SearchByTitle(title_like);
            return output;
            

        }
        //[HttpGet]
        //public List<Auction> SearchPrice(double currentBid_lte = 0)
        //{
        //    List<Auction> output = dao.SearchByPrice(currentBid_lte);
        //    return output;

        //}
        [HttpPost]
        public Auction PostAuctions(Auction auction)
        {
            Auction output = dao.Create(auction);
            return output;
        }

    }
}
