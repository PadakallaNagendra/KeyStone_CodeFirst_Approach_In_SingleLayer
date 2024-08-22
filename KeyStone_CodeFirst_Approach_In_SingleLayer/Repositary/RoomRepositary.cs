using KeyStone_CodeFirst_Approach_In_SingleLayer.DbConnect;
using KeyStone_CodeFirst_Approach_In_SingleLayer.Entities;
using KeyStone_CodeFirst_Approach_In_SingleLayer.InterFace;
using Microsoft.EntityFrameworkCore;

namespace KeyStone_CodeFirst_Approach_In_SingleLayer.Repositary
{
    public class RoomRepositary : IRoomRepositary
    {
        public HotelRoomContext _hotelRoomContext;
        public RoomRepositary(HotelRoomContext hotelRoomContext)
        {
            _hotelRoomContext = hotelRoomContext;
        }

        public async Task<bool> AddRoomTypes(Room room)
        {
            await _hotelRoomContext.rooms.AddAsync(room);
            _hotelRoomContext.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteRoomTypes(int id)
        {
           var a=_hotelRoomContext.rooms.SingleOrDefault(e => e.id == id);
            if(a!= null)
            {
                 _hotelRoomContext.rooms.Remove(a);
                _hotelRoomContext.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public Task<Room> GetAllRoomsById(int id)
        {
            var a = _hotelRoomContext.rooms.Where(e => e.id == id).FirstOrDefaultAsync();
            if(a!= null)
            {
                return a;
            }
            return null;
        }

        public async Task<List<Room>> GetAllRoomTypes()
        {
            var a = _hotelRoomContext.rooms.ToList();
            if (a.Count == 0)
            {
                return null;
            }
            else
            {
                return a;
            }
            
        }

        public async Task<bool> UpdateRoomTypes(Room room)
        {
            _hotelRoomContext.rooms.Update(room);
           await _hotelRoomContext.SaveChangesAsync();

            return true;
        }
    }
}
