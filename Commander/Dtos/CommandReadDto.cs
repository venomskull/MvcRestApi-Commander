
namespace Commander.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }

        public string HowTo { get; set; }   

        public string Line { get; set; }

        // This property is going to hide from the client.
        // public string Platform { get; set; }
    }
}