using HotelWebsite.Data;

namespace HotelWebsite.Logic
{
    public class HotelLogic
    {

        List<HotelRoomModel> hotelRooms = HotelRepository.HotelRooms;

        public List<HotelRoomModel> GetRooms()
        {
            return hotelRooms;
        }

        //Function that updates the HotelRooms list when a room is booked
        public void BookRoom(int roomNumber, int days)
        {
            var room = hotelRooms.First(r => r.RoomNumber == roomNumber);
            if (!room.IsVacant)
                throw new Exception("Selected room was not vacant");
            room.IsVacant = false;
            room.BookedDaysLeft = days;
        }

        //Function to calculate the booking price of a room based on the number of days
        public int CalculatePrice(int roomNumber, int days)
        {
            var room = hotelRooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
            return room.PricePerDay * days;
        }
    }
}
