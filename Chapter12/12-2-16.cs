// リスト12-27

using System;
using System.Collections.Generic;
using System.Linq;

namespace Example{
    class Program{
        static void Main(string[] arg){
            var nums = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9};
            var max = nums.Max();
            Console.WriteLine(max);
        }
    }
}