using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.DAO;

namespace HotelReservations.Controllers
{
    [Route("/")]
    [ApiController]//VERY IMPORTANT!!
    public class HotelsController : ControllerBase
    {
        private static IHotelDao _hotelDao;
        private static IReservationDao _reservationDao;

        public HotelsController()
        {
            _hotelDao = new HotelDao();
            _reservationDao = new ReservationDao();
        }

        [HttpGet("hotels")]//GET request for /hotels maps to this method
        public List<Hotel> ListHotels()
        {
            return _hotelDao.List();
        }
        //hotels/1
        [HttpGet("hotels/{id}")]
        public Hotel GetHotel(int id)
        {
            Hotel hotel = _hotelDao.Get(id);

            if (hotel != null)
            {
                return hotel;
            }

            return null;
        }

        [HttpGet("reservations")]
        public List<Reservation> ListReservations()
        {
            return _reservationDao.List();
        }

        [HttpGet("reservations/{id}")]
        public Reservation ListReservationId(int id)
        {
            return _reservationDao.Get(id);
        }

        [HttpGet("hotels/{hotelId}/reservations")]
        public List<Reservation> ListReservationsByHotelId(int hotelId)
        {
            return _reservationDao.FindByHotel(hotelId);
        }

        [HttpPost("reservations")]
        public Reservation CreateReservation(Reservation reservation)
        {
            return _reservationDao.Create(reservation);
        }

        //hotels/filter?state=OH

        [HttpGet("hotels/filter")]
        public List<Hotel> GetHotelsByState(string state, string city)
        {
            return null;
        }

    }
}
