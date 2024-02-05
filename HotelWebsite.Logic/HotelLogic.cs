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

        //ToDo: Function to get a single room

        //ToDo: Function to get list of rooms of a certain type using Where()

        //Function that updates the HotelRooms list when a room is booked
        public void BookRoom(int roomNumber, int days, string occupantName)
        {
            var room = hotelRooms.First(r => r.RoomNumber == roomNumber);
            if (!room.IsVacant)
                throw new Exception("Selected room was not vacant");
            room.IsVacant = false;
            room.PersonWhoBooked = occupantName;
            room.BookedDaysLeft = days;
        }

        //Function to calculate the booking price of a room based on the number of days
        public int CalculatePrice(int roomNumber, int days)
        {
            var room = hotelRooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
            int price = room.PricePerDay * days;
            if (price <= 0 || price >= int.MaxValue)
                throw new ArgumentOutOfRangeException();

            return price;
        }
    }
}
