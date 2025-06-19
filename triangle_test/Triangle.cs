public class Triangle
{
    public static bool CanFormTriangle(int a, int b, int c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}
