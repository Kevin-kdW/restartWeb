namespace API.Models
{
    public class SockManufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Location { get; set; } = default!;
        public int MyProperty { get; set; }

        public int SockId { get; set; }
    }
}