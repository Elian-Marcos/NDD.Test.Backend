namespace NDD.Test.Domain.Entities
{
    public class Client
    {
        public Client() { }
        public Client(string name, string cpf, string gender, string phoneNumber, string email, DateTime birthDate, string observation = "")
        {
            Id = Guid.NewGuid();
            Name = name;
            CPF = cpf;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Email = email;
            BirthDate = birthDate;
            Observation = observation;
        }

        public Guid Id { get; set; } 
        public string Name { get; set; } 
        public string CPF { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Observation { get; set; }

    }
}
