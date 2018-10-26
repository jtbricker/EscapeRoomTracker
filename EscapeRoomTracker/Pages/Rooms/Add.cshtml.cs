﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscapeRoomTracker.Models;
using EscapeRoomTracker.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscapeRoomTracker.Pages.Rooms
{
    public class AddModel : PageModel
    {
        private IEscapeRoomData _escapeRoomData;

        [BindProperty]
        public EscapeRoom Room{ get; set; }

        public AddModel(IEscapeRoomData escapeRoomData)
        {
            _escapeRoomData = escapeRoomData;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Room = _escapeRoomData.Add(Room);
                return RedirectToPage("/Rooms/Details", new { id = Room.Id });
            }
            return Page();
        }
    }
}