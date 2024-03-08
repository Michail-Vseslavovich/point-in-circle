Console.WriteLine("введите координаты вашей уникальной, неповторимой, просто прелесной точки через enter:");

Point point;

point.X = float.Parse(Console.ReadLine());
point.Y = float.Parse(Console.ReadLine());

Console.WriteLine("А теперь введите радиус окружности , чтобы проверить, находится ли точка в ее пределах");

float rad = float.Parse(Console.ReadLine());
point.Inrad(rad);


struct Point
{
    public float X;
    public float Y;

    public void Inrad(float rad)
    {
        if (Math.Pow(X, 2) + Math.Pow(Y, 2) < Math.Pow(rad, 2))
        {
            Console.WriteLine("Точка находится в пределах окружности");
        }
        else
        {
            Console.WriteLine("Точка не в пределах окружности");
        }
    }
}