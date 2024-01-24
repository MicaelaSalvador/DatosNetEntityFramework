namespace StudentEntityFramework.Models
{
    public static class CollegeRepository
    {
        public static List<Student> Students { get; set; } = new List<Student>() {

            new Student
            {
                Id = 1,
                StudentName = "Venkat",
                Email = "ventas@gmail.com",
                Address = "Hyd,INDIA"
            },
            new Student
             {
                Id = 2,
                StudentName = "Anil",
                Email = "Anil@gmail.com",
                Address = "Banglore,INDIA"
            }
        };
    }
}
