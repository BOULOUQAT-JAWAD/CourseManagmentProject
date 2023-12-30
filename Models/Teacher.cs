namespace CourseManagmentProject.Models
{
    public class Teacher
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
