Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int Xa = 1;
int Ya = 1;
int Xb = 1;
int Yb = 30;
int Xc = 80;
int Yc = 30;
Console.SetCursorPosition(Xa, Ya);
Console.WriteLine("+");

Console.SetCursorPosition(Xb, Yb);
Console.WriteLine("+");

Console.SetCursorPosition(Xc, Yc);
Console.WriteLine("+");

int x = Xa, y = Ya;

int count = 0;

while(count<5000)
{
    int what = new Random().Next(1, 4); // 0 1 2
    if (what == 1)
    { 
    x = (x+Xa)/2;
    y = (y+Ya)/2;
    }
    if (what == 2)
    {
    x = (x+Xb)/2;
    y = (y+Yb)/2;
    }
    if (what == 3)
    {
    x = (x+Xc)/2;
    y = (y+Yc)/2;
    }
Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count++;
}