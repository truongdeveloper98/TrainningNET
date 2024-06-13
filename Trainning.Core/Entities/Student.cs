﻿namespace Trainning.Core.Entities
{
    public class Student
    {
        public int Id { get; set; }


        public string Name { get; set; } 

        public int Age { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
   
        public string Description { get; set; }

        public IList<StudentInClass> studentInClasses { get; set; }


     

    }
}
