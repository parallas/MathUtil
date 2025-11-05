using Godot;

namespace Parallas;

/// <summary>
/// Source code: https://github.com/parallas/MathUtil
/// </summary>
public static class MathColor
{
    public static Color CornflowerBlue { get; } = new(100/255f, 149/255f, 237/255f);

    public static Color ExpDecay(Color a, Color b, float decay, float dt)
    {
        return b.Add(a.Subtract(b)).Multiply(Mathf.Exp(-decay*dt));
    }

    public static Color Add(this Color a, Color b)
    {
        return a + b;
    }

    public static Color Subtract(this Color a, Color b)
    {
        return a - b;
    }

    public static Color Multiply(this Color a, Color b)
    {
        return a * b;
    }

    public static Color Divide(this Color a, Color b)
    {
        return a / b;
    }

    public static Color Multiply(this Color a, float b)
    {
        return a * b;
    }

    public static Color Divide(this Color a, float b)
    {
        return a / b;
    }
}
