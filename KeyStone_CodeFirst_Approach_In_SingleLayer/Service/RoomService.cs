using KeyStone_CodeFirst_Approach_In_SingleLayer.Entities;
using KeyStone_CodeFirst_Approach_In_SingleLayer.InterFace;
using KeyStone_CodeFirst_Approach_In_SingleLayer.ModelDTO;

namespace KeyStone_CodeFirst_Approach_In_SingleLayer.Service
{
    public class RoomService : IRoomService
    {
        IRoomRepositary _roomRepositary;
        public RoomService(IRoomRepositary roomRepositary)
        {
            _roomRepositary = roomRepositary;
        }
       
        public Task<bool> AddRoomTypes(RoomDTO roomDto)
        {
            Room rm=new Room();
            rm.id= roomDto.id;
            rm.checkIn= roomDto.checkIn;
            rm.checkOut= roomDto.checkOut;  
            rm.price= roomDto.price;
            rm.maxPersons= roomDto.maxPersons;
            rm.vat= roomDto.vat;
            rm.roomTypeName= roomDto.roomTypeName;
           var res= _roomRepositary.AddRoomTypes(rm);
            return res;
        }

        public async Task<bool> DeleteRoomTypes(int id)
        {
           await _roomRepositary.DeleteRoomTypes(id);
            return true;
        }

        public async Task<RoomDTO> GetAllRoomsById(int id)
        {
            var res= await _roomRepositary.GetAllRoomsById(id);
            RoomDTO obj=new RoomDTO();
            obj.id = res.id;
            obj.checkIn = res.checkIn;
            obj.checkOut= res.checkOut;
            obj.price= res.price;
            obj.maxPersons = res.maxPersons;
            obj.vat= res.vat;
            obj.roomTypeName= res.roomTypeName;
            return obj;
        }
       

        public async Task<List<RoomDTO>> GetAllRoomTypes()
        {
            List<RoomDTO> lstrmdto = new List<RoomDTO>();
            var res = await _roomRepositary.GetAllRoomTypes();
            foreach (Room rm in res)
            {
                RoomDTO rmdto = new RoomDTO();
                rmdto.id = rm.id;
                rmdto.price = rm.price;
                rmdto.checkOut = rm.checkOut;
                rmdto.checkIn = rm.checkIn;
                rmdto.vat = rm.vat;
                rmdto.maxPersons = rm.maxPersons;
                rmdto.roomTypeName = rm.roomTypeName;
                lstrmdto.Add(rmdto);

            }
            return lstrmdto;
        }

        public  async Task<bool> UpdateRoomTypes(RoomDTO roomDto)
        {
            Room rm = new Room();
            rm.id = roomDto.id;
            rm.price = roomDto.price;
            rm.maxPersons = roomDto.maxPersons;
            rm.vat = roomDto.vat;
            rm.checkOut = roomDto.checkOut;
            rm.checkIn = roomDto.checkIn;
            rm.roomTypeName = roomDto.roomTypeName;
            await _roomRepositary.UpdateRoomTypes(rm);
            return true;
        }
    }
}
