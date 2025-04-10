using System;

namespace StudentApp
{
    class Student
    {
        public string Name;
        public string ID;
        public int Marks;

        public Student(string name, string id, int marks)
        {
            Name = name;
            ID = id;
            Marks = marks;
        }

        public char getGrade()
        {
            if (Marks > 90) { return 'A'; }
            else if (Marks > 80) { return 'B'; }
            else if (Marks > 70) { return 'C'; }
            return 'D';
        }

        static void prevMain(string[] args)
        {
            Student Student1 = new Student("Ram", "1", 85);
            Console.WriteLine("Grade of " + Student1.Name + " is " + Student1.getGrade());
            Student Student2 = new Student("Sam", "1", 75);
            Console.WriteLine("Grade of " + Student2.Name + " is " + Student2.getGrade());
            Student Student3 = new Student("Tam", "1", 95);
            Console.WriteLine("Grade of " + Student3.Name + " is " + Student3.getGrade());

        }
    }

    class StudentIITGN : Student
    {
        public string Hostel;


        public StudentIITGN(string name, string ID, int marks, string hostel) : base(name, ID, marks)
        {
            Hostel = hostel;
        }

        static void Main(string[] args)
        {
            StudentIITGN Student1 = new StudentIITGN("Ram", "1", 85, "J");
            Console.WriteLine("Grade of " + Student1.Name + " is " + Student1.getGrade() + ". Hostel of " + Student1.Name + " is " + Student1.Hostel);

            StudentIITGN Student2 = new StudentIITGN("Sam", "1", 75, "I");
            Console.WriteLine("Grade of " + Student2.Name + " is " + Student2.getGrade() + ". Hostel of " + Student2.Name + " is " + Student2.Hostel);
            StudentIITGN Student3 = new StudentIITGN("Tam", "1", 95, "K");
            Console.WriteLine("Grade of " + Student3.Name + " is " + Student3.getGrade() + ". Hostel of " + Student2.Name + " is " + Student3.Hostel);

        }
    }
}
