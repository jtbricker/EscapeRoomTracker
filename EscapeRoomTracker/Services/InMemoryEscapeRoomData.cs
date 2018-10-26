using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscapeRoomTracker.Models;

namespace EscapeRoomTracker.Services
{
    public class InMemoryEscapeRoomData : IEscapeRoomData
    {
        private List<EscapeRoom> _escapeRooms;

        public InMemoryEscapeRoomData()
        {
            _escapeRooms = new List<EscapeRoom>
            {
                new EscapeRoom{ Id = 1, Name = "Escape the Room: Time Bomb", City = "Gainesville, FL", Escaped = false},
                new EscapeRoom{ Id = 2, Name = "The Great Escape: Sherlocks Ghost", City = "Jacksonville, FL", Escaped = true},
                new EscapeRoom{ Id = 3, Name = "Escape Goat: Zombie Fight", City = "Miami, FL", Escaped = true}
            };
        }

        public EscapeRoom Add(EscapeRoom room)
        {
            room.Id = _escapeRooms.Max(r => r.Id) + 1;
            _escapeRooms.Add(room);
            return room;
        }

        public EscapeRoom Get(int id)
        {
            return _escapeRooms.SingleOrDefault( x => x.Id == id);
        }

        public IEnumerable<EscapeRoom> GetAll()
        {
            return _escapeRooms.OrderBy( x => x.City);
        }

        public EscapeRoom Update(EscapeRoom room)
        {
            var old = _escapeRooms.SingleOrDefault(x => x.Id == room.Id);

            _escapeRooms.Remove(old);
            _escapeRooms.Add(room);

            return room;
        }
    }
}
