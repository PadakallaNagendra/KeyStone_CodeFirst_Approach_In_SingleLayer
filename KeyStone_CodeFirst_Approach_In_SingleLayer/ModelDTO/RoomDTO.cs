namespace KeyStone_CodeFirst_Approach_In_SingleLayer.ModelDTO
{
    public class RoomDTO
    {
        public int id { get; set; }
        public string roomTypeName { get; set; }
        public int price { get; set; }
        public int vat { get; set; }
        public int maxPersons { get; set; }
        public string checkOut { get; set; }
        public string checkIn { get; set; }
    }
}
