using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscapeRoomTracker.Models;
using EscapeRoomTracker.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscapeRoomTracker.Pages.Rooms
{
    [Authorize]
    public class EditModel : PageModel
    {
        private IEscapeRoomData _escapeRoomData;

        [BindProperty]
        public EscapeRoom Room { get; set; }

        public EditModel(IEscapeRoomData escapeRoomData)
        {
            _escapeRoomData = escapeRoomData;
        }

        public void OnGet(int id)
        {
            Room = _escapeRoomData.Get(id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Room = _escapeRoomData.Update(Room);
                return RedirectToPage("/Rooms/Details", new { id = Room.Id });
            }
            return Page();
        }
    }
}