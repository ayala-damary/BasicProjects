// using System;

// public class HelloWorld
// {

//     public static void Main(string[] args)
//     {
//         int num1 = 5;
//         int num2 = 7;
//         int result = 0;

//         if (num1 < num2)
//         {
//             int temp = num1;
//             num1 = num2;
//             num2 = temp;
//         }
//         //ב1 יש את המספר הגבוה וב2 יש את המספר הנמוך
//         Console.WriteLine("Swapped num1: " + num1);
//         Console.WriteLine("Swapped num2: " + num2);

//         for (int i = 1; i <= 5; i++)
//         {
//             result += i;
//         }
//         //1+2+3+4+5=15
//         Console.WriteLine("Sum from 1 to 5: " + result);

//         int result2 = 42;
//         Console.WriteLine("result: " + result2);
//         int innerVar=0;
//         for (int i = 0; i < 3; i++)
//         {
//             innerVar += i * 2;
//         }

//         //משתנה פנימי
//         Console.WriteLine("Inner variable: " + innerVar);
//         SomeMethod();
//     }

//     static void SomeMethod()
//     {
//         int localVar = 20;
//         Console.WriteLine("Local variable from SomeMethod: " + localVar);
//     }
// }