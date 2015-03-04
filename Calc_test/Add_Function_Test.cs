﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Calc;


namespace Calc_test
{
   
    public class TestClass
    {
       
        static void Main(string[] args)
       {
           TestClass t = new TestClass();
           t.AddTwoPositiveNumber();
           t.AddOneNumberOneCharacter();
           t.AddOneNegativeOnePositive();
           t.AddTwoNegativeNumber();
           t.AddTwoCharacter();
       }

       Calc_Controller c = new Calc_Controller();
      
        //test case

       public void AddTwoPositiveNumber()
       {
           int result = c.sum(5, 10);

           if(result==15)
           {
               Console.WriteLine("test sucess");
           }
           else
           {
               Console.WriteLine(" Addition of two positive Number failed");
               
           }
           Console.ReadLine();
       }

       public void AddOneNumberOneCharacter()
       {
           
           int result = c.sum('a', 10);

           if (result == 107)
           {
               Console.WriteLine("test sucess");

           }
           else
           {
               Console.WriteLine("Addition of one Number and one character failed");

           }
           Console.ReadLine();
       }


       public void AddOneNegativeOnePositive()
       {
           int result = c.sum(-20, 10);

           if (result == -10)
           {
               Console.WriteLine("test sucess");

           }
           else
           {
               Console.WriteLine("Addition of one positive one negative Number failed");

           }
           Console.ReadLine();
       }


       public void AddTwoNegativeNumber()
       {
           int result = c.sum(-5, -10);

           if (result == -15)
           {
               Console.WriteLine("test sucess");

           }
           else
           {
               Console.WriteLine("Addition of two Negative Number failed");

           }
           Console.ReadLine();
       }

       public void AddTwoCharacter()
       {
           int result = c.sum('a','b');

           if (result == 195)
           {
               Console.WriteLine("test sucess");

           }
           else
           {
               Console.WriteLine("Addition of two character Number failed");

           }
           Console.ReadLine();
       }

    }
}

