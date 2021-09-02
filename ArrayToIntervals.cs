/*
Дан упорядоченный массив натуральных чисел, повторяющихся элементов в списке нет.
Нужно преобразовать в строку с перечислением интервалов через запятую.
[2, 3, 5, 6, 7, 8, 9, 11, 20, 21, 22] -> “2-3,5-9,11,20-22”
*/
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
