// David B. 10/28/24 Lab-7-Maze

Console.Clear();

Console.Write("This is a maze that getting to the '*' will complete the maze");
Console.WriteLine();

string[] mapRows = File.ReadAllLines("map.txt");

for(int i = 0; i<mapRows.Length; i++)
{
    Console.WriteLine(mapRows[i]);
}