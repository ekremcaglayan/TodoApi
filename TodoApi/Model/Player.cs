using TodoApi.Enum;

namespace TodoApi.Model
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int? ClubId { get; set; }
    }
}