using EscapeRoomTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscapeRoomTracker.Services
{
    public interface IEscapeRoomData
    {
        IEnumerable<EscapeRoom> GetAll();
        EscapeRoom Add(EscapeRoom room);
        EscapeRoom Get(int id);
        EscapeRoom Update(EscapeRoom room);
    }
}
