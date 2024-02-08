using HotelWebsite.Data;
using HotelWebsite.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelWebsite.Pages
{
    public class RoomInfoModel : PageModel
    {
        HotelLogic logic = new();
        public HotelRoomModel SelectedRoom { get; set; }
        [BindProperty]
        public int DaysBooked { get; set; }
        public int TotalCost { get; set; }
        public void OnGet(int room)
        {
            SelectedRoom = logic.GetSingleRoom(room);
        }
        public void OnPost() //Activates OnGet again when pressing calculate button
        {
            //Calculate price
            TotalCost = logic.CalculatePrice(SelectedRoom.RoomNumber, DaysBooked);
        }
    }
}
