using FreddinhoWebApi.Interfaces;

namespace FreddinhoWebApi.Models.Entity
{
    public class Dependent
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public char Gender { get; set; }

        public int BirthYear { get; set; }


        public int AccountModelId { get; set; }
        public EntityAccount? AccountModel { get; set; }
    }
}