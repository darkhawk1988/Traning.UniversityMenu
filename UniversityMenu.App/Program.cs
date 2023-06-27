using UniversityMenu.App.Infrastructure;
using UniversityMenu.Models.Entities;
using UniversityMenu.Models.Interfaces;
using UniversityMenu.Tools;

// var studentMenu= new StudentMenu();
// studentMenu.Items.Add("1-Add student");
// studentMenu.Items.Add("2-Edit student");
// studentMenu.Items.Add("3-Delete student");
// studentMenu.Items.Add("4-Edit student");
// studentMenu.Items.Add("0-Exit");
var mainMenu=new MainMenu();

while(true)
{
    var  m=mainMenu.Show();
    if(m==0)
    {
        break;
    }
    if(m==1)
    {
        var studentMenu=new StudentMenu();
        while(true)
        {
            var s=studentMenu.Show();
            if(s==0)
            {
                break;
            }
            if(s==1)
            {
                var student=new Student();
                student.Read();
                using(var db=new UniversityMenuDB())
                {
                    db.Students.Add(student);
                    db.SaveChanges();
                    Console.WriteLine("OK!");
                }
            }
            if(s==2)
            {
                Console.Write("Student Id: ");
                var id=int.Parse(Console.ReadLine());
                using(var db=new UniversityMenuDB())
                {
                    var student=db.Students.FirstOrDefault(s=>s.Id==id);
                    if(student==null)
                    {
                        Console.WriteLine("Not found!");
                    }
                    else
                    {
                        Console.WriteLine(student);
                        student.Read();
                        db.SaveChanges();
                        Console.WriteLine("Done!");
                    }
                }
            }
            if(s==3)
            {
                Console.Write("Student Id: ");
                var id=int.Parse(Console.ReadLine());
                using(var db=new UniversityMenuDB())
                    {
                        var student=db.Students.FirstOrDefault(s=>s.Id==id);
                        if(student==null)
                        {
                            Console.WriteLine("Not found!");
                        }
                        else
                        {
                            Console.WriteLine(student);
                            db.Students.Remove(student);
                            db.SaveChanges();
                            Console.WriteLine("Done!");
                        }
                    }
            }
            if(s==4)
            {
                using(var db=new UniversityMenuDB())
                {
                    db.Students.ToList().ForEach(s=>Console.WriteLine(s));
                }
            }
            if(s==5)
            {
                using(var db=new UniversityMenuDB())
                {
                    db.Students.OrderByDescending(s=>s.Average).ToList().ForEach(s=>Console.WriteLine(s));
                }
            }
        }
    }
    if(m==2)
    {
        var professorMenu=new ProfessorMenu();
        while(true)
        {
            var p=professorMenu.Show();
            if(p==0)
            {
                break;
            }
            if(p==1)
            {
                var professor=new Professor();
                professor.Read();
                using(var db=new UniversityMenuDB())
                {
                    db.Professors.Add(professor);
                    db.SaveChanges();
                    Console.WriteLine("OK!");
                }
            }
            if(p==2)
            {
                Console.Write("Professor Id: ");
                var id=int.Parse(Console.ReadLine());
                using(var db=new UniversityMenuDB())
                {
                    var professor=db.Professors.FirstOrDefault(s=>s.Id==id);
                    if(professor==null)
                    {
                        Console.WriteLine("Not found!");
                    }
                    else
                    {
                        Console.WriteLine(professor);
                        professor.Read();
                        db.SaveChanges();
                        Console.WriteLine("Done!");
                    }
                }
            }
            if(p==3)
            {
                Console.Write("Professor Id: ");
                var id=int.Parse(Console.ReadLine());
                using(var db=new UniversityMenuDB())
                    {
                        var professor=db.Professors.FirstOrDefault(s=>s.Id==id);
                        if(professor==null)
                        {
                            Console.WriteLine("Not found!");
                        }
                        else
                        {
                            Console.WriteLine(professor);
                            db.Professors.Remove(professor);
                            db.SaveChanges();
                            Console.WriteLine("Done!");
                        }
                    }
            }
            if(p==4)
            {
                using(var db=new UniversityMenuDB())
                {
                    db.Professors.ToList().ForEach(s=>Console.WriteLine(s));
                }
            }
            if(p==5)
            {
                using(var db=new UniversityMenuDB())
                {
                    Console.Write("Insert name of field: ");
                    var field=Console.ReadLine();
                    db.Professors.Where(s=>s.Field==field).ToList().ForEach(s=>Console.WriteLine(s));
                }
            }
        }
    }
}