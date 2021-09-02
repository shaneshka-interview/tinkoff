using System;
using System.Linq;
using System.Text;


/*
Даны 2 упорядоченных (отсортированных) массива с уникальными элементами,
найти и вывести их упорядоченное объединение без дубликатов, 
используя константу доп. памяти.
*/

public class Test
{
	public static void Main()
	{
		Console.WriteLine("Hello");
    
   //Console.WriteLine( CreateStr(new[]{1, 3, 4, 5}));
   
   C(new []{1,2,3}, new[]{2,3,4});
   C(new []{1,3}, new[]{2,3,4});
   C(new []{1}, new[]{2});
   C(new []{3}, new[]{1, 2, 3});
   C(new []{-4,5,6}, new[]{-2,3,4});
	}
  
  private static void C(int[] a, int[] b){
    
    var i=0;
    var j=0;
    
    while(i<a.Length || j<b.Length)
    {
        if(i>=a.Length)
        {
          Print(b,j);
          break;
        }
        else if(j>=b.Length)
        {
          Print(a, i);
          break;
        }
        else{
          
          var aa = a[i];
          var bb= b[j];
          if(aa==bb)
          {
            Console.WriteLine(aa);
            i++;
            j++;
          }
          while(i<a.Length  && aa < bb)
          { 
            Console.WriteLine(aa);
            i++;
            if(i<a.Length)
              aa = a[i];
          }
          while(j<b.Length && bb<aa)
          {
            Console.WriteLine(bb);
            j++;
            if(j<b.Length)
              bb = b[j];
          }
        }
      
    }
    
    Console.WriteLine("--------");
  }
  
  private static void Print(int[] a, int i)
  {
    while(i<a.Length)
   { Console.WriteLine(a[i]);
   i++;
   }
  }
  
	
