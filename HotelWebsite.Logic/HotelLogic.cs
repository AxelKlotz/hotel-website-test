using HotelWebsite.Data;

namespace HotelWebsite.Logic
{
    public class HotelLogic
    {
        public static List<HotelRoomModel> HotelRooms = new List<HotelRoomModel>
        {
            new HotelRoomModel { RoomNumber = 101, RoomType = "Single", PricePerDay = 150, IsVacant = true, BookedDaysLeft = null},
            new HotelRoomModel { RoomNumber = 102, RoomType = "Single", PricePerDay = 150, IsVacant = false, BookedDaysLeft = 7},
            new HotelRoomModel { RoomNumber = 103, RoomType = "Double", PricePerDay = 250, IsVacant = false, BookedDaysLeft = 3},
            new HotelRoomModel { RoomNumber = 104, RoomType = "Double", PricePerDay = 250, IsVacant = true, BookedDaysLeft = null},
            new HotelRoomModel { RoomNumber = 105, RoomType = "Single", PricePerDay = 150, IsVacant = true, BookedDaysLeft = null},
            new HotelRoomModel { RoomNumber = 201, RoomType = "Single", PricePerDay = 200, IsVacant = false, BookedDaysLeft = 10},
            new HotelRoomModel { RoomNumber = 202, RoomType = "Double", PricePerDay = 300, IsVacant = true, BookedDaysLeft = null},
            new HotelRoomModel { RoomNumber = 203, RoomType = "Single", PricePerDay = 200, IsVacant = true, BookedDaysLeft = null},
            new HotelRoomModel { RoomNumber = 204, RoomType = "Double", PricePerDay = 300, IsVacant = false, BookedDaysLeft = 5},
            new HotelRoomModel { RoomNumber = 205, RoomType = "Single", PricePerDay = 200, IsVacant = false, BookedDaysLeft = 5},
            new HotelRoomModel { RoomNumber = 301, RoomType = "Penthouse", PricePerDay = 500, IsVacant = true, BookedDaysLeft = null}
        };

        public List<HotelRoomModel> GetRooms()
        {
            return HotelRooms;
        }
    }
}
