namespace Trainning.Core.Entities
{
    public class StudentInClass
    {
        public int StudentId { get; set; }
        public Student Students { get; set; } 

        public int ClassId { get;set; }

        public Class Classes { get; set; }

    }
}
