using System.Security.Cryptography.X509Certificates;

namespace classtask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int point = 20;
            Student student = new Student("Ayla","Atakishiyeva","KE023S2",point);
            student.CheckGraduation(point);
            student.GetDiplomDegree(point);
            student.GetInfo();
            
        }
    }


    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduated;



    public void GetInfo()
        {
            Console.WriteLine($"Name:{Name} Surname:{Surname} Group:{Group} Point:{Point} Isgraduated:{IsGraduated }");
            
        }

        public void  CheckGraduation(int point)
        {  

            if (point >= 65)
            {
                IsGraduated = true;
                Console.WriteLine("This student is graduated");
                return;
            }
            IsGraduated = false;
            Console.WriteLine("This student is not graduated");
           
        }
        public void GetDiplomDegree(int point)
        {
            if (point < 65)
            {
                Console.WriteLine("No Degree");
            }
            else if(point>=65 && point <= 80)
            {
                Console.WriteLine("Ordinary Degree");
            }
            else if(point>80 && point <= 90)
            {
                Console.WriteLine("Honor Degree");
            }
            else
            {
                Console.WriteLine("High Honor Degree");
            }
        }
        public Student(string name,string surname,string group,int point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
           
        }
      

      
           
       
      

    }
   
    
    

}