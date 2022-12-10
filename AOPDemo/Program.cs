using AOPDemo.Services.Students;

namespace AOPDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            IStudentService studentService =
                new StudentService();

            studentService = StudentServiceDispatch<IStudentService>
                .Create(studentService);

            studentService.AddStudent();
        }
    }
}