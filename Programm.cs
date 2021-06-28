using System;
using System.Linq;
using System.Text;
/*
Дан упорядоченный массив натуральных чисел, повторяющихся элементов в списке нет.
Нужно преобразовать в строку с перечислением интервалов через запятую.

[2, 3, 5, 6, 7, 8, 9, 11, 20, 21, 22] -> “2-3,5-9,11,20-22”
*/

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
  
  private static string CreateStr(int[] arr){
    
    var sb = new StringBuilder();
    
    //[2, 3, 5, 6, 7, 8, 9, 11, 20, 21, 22] -> “2-3,5-9,11,20-22”
    
    if(arr?.Any() != true)
      return "";
      
    var s=arr[0];
    var ss=s;
    sb.Append($"{s}");
    var e=false;
    for(var i=1; i<arr.Length; i++)
    {
      if(ss==arr[i]-1)
      {
        ss++;
        e=true;
        continue;
      }
      e=false;
      
      var last = arr[i-1];
      sb.Append(last == s ? ",":$"-{last},");
      
      s=arr[i];
      ss=s;
      sb.Append($"{s}");
    }
    if(e)
    {
      var last = arr[arr.Length -1];
      sb.Append(last == s ? "":$"-{last}");
    }
    
    return sb.ToString();
  }
}
