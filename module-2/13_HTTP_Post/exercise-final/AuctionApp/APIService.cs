﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace AuctionApp
{
    public class APIService
    {
        const string API_URL = "http://localhost:3000/auctions";
        readonly IRestClient client;

        public APIService()
        {
            client = new RestClient();
        }
        public APIService(IRestClient restClient)
        {
            client = restClient;
        }

        public List<Auction> GetAllAuctions()
        {
            RestRequest request = new RestRequest(API_URL);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException();
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException();
            }
            else
            {
                return response.Data;
            }
        }

        public Auction GetDetailsForAuction(int auctionId)
        {
            RestRequest requestOne = new RestRequest(API_URL + "/" + auctionId);
            IRestResponse<Auction> response = client.Get<Auction>(requestOne);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException();
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException();
            }
            else
            {
                return response.Data;
            }
        }

        public List<Auction> GetAuctionsSearchTitle(string searchTitle)
        {
            RestRequest request = new RestRequest(API_URL + "?title_like=" + searchTitle);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException();
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException();
            }
            else
            {
                return response.Data;
            }
        }

        public List<Auction> GetAuctionsSearchPrice(double searchPrice)
        {
            RestRequest request = new RestRequest(API_URL + "?currentBid_lte=" + searchPrice);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException();
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException();
            }
            else
            {
                return response.Data;
            }
        }

        public Auction AddAuction(Auction newAuction)
        {
            RestRequest request = new RestRequest(API_URL);
            request.AddJsonBody(newAuction);

            IRestResponse<Auction> response = client.Post<Auction>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException();
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException();
            }
            else
            {
                return response.Data;
            }
        }

        public Auction UpdateAuction(Auction auctionToUpdate)
        {
            RestRequest request = new RestRequest(API_URL + "/" + auctionToUpdate.Id);
            request.AddJsonBody(auctionToUpdate);
            IRestResponse<Auction> response = client.Put<Auction>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException();
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException();
            }
            else
            {
                return response.Data;
            }
        }

        public bool DeleteAuction(int auctionId)
        {
            RestRequest request = new RestRequest(API_URL + "/" + auctionId);
            IRestResponse response = client.Delete(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException();
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException();
            }
            else
            {
                return true;
            }
        }
    }
}
