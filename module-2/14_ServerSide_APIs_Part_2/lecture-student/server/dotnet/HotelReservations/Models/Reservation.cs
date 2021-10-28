﻿using System;
using System.ComponentModel.DataAnnotations;

namespace HotelReservations.Models
{
    public class Reservation
    {
        public int? Id { get; set; }
        [Required]
        public int HotelId { get; set; }
        [Required(ErrorMessage = "Enter Your Name")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Check-in Date Required")]
        public string CheckinDate { get; set; }
        [Required(ErrorMessage = "Check-out Date Required")]
        public string CheckoutDate { get; set; }
        [Range(1, 6)]
        public int Guests { get; set; }

        public Reservation()
        {
            //must have parameterless constructor to deserialize
        }

        public Reservation(int? id, int hotelId, string fullName, string checkinDate, string checkoutDate, int guests)
        {
            Id = id ?? new Random().Next(100, int.MaxValue);
            HotelId = hotelId;
            FullName = fullName;
            CheckinDate = checkinDate;
            CheckoutDate = checkoutDate;
            Guests = guests;
        }
    }
}
