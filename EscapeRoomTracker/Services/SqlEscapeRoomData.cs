using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscapeRoomTracker.Data;
using EscapeRoomTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace EscapeRoomTracker.Services
{
    public class SqlEscapeRoomData : IEscapeRoomData
    {
        private EscapeRoomTrackerDbContext _context;

        public SqlEscapeRoomData(EscapeRoomTrackerDbContext context)
        {
            _context = context;
        }

        public EscapeRoom Add(EscapeRoom room)
        {
            _context.EscapeRooms.Add(room);
            _context.SaveChanges();

            return room;
        }

        public EscapeRoom Get(int id)
        {
            return _context.EscapeRooms.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<EscapeRoom> GetAll()
        {
            return _context.EscapeRooms.OrderBy(r => r.Name);
        }

        public EscapeRoom Update(EscapeRoom room)
        {
            _context.Attach(room).State = EntityState.Modified;
            _context.SaveChanges();
            return room;
        }
    }
}
