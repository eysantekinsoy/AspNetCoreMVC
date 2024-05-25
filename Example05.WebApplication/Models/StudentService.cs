using Example05.WebApplication.Models;

namespace Example05.WebApplication.Models
{
    public class StudentService
    {
        private static List<Student> students = new List<Student>();
        public static List<Student> Students()
        {
            if (students.Any()) return students;

            students.Add(new Student() { Id=1, Name= "Eyşan" , Surname="Tekinsoy", Email="eysantekinsoy@hotmail.com",BirthDate=new DateOnly(1997,04,14),Gender=Gender.Female,StudentStatus=StudentStatus.Active });    
            students.Add(new Student() { Id=2, Name= "Hulya" , Surname="Tekinsoy", Email="hulyatekinsoy@hotmail.com",BirthDate=new DateOnly(1972,05,22),Gender=Gender.Female, StudentStatus=StudentStatus.Passive});    
            students.Add(new Student() { Id=3, Name= "Atakan" , Surname="Tekinsoy", Email="atakantekinsoy@hotmail.com",BirthDate=new DateOnly(1992,08,04),Gender=Gender.Male,StudentStatus=StudentStatus.Active });    
            students.Add(new Student() { Id=4, Name= "Ender" , Surname="Tekinsoy", Email="endertekinsoy@hotmail.com",BirthDate=new DateOnly(1962,10,02),Gender=Gender.Male,StudentStatus=StudentStatus.Freeze });
            students.Add(new Student() { Id=5, Name= "İhsan" , Surname="Koç", Email="ihsankoc@hotmail.com",BirthDate=new DateOnly(1997,09,22),Gender=Gender.Male,StudentStatus=StudentStatus.Active });
            students.Add(new Student() { Id=6, Name= "Semanur" , Surname="Adıbelli", Email="semaadıbelli@hotmail.com",BirthDate=new DateOnly(1997,02,05),Gender=Gender.Female,StudentStatus=StudentStatus.Passive });
            
            return students;
        }

        public static void AddStudent(Student student)
        {
            int maxId=students.MaxBy(s => s.Id).Id;
            student.Id = maxId + 1;
            students.Add(student);
        }
    }
}
