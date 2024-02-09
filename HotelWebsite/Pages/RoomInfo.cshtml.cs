using HotelWebsite.Data;
using HotelWebsite.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelWebsite.Pages
{
    public class RoomInfoModel : PageModel
    {
        HotelLogic logic = new();
        [BindProperty]
        public HotelRoomModel SelectedRoom { get; set; } = new();
        [BindProperty]
        public int DaysBooked { get; set; }
        [BindProperty]
        public string BookingName { get; set; }
        public int TotalCost { get; set; }

        public void OnGet(int room)
        {
            SelectedRoom = logic.GetSingleRoom(room);
        }
        public void OnPostCalculate(int room)
        {
            TotalCost = logic.CalculatePrice(SelectedRoom.RoomNumber, DaysBooked);
            SelectedRoom = logic.GetSingleRoom(room);
        }
        public IActionResult OnPostBookRoom()
        {
            logic.BookRoom(SelectedRoom.RoomNumber, DaysBooked, BookingName);
            return RedirectToPage("Index");
            //ToDo: Make it so you can't book a room zero or negative number of days in UI
        }
    }
}
