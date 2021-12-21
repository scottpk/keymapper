using System;
using System.Linq;
namespace keymapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine(Enum.GetValues<ActionToken>().Count());
            //Console.WriteLine(Enum.GetValues<PositionToken>().Count());
            Console.WriteLine(TokenValueHelper.PositionTokenDictionary.Count());
            // foreach(var d in FixedValues.PositionTokenDictionary){
            //     Console.WriteLine($"new Key(\"{d.Value}\",PositionToken.{d.Key}),");
            // }
            Console.WriteLine(new PhysicalKeyboard().physicalKeys.Count());
        }
    }
}
