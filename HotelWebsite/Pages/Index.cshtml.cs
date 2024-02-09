using HotelWebsite.Data;
using HotelWebsite.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public string Filter { get; set; }
        [BindProperty]
        public string VacancyChoice { get; set; }
        [BindProperty]
        public string RoomChoice { get; set; }
        [BindProperty]
        public string BalconyChoice { get; set; }
        public string FilterChoice { get; set; }
        public HotelLogic Logic { get; set; } = new HotelLogic();
        [BindProperty]
        public List<HotelRoomModel> Rooms { get; set; } = new();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            Rooms = Logic.GetAllRooms();
        }
        public void OnPostFilter()
        {
            if (Filter.Equals("IsVacant"))
                FilterChoice = VacancyChoice;

            else if (Filter.Equals("RoomType"))
                FilterChoice = RoomChoice;

            else if (Filter.Equals("HasBalcony"))
                FilterChoice = BalconyChoice;
            else
            {
                throw new ArgumentException();
            }
            Rooms = Logic.GetFilteredList(Filter, FilterChoice);
        }
    }
}
