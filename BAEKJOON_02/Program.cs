using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Split()는 문자열을 나눠주는 메소드 ()안에 공백으로 두면 공백을 기준으로 나눠주고 , 나 원하는 기호를 넣으면 그기호를 기준으로 나눠준다 
            string[] input = Console.ReadLine().Split();
            //문자열로 나눠서 저장했기 때문에 int형으로 변환 시켜줘야 사칙연산 가능 
            Console.WriteLine(int.Parse(input[0]) + int.Parse(input[1]));
        }
    }
}
