namespace LAB_30.Models
{
    public class Grade
    {
        public int Id { get; set; }

        public string SubjectName { get; set; }
        
        public int Score { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }
    }
}
