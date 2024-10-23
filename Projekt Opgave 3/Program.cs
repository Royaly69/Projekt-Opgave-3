using System.ComponentModel.Design;
using System.Diagnostics;
using System.Security.Cryptography;

string ans;
//Eksempel Kursuser
Course c1 = new Course("C1", "Programmering", "LangDiscriptionMegetInteressant", 10, 23102024);
Course c2 = new Course("C1", "UML Kursus", "LangDiscriptionMegetInteressant", 8, 23102024);
menu();
void menu()
{
    

    //Step 1

        Console.WriteLine("1. Opret Studerende");
        Console.WriteLine("Input Student ID");
        ans = Console.ReadLine();
        Student student = new Student(ans);
        Console.WriteLine("Input Student name");
        ans = Console.ReadLine();
        student.studentName = ans;
        Console.WriteLine("Input Student E-Mail");
        ans = Console.ReadLine();
        student.eMail = ans;
        Console.WriteLine("Input date");
        ans = Console.ReadLine();
        student.entryDate = Convert.ToInt32(ans);
    Step2();
    Step3();
    //Step 2
    void Step2()
    {
        Console.WriteLine("2. Tilføj studerende til kursus");
        SignUp signup = new SignUp("1", "?", student.studentID, student.entryDate);
        Console.WriteLine("Vaelg C1 eller C2");
        ans = Console.ReadLine();
        if (ans == "C1")
        {
            signup.JoinCourse(c1, student);
        }
        else if (ans == "C2")
        {
            signup.JoinCourse(c2, student);
        }
        else
        {
            Step2();
        }
    }
    

    //step 3
    void Step3()
    {
        Console.WriteLine("3. Vis liste over studerende på kursus");
        Console.WriteLine("Input Course ID --- Eks(C1)");
        ans = Console.ReadLine();
        if (ans == "C1")
        {
            c1.printSignedStudentList();
        }
        else if (ans == "C2")
        {
            c2.printSignedStudentList();
        }
        else
        {
            Step3();
        }
    }
    menu();
}





public class Student(string studentID)
{
    public string studentID = studentID;
    public string studentName;
    public string eMail;
    public int entryDate;

    
}

    public class SignUp(string signUpID,string signUpName,string studentID, int entryDate)
{
    public void JoinCourse(Course courseID,Student studentID)
    {
        courseID.signedStudentIDList.Add(studentID);
    }
}
public class Course(string courseID, string courseName, string courseDiscription, int moduleCount, int courseStartDate)
{
    public List<Student> signedStudentIDList = new List<Student>();


    public void printSignedStudentList()
    {

        foreach (Student studentID in signedStudentIDList)
        {
            Console.WriteLine(studentID.studentName);
        }
    }
    class Instructor(string instructorID, string instructorName, string instructorEMail, string speciality)
    {

    }
}