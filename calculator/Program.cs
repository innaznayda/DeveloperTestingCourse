using System;


namespace calculator {
   public class Program {
        static void Main(string[] args) {
            //Calculate();
            var result = GetTime();
            Console.WriteLine(result);
            Console.ReadLine();
        }

       public static string GetTime() {
           var now = DateTime.Now.TimeOfDay;
           return now.Hours.ToString();
       }

       private static void Calculate() {
          Console.WriteLine("Enter digits separated by whitespace to get a sum");
          string digits = Console.ReadLine();
          var refult = GetSum(digits);
          if (refult == null) {
              Console.WriteLine("incorrect input");
          } else {
              Console.WriteLine("sum {0}", refult);
          }
          Console.ReadLine();
       }

       public static int? GetSum(string digits) {
           if (string.IsNullOrEmpty(digits)) {
               return null;
           }
           int refult = 0;
           foreach (var digit in digits.Split(' ')) {
               int d;
               if (int.TryParse(digit, out d)) {
                   refult += d;
               } else {
                   return null;
               }
           }
           return refult;
       }
    }
    
}
