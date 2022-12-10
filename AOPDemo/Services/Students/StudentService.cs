using System;

namespace AOPDemo.Services.Students
{
    public class StudentService : IStudentService
    {
        public void AddStudent() =>
            Console.WriteLine("Hello, Student!");
    }
}
