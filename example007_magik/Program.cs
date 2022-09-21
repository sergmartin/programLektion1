Console.Clear();// очистка экрана
//Console.SetCursorPosition(10, 4);// позиция курсора
//Console.WriteLine("+");


int xa = 40;
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 60;
int yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");


Console.SetCursorPosition(xb, yb);


int x = xa, y = ya;

int count = 0;

while (count < 10000)
{
    int ccc = new Random().Next(0, 3); 
    if (ccc == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
    if (ccc == 1 )
    {
        x = (x + xb)/2;
        y = (y+yb)/2;
    }
    if (ccc == 2 )
    {
         x = (x + xc)/2;
        y = (y+yc)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count+=1;
}