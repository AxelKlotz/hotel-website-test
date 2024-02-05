using HotelWebsite.Logic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //Function tests for debugging
            HotelLogic logic = new HotelLogic();
            logic.BookRoom(101, 2, "Smith");
            logic.CalculatePrice(101, int.MaxValue);
        }
    }
}
