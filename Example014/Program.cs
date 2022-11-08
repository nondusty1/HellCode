// Random r = new Random();

// Console.CursorVisible = false;
// while (true)
// {  
//     Console.SetCursorPosition(
//         left: r.Next(Console.WindowWidth),
//         top: r.Next(Console.WindowHeight)
//     );
//     Console.Write(r.Next(10));
//     Thread.Sleep(1000);
// }

using System.Linq;

string text = "(1,2) (2,3) (4,5) (9,7)"
                .Replace("(", "")
                .Replace(")", "")
                ;
Console.WriteLine(text);

var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Where(e => e.x % 2 == 0)
                .Select(point => (point.x * 10, point.y + 10))
                .ToArray();
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}