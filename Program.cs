/*Task1
int n=Convert.ToInt32(Console.ReadLine());

PrintFromNumberToOne(n);


void PrintFromNumberToOne(int number)
{
    for(int i=number; i>0; i--)
    {
        Console.Write($"{i} ");
    }
}
*/


/*Task2
int c=Sum(1,2,3,4);

Console.Write(c);

int Sum (int a, int b, int c, int d)
{
    return a+b+c+d;
}
*/
//Task3
// int n=Convert.ToInt32(Console.ReadLine());
// int Reverse(int n)
// {
//     int rev=0;
//     for(int i=n; i>0; i/=10)
//     {
//         rev=rev*10;
//         rev+=i%10;
//     }
//     return rev;
// }
// int r=Reverse(n);
// Console.WriteLine($"{r}");


/*Task4
int a=Convert.ToInt32(Console.ReadLine());

PrintStars(a);

void PrintStars(int n)
{
    for(int i=n; i>0; i--)
    {
        Console.Write($"{"*"}");
    }
}
*/


//Task5
// int a=Convert.ToInt32(Console.ReadLine());

// PrintSquare(a);

// void PrintSquare(int n)
// {
//         for(int i=n; i>0; i--)

//     {
//     for(int j=n; j>0; j--)
//         {
//             Console.Write($"{"*"}");
//         }

//     Console.WriteLine();
//     }
// }


// Task6
// int a=Convert.ToInt32(Console.ReadLine());
// int b=Convert.ToInt32(Console.ReadLine());

// PrintSquare(a,b);

// void PrintSquare(int n,int m)
// {
//         for(int i=m; i>0; i--)

//     {
//     for(int j=n; j>0; j--)
//         {
//             Console.Write($"{"*"}");
//         }

//     Console.WriteLine();
//     }
// }
//Task6

// Task7

// int a=Convert.ToInt32(Console.ReadLine());

// PrintSquare(a);

// void PrintSquare(int m)
// {
//         for(int i=1; i<=m; i++)

//     {
//     for(int j=1; j<=i; j++)
//         {
//             Console.Write($"{"*"}");
//         }

//     Console.WriteLine();
//     }
// }


//Task8

// int n =Convert.ToInt32(Console.ReadLine());
// PrintRightTriangle (n);
// void PrintRightTriangle (int size )
// {
//     for(int i=0; i<=size; i++)
//     {
//         PrintSpaces (n);
//         void PrintSpaces (int siz)
//         {
//             for( int j=n-i; j>0; j--)
//             {
//                 Console.Write($" ");
//             }


//         PrintStars(n);
//         void PrintStars (int ss)
//         {
//             for(int k=0; k<=i; k++)
//             {
//                 Console.Write("*");
//             }
//         }
//         }
//         Console.WriteLine();
//     }
// 

//Hometask1

//  int n =Convert.ToInt32(Console.ReadLine());


// int EvenCount(int n)
// {
//     int rev=0;
//     int c=0;
//     for(int i=n; i>0; i/=10)
//     {
//         rev=rev*10;
//         rev+=i%10;
//     if(rev%2==0)
//     {
//         c++;
//     }
//     }
//     return c;

// }
// int OddCount(int n)
// {
//     int rev=0;
//     int c=0;
//     for(int i=n; i>0; i/=10)
//     {
//         rev=rev*10;
//         rev+=i%10;
//     if(rev%2!=0)
//     {
//         c++;
//     }
//     }
//     return c;

// }
// int DigitCount(int n)
// {
//     int rev=0;
//     int c=0;
//     for(int i=n; i>0; i/=10)
//     {
//         rev=rev*10;
//         rev+=i%10;  
//         c++;
//     }
//     return c;

// }
// int SumDigit(int n)

// {
//     int rev=0;
//     for(int i=n; i>0; i/=10)
//     {
//         rev+=i%10;
//     }
//     return rev;

// }
// int a1=EvenCount(n);
// Console.WriteLine($"Even:{a1}");
// int a2=OddCount(n);
// Console.WriteLine($"Odd:{a2}");
// int a3=DigitCount(n);
// Console.WriteLine($"Digit:{a3}");
// int a4=SumDigit(n);
// Console.WriteLine($"Sum:{a4}");


//Hometask2

//  int a =Convert.ToInt32(Console.ReadLine());
//  int b =Convert.ToInt32(Console.ReadLine());

//  int Add(int a, int b)
// { 
//    int a1=0;
//    a1=a+b;
//    return a1; 
// }
// int Subtract (int a, int b)

// { 
//    int a2=0;
//    a2=a-b;
//    return a2; 
// }
// int Multiply (int a, int b)

// { 
//    int a3=0;
//    a3=a*b;
//    return a3; 
// }
// int Division (int a, int b)

// { 
//    int a4=0;
//    a4=a/b;
//    return a4; 
// }
// int a1=Add(a,b);
// Console.WriteLine($"Add:{a1}");
// int a2=Subtract(a,b);
// Console.WriteLine($"Subtract:{a2}");
// int a3=Multiply(a,b);
// Console.WriteLine($"Multiply:{a3}");
// int a4=Division(a,b);
// Console.WriteLine($"Division:{a4}");

//Hometask3

//  int n =Convert.ToInt32(Console.ReadLine());
//  int MaxDigit (int n)
 

// {
//     int rev=0;
//      int c=0;
//     for(int i=n; i>0; i/=10)
//      {
//          rev=i%10;
//       if(rev>c)
//      {
//        c=rev;
//      }
//      }  
//        return c;
    
// }
// int MinDigit (int n)
// {

//     int nev=0;
//      int w=9;
//     for(int i=n; i>0; i/=10)
//      {
//          nev=i%10;
//       if(nev<w)
//      {
//        w=nev;
//      }
//      }  
//        return w;
// }
// int Sum(int c, int w)
// {
//     return c+w;
// }
//  int c=MaxDigit(n);
//  Console.WriteLine($"Max:{c}");
//   int w=MinDigit(n);
//  Console.WriteLine($"Min:{w}");
// int a1 = Sum(c,w);
//  Console.WriteLine($"{c} + {w} = {a1}");
 
//Hometask4

// int a =Convert.ToInt32(Console.ReadLine());
// int b =Convert.ToInt32(Console.ReadLine());

// int Pow(int x, int y)
// {
// int a1=1;
//     for(int i=0; i<y; i++)
//     {
//         a1*=x;
//     }
//     return a1;
// }
//      int a2=Pow(a,b);
//     Console.WriteLine(a2);


//Hometask5


//  int a =Convert.ToInt32(Console.ReadLine());
//  int b =Convert.ToInt32(Console.ReadLine());

//  Swap(ref a, ref b);

//   void Swap(ref int a, ref int b)
// {
//     int a1;
//     a1=a;
//     a=b;
//     b=a1;
//     Console.WriteLine(a);
//     Console.WriteLine(b);
// }
