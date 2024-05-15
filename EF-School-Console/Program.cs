using EF_School_Console.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;


//////////////////////////////////////////////////////////////////////////////////////
/// using-Anweisung: 
///     Sicherstellen der ordnungsgemäßen Verwendung verwerfbarer Objekte
using (var db = new SchoolContext())
    {
        Student firstStudent = new Student("First Franz");

        db.Students.Add(firstStudent);

        db.SaveChanges();

    }



//////////////////////////////////////////////////////////////////////////////////////
/// 

SchoolContext schoolContext = new SchoolContext();

// Klasse erstellen
Grade grade1AHIT = new Grade("1AHIT");
schoolContext.Grades.Add(grade1AHIT);

schoolContext.Grades.Add(new Grade("2AHIT"));
schoolContext.SaveChanges();



Student newStudent = new Student("Ziener Ewald");
grade1AHIT.Students.Add(newStudent);

grade1AHIT.Students.Add(new Student("Inline Ines"));


schoolContext.SaveChanges();

// Klasse aus Datenbank laden
var queryGrade = schoolContext.Grades.Where(g => g.Name.Contains("AHIT"));


// Laden der Klasse (inkl. Bedingung) und die dazugehörigen Studenten
var grade = schoolContext.Grades
    .Include(s => s.Students)
    .Where(g => g.IdNo == "1AHIT");

// Ausgabe der Klasse(n) und der dazugehörigen Studenten 
foreach (var s in grade)
{
    Console.WriteLine(s.Name);
    foreach (var student in s.Students)
        Console.WriteLine($"\t- {student.StudentName}");
}

