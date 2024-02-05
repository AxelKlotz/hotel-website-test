namespace HotelWebsite.Data
{
    public class HotelRoomModel
    {
        public int RoomNumber { get; set; }
        public bool IsVacant { get; set; }
        public int PricePerDay { get; set; }
        public string RoomType { get; set; }
        public bool HasBalcony { get; set; }
        public int? BookedDaysLeft { get; set; }
        public string? PersonWhoBooked { get; set; }

    }
}
