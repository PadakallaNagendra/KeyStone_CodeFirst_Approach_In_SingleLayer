using KeyStone_CodeFirst_Approach_In_SingleLayer.Entities;

namespace KeyStone_CodeFirst_Approach_In_SingleLayer.InterFace
{
    public interface IRoomRepositary
    {
        Task<List<Room>> GetAllRoomTypes();
        Task<Room> GetAllRoomsById(int id);
        Task<bool> AddRoomTypes(Room room);
        Task<bool> DeleteRoomTypes(int id);
        Task<bool> UpdateRoomTypes(Room room);

    }
}
