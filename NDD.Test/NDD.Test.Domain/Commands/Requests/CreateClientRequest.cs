namespace NDD.Test.Domain.Commands.Requests
{
    public class CreateClientRequest
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Observation { get; set; }
    }
}
