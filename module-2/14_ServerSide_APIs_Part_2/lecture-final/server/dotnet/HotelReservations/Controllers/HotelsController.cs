using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.DAO;

namespace HotelReservations.Controllers
{
    [Route("/")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private static IHotelDao hotelDao;
        private static IReservationDao reservationDao;

        public HotelsController(IHotelDao _hotelDao, IReservationDao _reservationDao)
        {
            hotelDao = _hotelDao;
            reservationDao = _reservationDao;
        }

        [HttpGet("hotels")]
        public List<Hotel> ListHotels()
        {
            return hotelDao.List();
        }

        [HttpGet("hotels/{id}")]
        public ActionResult<Hotel> GetHotel(int id)
        {
            Hotel hotel = hotelDao.Get(id);

            if (hotel != null)
            {
                return Ok(hotel);
            }
            else
            {
                //return null;
                return NotFound("this is not the thing ");
            }
        }

        [HttpGet("hotels/filter")]
        public List<Hotel> FilterByStateAndCity(string state, string city)
        {
            return hotelDao.FilterHotels(state, city);
        }

        [HttpGet("reservations")]
        public List<Reservation> ListReservations()
        {
            return reservationDao.List();
        }

        [HttpGet("reservations/{id}")]
        public ActionResult<Reservation> GetReservation(int id)
        {
            Reservation reservation = reservationDao.Get(id);

            if (reservation != null)
            {
                return reservation;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("hotels/{hotelId}/reservations")]
        public ActionResult<List<Reservation>> ListReservationsByHotel(int hotelId)
        {
            Hotel hotel = hotelDao.Get(hotelId);
            if (hotel == null)
            {
                return NotFound("Hotel Id is invalid");
            }
            return reservationDao.FindByHotel(hotelId);
        }

        [HttpPost("reservations")]
        public ActionResult<Reservation> AddReservation(Reservation reservation)
        {
            Reservation added = reservationDao.Create(reservation);
            return Created($"/reservations/{added.Id}", added);
        }

        [HttpPut("reservations/{id}")]
        public ActionResult<Reservation> UpdateReservation(int id, Reservation reservation)
        {
            Reservation reservationExists = reservationDao.Get(id);

            if (reservationExists == null)
            {
                return NotFound();
            } 

            return Ok(reservationDao.Update(id,reservation));

        }

        [HttpDelete("reservations/{id}")]
        public ActionResult DeleteReservation(int id)
        {

            bool successfullyDeleted = reservationDao.Delete(id);

            if (successfullyDeleted == true)
            {
               return NoContent();
            }
            else
            {
                return NotFound("Reservation Does Not Exist");
            }
        }
    }
}
