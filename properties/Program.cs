using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class student
    {
        string name;
        string batch;
        int rollno;
        public string Name
        {
            set {
                if (value == "")
                 Console.WriteLine("Name cannot be null"); 
                else
                 name = value; 
            }
            get { return name; }
        }
        public string Batch
        {
            set { 
                if(value == "")
                    Console.WriteLine("Batch cannot be null");
                else
                batch = value; }
            get { return batch; }
        }
        public int Rollno
        {
            set { 
                if(value<1)
                    Console.WriteLine("Roll cannot be zero or Negative");
                else
                rollno=value;
            }
            get { return rollno; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            Console.WriteLine("Enter Name:");
            s.Name=Console.ReadLine();
            Console.WriteLine("Enter Batch:");
            s.Batch=Console.ReadLine();
            Console.WriteLine("Enter Roll No:");
            s.Rollno = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("{0} {1} {2}",s.Name,s.Batch,s.Rollno);
            Console.ReadKey();
        }
    }
}
