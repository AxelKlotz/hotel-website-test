using HotelWebsite.Logic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string FilterAttribute { get; set; }
        public HotelLogic Logic { get; set; } = new HotelLogic();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //ToDo: Show correct dropdown menu after picking filter
        }
    }
}
