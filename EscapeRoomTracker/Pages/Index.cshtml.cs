using System.Collections.Generic;
using EscapeRoomTracker.Models;
using EscapeRoomTracker.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscapeRoomTracker.Pages
{
    public class HomeModel : PageModel
    {
        private IEscapeRoomData _escapeRoomData;
        public IEnumerable<EscapeRoom> EscapeRooms;

        public HomeModel(IEscapeRoomData escapeRoomData)
        {
            _escapeRoomData = escapeRoomData;
        }

        public IActionResult OnGet()
        {
            EscapeRooms = _escapeRoomData.GetAll();
            return Page();
        }
    }
}