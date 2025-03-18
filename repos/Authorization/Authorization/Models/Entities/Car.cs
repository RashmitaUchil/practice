namespace Authorization.Models.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public required string Brand { get; set; }

        public required string Model { get; set; }
        public string? Description { get; set; }
        
    }
}
