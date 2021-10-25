using RestSharp;
using System;
using System.Collections.Generic;
using HotelApp.Models;

namespace HotelApp
{
    class Program
    {
        static readonly string API_URL = "http://localhost:3000/";
        static readonly RestClient client = new RestClient();

        static void Main(string[] args)
        {
            Run();
        }
        private static void Run()
        {
            Console.WriteLine("Welcome to Online Hotels! Please make a selection:");
            MenuSelection();
        }

        private static void MenuSelection()
        {
            int menuSelection = -1;
            while (menuSelection != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Menu:");
                Console.WriteLine("1: List Hotels");
                Console.WriteLine("2: List Reviews");
                Console.WriteLine("3: Show Details for Hotel ID 1");
                Console.WriteLine("4: List Reviews for Hotel ID 1");
                Console.WriteLine("5: List Hotels with star rating 3");
                Console.WriteLine("6: Public API Query");
                Console.WriteLine("0: Exit");
                Console.WriteLine("---------");
                Console.Write("Please choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out menuSelection))
                {
                    Console.WriteLine("Invalid input. Only input a number.");
                }
                else if (menuSelection == 1)
                {
                    PrintHotels(GetHotels());
                }
                else if (menuSelection == 2)
                {
                    PrintReviews(GetReviews());
                }
                else if (menuSelection == 3)
                {
                    PrintHotel(GetHotel());
                }
                else if (menuSelection == 4)
                {
                    PrintReviews(GetReviewsForHotel1());
                }
                else if (menuSelection == 5)
                {
                    Console.WriteLine("Not implemented");
                }
                else if (menuSelection == 6)
                {
                   PrintCity(GetCincinnati());
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                }
            }
        }


        //API methods:

        private static List<Hotel> GetHotels()
        {
            RestRequest request = new RestRequest(API_URL + "hotels");
            IRestResponse<List<Hotel>> response =  client.Get<List<Hotel>>(request);

            return response.Data;
        }
        private static Hotel GetHotel()
        {
            RestRequest request = new RestRequest(API_URL + "hotels/1");
            IRestResponse<Hotel> response = client.Get<Hotel>(request);

            return response.Data;
        }
        private static List<Review> GetReviews()
        {
            RestRequest request = new RestRequest(API_URL + "reviews");
            IRestResponse<List<Review>> response = client.Get<List<Review>>(request);

            return response.Data;
        }

        private static List<Review> GetReviewsForHotel1()
        {
            RestRequest request = new RestRequest(API_URL + "hotels/1/reviews");
            IRestResponse<List<Review>> response = client.Get<List<Review>>(request);

            return response.Data;
        }

        private static City GetCincinnati()
        {

            RestRequest request = new RestRequest("https://api.teleport.org/api/cities/geonameid:4508722/");
            IRestResponse<City> response = client.Get<City>(request);

            return response.Data;
            //https://api.teleport.org/api/cities/geonameid:4508722/
        }

        //Print methods:

        private static void PrintHotels(List<Hotel> hotels)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Hotels");
            Console.WriteLine("--------------------------------------------");
            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine(hotel.HotelID + ": " + hotel.Name); ;
            }
        }

        private static void PrintHotel(Hotel hotel)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Hotel Details");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" Id: " + hotel.HotelID);
            Console.WriteLine(" Name: " + hotel.Name);
            Console.WriteLine(" Stars: " + hotel.Stars);
            Console.WriteLine(" Rooms Available: " + hotel.RoomsAvailable);
            Console.WriteLine(" Cover Image: " + hotel.CoverImage);
        }

        private static void PrintReviews(List<Review> reviews)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Review Details");
            Console.WriteLine("--------------------------------------------");
            foreach (Review review in reviews)
            {
                Console.WriteLine(" Hotel ID: " + review.HotelID);
                Console.WriteLine(" Title: " + review.Title);
                Console.WriteLine(" Review: " + review.ReviewText);
                Console.WriteLine(" Author: " + review.Author);
                Console.WriteLine(" Stars: " + review.Stars);
                Console.WriteLine("---");
            }
        }



        private static void PrintCity(City city)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("City Details");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" Full Name: " + city.FullName);
            Console.WriteLine(" Geoname Id: " + city.GeonameId);
        }
    }
}
