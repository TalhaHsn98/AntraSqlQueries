using Classes_UsingOOPS.Classes;
using Classes_UsingOOPS.Interfaces;
using Classes_UsingOOPS.Models;

IStudentService studentService = new StudentService();
IInstructorService instructorService = new InstructorService();
ICourseService courseService = new CourseService();
IDepartmentService departmentService = new DepartmentService();

Student s1 = new Student { StudentId = 1, Name = "Alice", DateOfBirth = new DateTime(2000, 5, 10), Major = "CS", CreditsEarned = 30 };
Student s2 = new Student { StudentId = 2, Name = "Bob", DateOfBirth = new DateTime(2001, 8, 15), Major = "Math", CreditsEarned = 45 };

studentService.AddAddress(s1.StudentId, "123 Street A");
studentService.AddAddress(s1.StudentId, "456 Street B");

Instructor inst = new Instructor { InstructorId = 1, Name = "Dr. Smith", DateOfBirth = new DateTime(1980, 1, 1) };
instructorService.AssignDepartment(inst.InstructorId, 1);

Department dept = new Department { DepartmentId = 1, Name = "Computer Science", Budget = 50000, StartDate = DateTime.Now, EndDate = DateTime.Now.AddYears(1) };
departmentService.AddDepartment(dept);
departmentService.AssignHead(dept.DepartmentId, inst.InstructorId);

Course c1 = new Course { CourseId = 101, Name = "Programming", Credits = 3, DepartmentId = 1 };
Course c2 = new Course { CourseId = 102, Name = "Databases", Credits = 4, DepartmentId = 1 };
courseService.AddCourse(c1);
courseService.AddCourse(c2);

studentService.EnrollInCourse(s1.StudentId, c1.CourseId);
studentService.EnrollInCourse(s1.StudentId, c2.CourseId);
studentService.EnrollInCourse(s2.StudentId, c1.CourseId);

studentService.AssignGrade(s1.StudentId, c1.CourseId, 'A');
studentService.AssignGrade(s1.StudentId, c2.CourseId, 'B');
studentService.AssignGrade(s2.StudentId, c1.CourseId, 'C');

double gpa1 = studentService.CalculateGPA(s1.StudentId);
Console.WriteLine($"GPA of {s1.Name} is {gpa1}");

decimal bonusSalary = instructorService.CalculateBonusSalary(inst.InstructorId, 50000m, new DateTime(2015, 1, 1));
Console.WriteLine($"Bonus salary of {inst.Name} is {bonusSalary}");

var addresses = studentService.GetAddresses(s1.StudentId);
Console.WriteLine($"{s1.Name} addresses: {string.Join(", ", addresses)}");