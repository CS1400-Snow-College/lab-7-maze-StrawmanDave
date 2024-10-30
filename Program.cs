// David B. 10/28/24 Lab-7-Maze
string[] mazeRows = File.ReadAllLines("map.txt");

//Sets the cursor to the start of the maze
int x = 0;
int y = 0;
Console.SetCursorPosition(x,y);

mainMenu();

for(int i = 0; i< mazeRows.Count(); i++)
{
    for(int j = 0; j<mazeRows[i].Length; j++)
    {
        Console.Write(mazeRows[i][j]);
    }
    Console.WriteLine();
}
Console.SetCursorPosition(x,y);

do
{
    if(Console.ReadKey(true).Key == ConsoleKey.Escape)
    {
        mainMenu();
        printFileLines("map.txt");
        x = 0;
        y = 0;
        Console.SetCursorPosition(x,y);
    }else if(Console.ReadKey(true).Key == ConsoleKey.UpArrow)
    {
         
        if(tryMove(x, y, "n", mazeRows) == true)
        {
            y --;
        }
        
    }else if(Console.ReadKey(true).Key == ConsoleKey.DownArrow)
    {
        
        if(tryMove(x, y, "s", mazeRows) == true)
        {
            y ++;
        }
        
    }else if(Console.ReadKey(true).Key == ConsoleKey.LeftArrow)
    {
         
        if(tryMove(x, y, "e", mazeRows) == true)
        {
            if(x - 1 >= 0)
            {
                x--;
            }
            
        }
        
    }else if (Console.ReadKey(true).Key == ConsoleKey.RightArrow)
    {
        
       if(tryMove(x, y, "w", mazeRows) == true)
        {
            x++;
        }
        
    }
    Console.SetCursorPosition(x,y);

}while(Console.CursorLeft != 27 || Console.CursorTop != 4);


// Console.WriteLine($"{Console.CursorLeft} {Console.CursorTop}");
winMenu();

static void printFileLines (string filename)
{
    string[] fileLines = File.ReadAllLines(filename);
    for (int i = 0; i<fileLines.Length; i++)
    {
        Console.WriteLine(fileLines[i]);
    }
}

static bool tryMove(int x, int y, string direction, string[] maze)
{

    if(direction == "w")
    {
        if(x > maze[y].Length || maze[y][x+1] == '#')
        {
            return false;
        }else 
        {
            return true;
        }
    }else if(direction == "e")
    {
        if(x-1 < 0 || maze[y][x-1] == '#')
        {
            return false;
        }else
        {
            return true;
        }
    }else if(direction == "s")
    { 
        if(y > maze.Count() || maze[y+1][x] == '#')
        {
            return false;
        }else 
        {
            return true;
        }
    }else if (direction == "n")
    {
        if (y-1 < 0 || maze[y-1][x] == '#')
        {
            return false;
        }else 
        {
            return true;
        }
    }else 
    {
        return false;
    }
}

static void mainMenu()
{
Console.Clear();
Console.Write("This is a maze that getting to the '*' will complete the maze");
Console.WriteLine();
Console.Write("Press any key to start");
Console.ReadKey(true);
Console.Clear();
}

static void winMenu()
{
    Console.Clear();
    Console.WriteLine();
    Console.Write("----------------------------------------------");
    Console.WriteLine();
    Console.Write("Congradualtions you made it through the maze!");
    Console.WriteLine();
    Console.Write("----------------------------------------------");
    Console.WriteLine();
}