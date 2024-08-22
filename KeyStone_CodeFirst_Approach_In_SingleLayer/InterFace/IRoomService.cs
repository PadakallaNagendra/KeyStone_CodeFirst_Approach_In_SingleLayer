using KeyStone_CodeFirst_Approach_In_SingleLayer.ModelDTO;

namespace KeyStone_CodeFirst_Approach_In_SingleLayer.InterFace
{
    public interface IRoomService
    {
        Task<List<RoomDTO>> GetAllRoomTypes();
        Task<RoomDTO> GetAllRoomsById(int id);
        Task<bool> AddRoomTypes(RoomDTO roomDto);
        Task<bool> DeleteRoomTypes(int id);
        Task<bool> UpdateRoomTypes(RoomDTO roomDto);

    }
}
