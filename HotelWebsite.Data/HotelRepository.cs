namespace HotelWebsite.Data
{
    public class HotelRepository
    {
        //A static list to simulate a database
        public static List<HotelRoomModel> HotelRooms = new List<HotelRoomModel>
        {
            new HotelRoomModel { RoomNumber = 101, RoomType = "Single", HasBalcony = false, PricePerDay = 150, IsVacant = true, BookedDaysLeft = null, PersonWhoBooked = null},
            new HotelRoomModel { RoomNumber = 102, RoomType = "Single", HasBalcony = false, PricePerDay = 150, IsVacant = false, BookedDaysLeft = 7, PersonWhoBooked = "Johnson"},
            new HotelRoomModel { RoomNumber = 103, RoomType = "Double", HasBalcony = false, PricePerDay = 250, IsVacant = false, BookedDaysLeft = 7, PersonWhoBooked = "Johnson"},
            new HotelRoomModel { RoomNumber = 104, RoomType = "Double", HasBalcony = false, PricePerDay = 250, IsVacant = true, BookedDaysLeft = null, PersonWhoBooked = null},
            new HotelRoomModel { RoomNumber = 105, RoomType = "Single", HasBalcony = false, PricePerDay = 150, IsVacant = true, BookedDaysLeft = null, PersonWhoBooked = null},
            new HotelRoomModel { RoomNumber = 201, RoomType = "Single", HasBalcony = true, PricePerDay = 200, IsVacant = false, BookedDaysLeft = 10, PersonWhoBooked = "Rodriguez"},
            new HotelRoomModel { RoomNumber = 202, RoomType = "Double", HasBalcony = false, PricePerDay = 300, IsVacant = true, BookedDaysLeft = null, PersonWhoBooked = null},
            new HotelRoomModel { RoomNumber = 203, RoomType = "Single", HasBalcony = true, PricePerDay = 200, IsVacant = true, BookedDaysLeft = null, PersonWhoBooked = null},
            new HotelRoomModel { RoomNumber = 204, RoomType = "Double", HasBalcony = false, PricePerDay = 300, IsVacant = false, BookedDaysLeft = 5, PersonWhoBooked = "Svensson"},
            new HotelRoomModel { RoomNumber = 205, RoomType = "Single", HasBalcony = true, PricePerDay = 200, IsVacant = false, BookedDaysLeft = 5, PersonWhoBooked = "Svensson"},
            new HotelRoomModel { RoomNumber = 301, RoomType = "Double", HasBalcony = true, PricePerDay = 400, IsVacant = true, BookedDaysLeft = null, PersonWhoBooked = null},
            new HotelRoomModel { RoomNumber = 302, RoomType = "Double", HasBalcony = true, PricePerDay = 400, IsVacant = false, BookedDaysLeft = 2, PersonWhoBooked = "Lindqvist"},
            new HotelRoomModel { RoomNumber = 303, RoomType = "Single", HasBalcony = true, PricePerDay = 350, IsVacant = true, BookedDaysLeft = null, PersonWhoBooked = null},
            new HotelRoomModel { RoomNumber = 304, RoomType = "King", HasBalcony = true, PricePerDay = 500, IsVacant = true, BookedDaysLeft = null, PersonWhoBooked = null},
            new HotelRoomModel { RoomNumber = 305, RoomType = "King", HasBalcony = true, PricePerDay = 500, IsVacant = false, BookedDaysLeft = 8, PersonWhoBooked = "Berg"},
            new HotelRoomModel { RoomNumber = 401, RoomType = "Penthouse", HasBalcony = true, PricePerDay = 1500, IsVacant = true, BookedDaysLeft = null, PersonWhoBooked = null}
        };
    }
}
