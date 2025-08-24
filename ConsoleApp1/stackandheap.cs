using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class stackandheap
    {
        public static void Main()
        {
           int a = 5;
            int b = a;
           b = 60;


            Console.WriteLine(a);
            Console.WriteLine(b);

         }
  }

        class Student
        {
        public string Name;


          public static void Main()
          {
               Student s1 = new Student();
               s1.Name = "Niti";

                Student s2 = s1; // Copy reference 

               s2.Name = "Preeti";

               Console.WriteLine(s2.Name);
                Console.WriteLine(s1.Name);

          }


    }
