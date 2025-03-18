namespace Authorization.Models.Dto
{
    public class AddCarDto
    {
        public required string Brand { get; set; }

        public required string Model { get; set; }
        public string? Description { get; set; }
    }
}
