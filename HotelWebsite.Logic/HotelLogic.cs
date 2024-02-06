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
        public HotelRoomModel GetSingleRoom(int roomNumber)
        {
            HotelRoomModel room = hotelRooms.First(r => r.RoomNumber == roomNumber);
            return room;
        }

        //ToDo: Function to get list of rooms of a certain type using Where()
        public List<HotelRoomModel> GetFilteredList(string attribute, string attributeValue)
        {
            List<HotelRoomModel> filteredList = new();
            switch (attribute) // Switch case to see what attribute to filter by
            {
                case "IsVacant":
                    filteredList = hotelRooms.Where(r => r.IsVacant == Convert.ToBoolean(attributeValue)).ToList();
                    break;
                case "RoomType":
                    filteredList = hotelRooms.Where(r => r.RoomType.Equals(attributeValue)).ToList();
                    if (filteredList.Count < 1)
                        throw new ArgumentException("Selected Room Type does not exist");
                    break;
                case "HasBalcony":
                    filteredList = hotelRooms.Where(r => r.HasBalcony == Convert.ToBoolean(attributeValue)).ToList();
                    break;
                default: throw new ArgumentException();
            }
            return filteredList;
        }

        //ToDo: Function to cancel a booking

        //Function that updates the HotelRooms list when a room is booked
        public void BookRoom(int roomNumber, int days, string occupantName)
        {
            var room = hotelRooms.First(r => r.RoomNumber == roomNumber);
            if (!room.IsVacant)
                throw new Exception("Selected room was not vacant");
            if (string.IsNullOrWhiteSpace(occupantName))
                throw new ArgumentException();
            // Update list with new booking
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
