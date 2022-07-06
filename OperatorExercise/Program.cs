

    static void Addition()
{
    int x = 10;
    int y = 10;
    x += y;
    Console.WriteLine(x);
}
    static void Subtraction()
{
    int e = 20;
    int f = 10;
    e -= f;
    Console.WriteLine(e);
}
    static void Multiplication()
{
    int c = 2;
    int d = 4;
    c *= d;
    Console.WriteLine(c);
}
    static void Division()
{
    int a = 17;
    int b = 4;
    int quotient =  a / b;
    int remainder = a % b;
    Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
}
    static void Modulus()
{
    int g = 10;
    int h = 11;
    g %= h;
    Console.WriteLine(g);
}

static double AreaOfCircle(double r)
{
    double area = Math.PI * Math.Pow(r, 2);

    return area;
}


    Division();

Console.WriteLine("What is the radius of your circle?");
var radius = double.Parse(Console.ReadLine());
Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)} ");




    
    












    