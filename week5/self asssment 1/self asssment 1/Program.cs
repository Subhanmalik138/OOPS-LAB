using System;
using System.Collections.Generic;
using System.Linq;

class Subject
{
    public string Code { get; set; }
    public string Type { get; set; }
    public int CreditHours { get; set; }
    public int Fee { get; set; }
}

class DegreeProgram
{
    public string Title { get; set; }
    public int Duration { get; set; }
    public int Seats { get; set; }
    public List<Subject> Subjects { get; set; } = new List<Subject>();
}

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int FSCMarks { get; set; }
    public int EcatMarks { get; set; }
    public List<string> Preferences { get; set; } = new List<string>();
    public List<Subject> RegisteredSubjects { get; set; } = new List<Subject>();
    public string AssignedProgram { get; set; } = "";
}

class UAMS
{
    static List<Student> students = new List<Student>();
    static List<DegreeProgram> programs = new List<DegreeProgram>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("UAMS");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Students of a Specific Program");
            Console.WriteLine("6. Register Subjects for a Specific Student");
            Console.WriteLine("7. Calculate Fees for All Registered Students");
            Console.WriteLine("8. Exit");
            Console.Write("Enter Option: ");

            switch (Console.ReadLine())
            {
                case "1": AddStudent(); break;
                case "2": AddDegreeProgram(); break;
                case "3": GenerateMerit(); break;
                case "4": ViewRegisteredStudents(); break;
                case "5": ViewStudentsByProgram(); break;
                case "6": RegisterSubjects(); break;
                case "7": CalculateFees(); break;
                case "8": return;
            }
        }
    }

    static void AddStudent()
    {
        Student s = new Student();
        Console.Write("Enter Student Name: "); s.Name = Console.ReadLine();
        Console.Write("Enter Student Age: "); s.Age = int.Parse(Console.ReadLine());
        Console.Write("Enter Student FSC Marks: "); s.FSCMarks = int.Parse(Console.ReadLine());
        Console.Write("Enter Student Ecat Marks: "); s.EcatMarks = int.Parse(Console.ReadLine());

        Console.WriteLine("Available Degree Programs:");
        foreach (var p in programs) Console.WriteLine(p.Title);

        Console.Write("Enter how many preferences to enter: ");
        int prefCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < prefCount; i++)
        {
            Console.Write("Enter Preference: ");
            s.Preferences.Add(Console.ReadLine());
        }
        students.Add(s);
    }

    static void AddDegreeProgram()
    {
        DegreeProgram p = new DegreeProgram();
        Console.Write("Enter Degree Name: "); p.Title = Console.ReadLine();
        Console.Write("Enter Degree Duration: "); p.Duration = int.Parse(Console.ReadLine());
        Console.Write("Enter Seats for Degree: "); p.Seats = int.Parse(Console.ReadLine());

        Console.Write("Enter how many subjects to add: ");
        int subCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < subCount; i++)
        {
            Subject sub = new Subject();
            Console.Write("Enter Subject Code: "); sub.Code = Console.ReadLine();
            Console.Write("Enter Subject Type: "); sub.Type = Console.ReadLine();
            Console.Write("Enter Subject Credit Hours: "); sub.CreditHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Fees: "); sub.Fee = int.Parse(Console.ReadLine());
            p.Subjects.Add(sub);
        }
        programs.Add(p);
    }

    static void GenerateMerit()
    {
        students = students.OrderByDescending(s => (s.FSCMarks + s.EcatMarks)).ToList();
        foreach (var s in students)
        {
            foreach (var pref in s.Preferences)
            {
                DegreeProgram prog = programs.FirstOrDefault(p => p.Title == pref && p.Seats > 0);
                if (prog != null)
                {
                    s.AssignedProgram = pref;
                    prog.Seats--;
                    break;
                }
            }
        }
        foreach (var s in students)
            Console.WriteLine($"{s.Name} {(s.AssignedProgram != "" ? "got Admission in " + s.AssignedProgram : "did not get Admission")}");
        Console.ReadKey();
    }

    static void ViewRegisteredStudents()
    {
        foreach (var s in students.Where(s => s.AssignedProgram != ""))
            Console.WriteLine($"{s.Name} {s.FSCMarks} {s.EcatMarks} {s.Age}");
        Console.ReadKey();
    }

    static void ViewStudentsByProgram()
    {
        Console.Write("Enter Degree Name: ");
        string degree = Console.ReadLine();
        foreach (var s in students.Where(s => s.AssignedProgram == degree))
            Console.WriteLine($"{s.Name} {s.FSCMarks} {s.EcatMarks} {s.Age}");
        Console.ReadKey();
    }

    static void RegisterSubjects()
    {
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();
        Student student = students.FirstOrDefault(s => s.Name == name);
        if (student == null || student.AssignedProgram == "") return;

        DegreeProgram program = programs.FirstOrDefault(p => p.Title == student.AssignedProgram);
        int totalCredits = 0;
        foreach (var sub in program.Subjects)
        {
            Console.Write($"Register {sub.Code}? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
            {
                if (totalCredits + sub.CreditHours <= 9)
                {
                    student.RegisteredSubjects.Add(sub);
                    totalCredits += sub.CreditHours;
                }
            }
        }
        Console.ReadKey();
    }

    static void CalculateFees()
    {
        foreach (var s in students)
        {
            int fee = s.RegisteredSubjects.Sum(sub => sub.Fee);
            Console.WriteLine($"{s.Name} Total Fee: {fee}");
        }
        Console.ReadKey();
    }
}
