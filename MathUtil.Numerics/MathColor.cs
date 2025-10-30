using System.Drawing;

namespace Parallas;

/// <summary>
/// Source code: https://github.com/parallas/MathUtil
/// </summary>
public static class MathColor
{
    public static Color CornflowerBlue { get; } = Color.FromArgb(100, 149, 237);

    public static Color ExpDecay(Color a, Color b, float decay, float dt)
    {
        return b.Add(a.Subtract(b)).Multiply(MathF.Exp(-decay*dt));
    }

    public static Color Add(this Color a, Color b)
    {
        return Color.FromArgb(Math.Min(a.A + b.A, 255), Math.Min(a.R + b.R, 255), Math.Min(a.G + b.G, 255), Math.Min(a.B + b.B, 255));
    }

    public static Color Subtract(this Color a, Color b)
    {
        return Color.FromArgb(Math.Min(a.A - b.A, 255), Math.Min(a.R - b.R, 255), Math.Min(a.G - b.G, 255), Math.Min(a.B - b.B, 255));
    }

    public static Color Multiply(this Color a, Color b)
    {
        return Color.FromArgb(Math.Min(a.A * b.A, 255), Math.Min(a.R * b.R, 255), Math.Min(a.G * b.G, 255), Math.Min(a.B * b.B, 255));
    }

    public static Color Divide(this Color a, Color b)
    {
        return Color.FromArgb(Math.Min(MathUtil.FloorToInt(a.A / (float)b.A), 255), Math.Min(MathUtil.FloorToInt(a.R / (float)b.R), 255), Math.Min(MathUtil.FloorToInt(a.G / (float)b.G), 255), Math.Min(MathUtil.FloorToInt(a.B / (float)b.B), 255));
    }

    public static Color Multiply(this Color a, float b)
    {
        return Color.FromArgb(Math.Min(MathUtil.FloorToInt(a.A * b), 255), Math.Min(MathUtil.FloorToInt(a.R * b), 255), Math.Min(MathUtil.FloorToInt(a.G * b), 255), Math.Min(MathUtil.FloorToInt(a.B * b), 255));
    }

    public static Color Divide(this Color a, float b)
    {
        return Color.FromArgb(Math.Min(MathUtil.FloorToInt(a.A / b), 255), Math.Min(MathUtil.FloorToInt(a.R / b), 255), Math.Min(MathUtil.FloorToInt(a.G / b), 255), Math.Min(MathUtil.FloorToInt(a.B / b), 255));
    }
}
