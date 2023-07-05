using System;


public class Program
{
    public class Student
    {
        public int studentID { get; set; }
        public string studentName { get; set; }

        //Constructor
        public Student(int id, string name)
        {
            studentID = id;
            studentName = name;
        }
        //Private method that can only be accessed within the class
        private string GetStudentName()
        {
            var studentname = "Jayjay";
            return studentname;
        }

        public virtual void GetStudent()
        {
            Console.WriteLine($"The base method: Student of ID {studentID} and name {studentName} ");
        }
       
    }

    // Inheritance
    public class ITStudent : Student
    {
        public string studentCourse { get; set; }

        // Constructor
        public ITStudent(int studentID, string studentName, string studentCourse) : base(studentID, studentName)
        {
            this.studentCourse = studentCourse;
        }

        // Method override
        public override void GetStudent()
        {
            Console.WriteLine($"The student {studentName} studies {studentCourse} .");
        }
    }

    public static void Main(string[] args)
    {
        // Create an instance of the base class
        Student student = new Student( 5,"Tom Clansy");
        Console.WriteLine($"ID: {student.studentID}, Name: {student.studentName}");
        student.GetStudent();

        Console.WriteLine();

        // Create an instance of the inherited class
        ITStudent itstudent = new ITStudent( 3, "Jane Alexia", "BBIT");
        Console.WriteLine($"ID: {itstudent.studentID}, Name: {itstudent.studentName}, Course: {itstudent.studentCourse}");
        itstudent.GetStudent();

    }
}


