namespace FreddinhoWebApi.Interfaces
{
    public interface IAccount
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public char? Gender { get; set; }
    }
}