namespace clinic.Entities
{
    public class RoutesClass
    {
        public DateTime date;
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public int idPatient { get; set; }
        public int idDoctor { get; set; }

    }
}
