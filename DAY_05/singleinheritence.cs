// // single inheritance --- There is one base class and one child class

 public class Person
 {
     //properties 
     protected string Name { get; set; }
     public virtual void Display()
     {
        Console.WriteLine("Displaying Name you entered :");
     }

     public void setName(string Name)
     {
         this.Name = Name;
     }
 }
 public class Student : Person
 {

      public Student(string name)
            {
          Name = name;
         }
     public int RollNumber { get; set; }

     public void Study()

     { Console.WriteLine(Name + "is studying :"); }

     static void Main()
        {

         Student stud = new Student("bhumi");
        //stud.Name = "Niti";
         stud.setName("Niti");
         stud.RollNumber = 2004;
         stud.Display();
        stud.Study();
     }

 }
