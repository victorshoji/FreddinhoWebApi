namespace FreddinhoWebApi.Models.Entity
{
    public class PatientModel : AccountModel
    {
        public int PsychologistId { get; set; }

        public ICollection<PsychologistModel>? Psychologist { get; set; }

        public int PlainId { get; set; }

        public ICollection<PlainModel>? Plain { get; set; }
    }
}