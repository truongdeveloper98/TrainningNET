namespace Trainning.Core.Entities
{
    public class Class
    {
        public int Id { get; set; }


        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public IList<StudentInClass > studentInClasses { get; set; } 


    }
}
