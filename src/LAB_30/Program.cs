


using LAB_30.Data;
using LAB_30.Models;

using (var db = new ApplicationContext())
{
    var group = new Group
    {
        Id = 1,
        GroupName = "3-025"
    };
    var group2 = new Group
    {
        Id = 2,
        GroupName = "3-028"
    };

    db.Groups.Add(group);
    db.Groups.Add(group2);
    await db.SaveChangesAsync();

    var student = new Student
    {
        Id = 1,
        FullName = "John Doe",
        GroupId = 10
    };

    db.Students.Add(student);
    await db.SaveChangesAsync();

    var grade = new Grade
    {
        Id = 1,
        SubjectName = "Mathematics",
        Score = 95,
        StudentId = 1
    };

    db.Grades.Add(grade);
    await db.SaveChangesAsync();
}

Console.WriteLine();