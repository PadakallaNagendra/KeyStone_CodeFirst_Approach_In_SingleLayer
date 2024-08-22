using KeyStone_CodeFirst_Approach_In_SingleLayer.InterFace;
using KeyStone_CodeFirst_Approach_In_SingleLayer.ModelDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KeyStone_CodeFirst_Approach_In_SingleLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        IRoomService _rmtServices;
        public RoomController(IRoomService rmtServices)
        {
            _rmtServices = rmtServices;
        }
        [HttpPost]
        [Route("AddRoomTypes")]
        public async Task<IActionResult> post([FromBody] RoomDTO rmdetail)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, ModelState);
                }
                else
                {
                    var rmdata = await _rmtServices.AddRoomTypes(rmdetail);
                    return StatusCode(StatusCodes.Status200OK, "room added sucessfully");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "serever not found");
            }
        }
        [HttpDelete]
        [Route("DeleteRoomTypesById/{id}")]
        public async Task<IActionResult> delete(int id)
        {
            if (id < 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "bad request");
            }
            try
            {
                var rmdata = await _rmtServices.DeleteRoomTypes(id);
                if (rmdata == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, "roomid not found");
                }
                else
                {
                    return StatusCode(StatusCodes.Status204NoContent, "roomid deleted");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "serever not found");
            }
        }
        [HttpGet]
        [Route("GetAllRoomTypes")]
        public async Task<IActionResult> GetAllRoomTypes()
        {
            try
            {
                var rmdata = await _rmtServices.GetAllRoomTypes();
                if (rmdata == null)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "bad request");
                }
                else
                {
                    return StatusCode(StatusCodes.Status200OK, rmdata);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "server not found");
            }

        }
        [HttpGet]
        [Route("GetAllRoomsById/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id < 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "bad request");
            }
            try
            {
                var rmdata = await _rmtServices.GetAllRoomsById(id);
                return StatusCode(StatusCodes.Status200OK, rmdata);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "server eror");
            }
        }
        [HttpPut]
        [Route("UpdateRoomTypes")]
        public async Task<IActionResult> put([FromBody] RoomDTO rmdto)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    return StatusCode(StatusCodes.Status400BadRequest, ModelState);
                }
                else
                {
                    var rmdata = await _rmtServices.UpdateRoomTypes(rmdto);
                    return StatusCode(StatusCodes.Status202Accepted, rmdata);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "server not found");
            }
        }
    }
}
