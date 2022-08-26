using FreddinhoWebApi.Interfaces;

namespace FreddinhoWebApi.Models.Entity
{
    public class Account : IAccount
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public long CellphoneNumber { get; set; }

        public char? Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }


        public ICollection<Dependent>? Dependents { get; set; }
    }
}