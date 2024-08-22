using KeyStone_CodeFirst_Approach_In_SingleLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace KeyStone_CodeFirst_Approach_In_SingleLayer.DbConnect
{
    public class HotelRoomContext:DbContext
    {
        public HotelRoomContext(DbContextOptions<HotelRoomContext> options)
        : base(options)
        {
        }

        public DbSet<Room> rooms { get; set; }
    }
}
