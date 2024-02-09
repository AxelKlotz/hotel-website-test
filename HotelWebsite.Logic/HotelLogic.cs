using HotelWebsite.Data;

namespace HotelWebsite.Logic
{
    public class HotelLogic
    {

        List<HotelRoomModel> hotelRooms = HotelRepository.HotelRooms;

        public List<HotelRoomModel> GetAllRooms()
        {
            return hotelRooms;
        }

        public HotelRoomModel GetSingleRoom(int roomNumber)
        {
            HotelRoomModel room = hotelRooms.First(r => r.RoomNumber == roomNumber);
            return room;
        }

        // Function to get a filtered list of the hotelrooms
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

        //Function that updates the HotelRooms list when a room is booked
        public void BookRoom(int roomNumber, int days, string occupantName)
        {
            var room = hotelRooms.First(r => r.RoomNumber == roomNumber);
            if (!room.IsVacant)
                throw new Exception("Selected room was not vacant");
            if (days <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
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
            if (price < 0 || price >= int.MaxValue)
                throw new ArgumentOutOfRangeException();

            return price;
        }
    }
}
