using FreddinhoWebApi.Models.Mocks;

namespace FreddinhoWebApi.Models.Entity
{
    public class PayHistoricModel
    {
        public int Id { get; set; }

        public float Values { get; set; }

        public DateTime PayDay { get; set; }


        public int PatientId { get; set; }

        public ICollection<PatientModel>? Patient { get; set; }

        public int PsychologistId { get; set; }

        public ICollection<PsychologistModel>? Psychologist { get; set; }
    }
}