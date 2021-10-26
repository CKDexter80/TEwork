using RestSharp;
using System;
using System.Collections.Generic;
using AuctionApp.Models;

namespace AuctionApp
{
    public class ApiService
    {
        public const string API_URL = "http://localhost:3000/auctions";
        public IRestClient client;

        public ApiService()
        {
            client = new RestClient();
        }
        public ApiService(IRestClient restClient)
        {
            client = restClient;
        }

        public List<Auction> GetAllAuctions()
        {
            RestRequest request = new RestRequest(API_URL);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            HandleException(response);
            return response.Data;
            
        }

        public Auction GetDetailsForAuction(int auctionId)
        {
            RestRequest requestOne = new RestRequest(API_URL + "/" + auctionId);
            IRestResponse<Auction> response = client.Get<Auction>(requestOne);

            HandleException(response);
            return response.Data;
            
        }

        public List<Auction> GetAuctionsSearchTitle(string searchTitle)
        {
            RestRequest request = new RestRequest(API_URL + "?title_like=" + searchTitle);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            HandleException(response);
            return response.Data;
            
        }

        public List<Auction> GetAuctionsSearchPrice(double searchPrice)
        {
            RestRequest request = new RestRequest(API_URL + "?currentBid_lte=" + searchPrice);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            HandleException(response);
            return response.Data;
            
        }

        public Auction AddAuction(Auction newAuction)
        {
            RestRequest request = new RestRequest(API_URL);
            request.AddJsonBody(newAuction);

            IRestResponse<Auction> response = client.Post<Auction>(request);

            HandleException(response);
            return response.Data;
        }

        public Auction UpdateAuction(Auction auctionToUpdate)
        {
            RestRequest request = new RestRequest(API_URL + "/" + auctionToUpdate.Id);
            request.AddJsonBody(auctionToUpdate);

            IRestResponse<Auction> response = client.Put<Auction>(request);

            HandleException(response);
            return response.Data;
        }

        public bool DeleteAuction(int auctionId)
        {
            RestRequest request = new RestRequest(API_URL + "/" + auctionId);
            IRestResponse response = client.Delete(request);

            HandleException(response);
            return true;
        }

        private void HandleException(IRestResponse response)
        {
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception("Error occurred - unable to reach server.", response.ErrorException);
            }
            else if (!response.IsSuccessful)
            {
                throw new Exception("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
        }
    }
}
