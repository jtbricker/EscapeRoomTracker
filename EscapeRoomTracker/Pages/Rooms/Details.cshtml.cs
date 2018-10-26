using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscapeRoomTracker.Models;
using EscapeRoomTracker.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscapeRoomTracker.Pages.Rooms
{
    public class DetailsModel : PageModel
    {
        private IEscapeRoomData _escapeRoomData;
        public EscapeRoom Room;

        public DetailsModel(IEscapeRoomData escapeRoomData)
        {
            _escapeRoomData = escapeRoomData;
        }

        public void OnGet(int id)
        {
            Room = _escapeRoomData.Get(id);
        }
    }
}