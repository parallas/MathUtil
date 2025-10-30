using Microsoft.Xna.Framework;

namespace Parallas;

public static class MathUtil
{
    public static float Approach(float value, float target, float rate)
    {
        if(value < target)
            return Math.Min(value + rate, target);
        else
            return Math.Max(value - rate, target);
    }

    public static float Approach(ref float value, float target, float rate)
    {
        if(value < target)
            value = Math.Min(value + rate, target);
        else
            value = Math.Max(value - rate, target);
        return value;
    }

    public static int Approach(int value, int target, int rate)
    {
        if(value < target)
            return Math.Min(value + rate, target);
        else
            return Math.Max(value - rate, target);
    }

    public static int Approach(ref int value, int target, int rate)
    {
        if(value < target)
            value = Math.Min(value + rate, target);
        else
            value = Math.Max(value - rate, target);
        return value;
    }

    public static Vector3 Approach(Vector3 value, Vector3 target, float rate)
    {
        if (value == target)
            return target;
        Vector3 direction = Vector3.Normalize(target - value);
        Vector3 moveAmount = direction * rate;
        if (Vector3.DistanceSquared(value, value + moveAmount) > Vector3.DistanceSquared(value, target))
            return target;
        return value + moveAmount;
    }

    public static float ApproachNotExceeding(float value, float target, float rate)
    {
        if(Math.Abs(value) < Math.Abs(target))
            value = Approach(value, target, rate);
        return value;
    }

    public static Vector3 ApproachNotExceeding(Vector3 value, Vector3 target, float rate)
    {
        return new(
            ApproachNotExceeding(value.X, target.X, rate),
            ApproachNotExceeding(value.Y, target.Y, rate),
            ApproachNotExceeding(value.Z, target.Z, rate)
        );
    }

    public static float MoveTo(float value, float target, float accel, float decel)
    {
        if(Math.Abs(value) < Math.Abs(target))
            value = Approach(value, target, accel);
        if(Math.Abs(value) > Math.Abs(target))
            value = Approach(value, target, decel);
        return value;
    }

    public static Vector3 MoveTo(Vector3 value, Vector3 target, float accel, float decel)
    {
        return new(
            MoveTo(value.X, target.X, accel, decel),
            MoveTo(value.Y, target.Y, accel, decel),
            MoveTo(value.Z, target.Z, accel, decel)
        );
    }

    public static Vector2 MoveTo(Vector2 value, Vector2 target, float accel, float decel)
    {
        return new(
            MoveTo(value.X, target.X, accel, decel),
            MoveTo(value.Y, target.Y, accel, decel)
        );
    }

    public static bool WillOvershoot(Vector3 current, Vector3 target, Vector3 velocity)
    {
        if (current == target)
            return true;
        if (Vector3.DistanceSquared(current, current + velocity) > Vector3.DistanceSquared(current, target))
            return true;
        return false;
    }

    public static float Sqrt(float value)
    {
        return MathF.Sqrt(value);
    }

    public static float Sqr(float value)
    {
        return value*value;
    }

    public static int Sqr(int value)
    {
        return value*value;
    }

    public static T Sqr<T>(T value) where T : System.Numerics.IMultiplyOperators<T, T, T>
    {
        return value*value;
    }

    public static float Snap(float value, float interval)
    {
        return MathF.Floor(value / interval) * interval;
    }

    public static float Snap(ref float value, float interval)
    {
        value = MathF.Floor(value / interval) * interval;
        return value;
    }

    public static Vector2 Snap(Vector2 value, Vector2 interval)
    {
        value.X = Snap(value.X, interval.X);
        value.Y = Snap(value.Y, interval.Y);
        return value;
    }

    public static Vector2 Snap(ref Vector2 value, Vector2 interval)
    {
        value.X = Snap(value.X, interval.X);
        value.Y = Snap(value.Y, interval.Y);
        return value;
    }

    public static Vector2 Snap(Vector2 value, float interval)
    {
        value.X = Snap(value.X, interval);
        value.Y = Snap(value.Y, interval);
        return value;
    }

    public static Vector2 Snap(ref Vector2 value, float interval)
    {
        value.X = Snap(value.X, interval);
        value.Y = Snap(value.Y, interval);
        return value;
    }

    public static float SnapCeiling(float value, float interval)
    {
        return MathF.Ceiling(value / interval) * interval;
    }

    public static float SnapCeiling(ref float value, float interval)
    {
        value = MathF.Ceiling(value / interval) * interval;
        return value;
    }

    public static Vector2 SnapCeiling(Vector2 value, Vector2 interval)
    {
        value.X = SnapCeiling(value.X, interval.X);
        value.Y = SnapCeiling(value.Y, interval.Y);
        return value;
    }

    public static Vector2 SnapCeiling(ref Vector2 value, Vector2 interval)
    {
        value.X = SnapCeiling(value.X, interval.X);
        value.Y = SnapCeiling(value.Y, interval.Y);
        return value;
    }

    public static Vector2 SnapCeiling(Vector2 value, float interval)
    {
        value.X = SnapCeiling(value.X, interval);
        value.Y = SnapCeiling(value.Y, interval);
        return value;
    }

    public static Vector2 SnapCeiling(ref Vector2 value, float interval)
    {
        value.X = SnapCeiling(value.X, interval);
        value.Y = SnapCeiling(value.Y, interval);
        return value;
    }

    public static int AbsMax(int value, int max)
    {
        return Math.Max(Math.Abs(value), Math.Abs(max)) * Math.Sign(value);
    }

    public static int AbsMin(int value, int min)
    {
        return Math.Min(Math.Abs(value), Math.Abs(min)) * Math.Sign(value);
    }

    public static int RoundToInt(float value)
    {
        return (int)Math.Round(value);
    }

    public static int CeilToInt(float value)
    {
        return (int)Math.Ceiling(value);
    }

    public static int FloorToInt(float value)
    {
        return (int)Math.Floor(value);
    }

    public static int ClampToInt(float value, int a, int b)
    {
        return (int)Math.Clamp(value, a, b);
    }

    public static float InverseLerp(float a, float b, float t)
    {
        return (t - a)/(b - a);
    }

    public static float InverseLerp01(float a, float b, float t)
    {
        return Clamp01((t - a)/(b - a));
    }

    public static float Clamp01(float value)
    {
        return Math.Clamp(value, 0, 1);
    }

    /// <summary>
    /// Exponential decay function
    /// </summary>
    /// <param name="a">Start value</param>
    /// <param name="b">Destination value</param>
    /// <param name="decay">Useful range approx. 1 to 25, from slow to fast. 16 is a good default.</param>
    /// <param name="dt">Delta Time (in seconds)</param>
    /// <returns></returns>
    public static float ExpDecay(float a, float b, float decay, float dt)
    {
        return b+(a-b)*MathF.Exp(-decay*dt);
    }

    public static Vector2 ExpDecay(Vector2 a, Vector2 b, float decay, float dt)
    {
        return b+(a-b)*MathF.Exp(-decay*dt);
    }

    public static Vector3 ExpDecay(Vector3 a, Vector3 b, float decay, float dt)
    {
        return b+(a-b)*MathF.Exp(-decay*dt);
    }

    public static Quaternion ExpDecay(Quaternion a, Quaternion b, float decay, float dt)
    {
        return Quaternion.Slerp(a, b, 1 - MathF.Exp(-decay * dt));
    }

    public static int Sign(float a)
    {
        return MathF.Sign(a);
    }

    public static bool Approximately(float a, float b, float threshold)
    {
        return MathF.Abs(a - b) < threshold;
    }

    public static float SmoothCos(float value, float exp)
    {
        return MathF.Pow(-0.5f * MathF.Cos(value * MathF.PI) + 0.5f, exp);
    }

    public static float SmoothCosClamp(float value, float exp)
    {
        return SmoothCos(Clamp01(value), exp);
    }

    public static float RandomRange(float min, float max)
    {
        return Random.Shared.NextSingle() * (max - min) + min;
    }

    public static int RandomRange(int min, int max)
    {
        return (int)Random.Shared.NextInt64(min, max);
    }

    public static Vector3 RandomInsideUnitSphere() {
        var u = Random.Shared.NextSingle();
        var v = Random.Shared.NextSingle();
        var theta = u * 2.0f * MathF.PI;
        var phi = MathF.Acos(2.0f * v - 1.0f);
        var r = MathF.Cbrt(Random.Shared.NextSingle());
        var sinTheta = MathF.Sin(theta);
        var cosTheta = MathF.Cos(theta);
        var sinPhi = MathF.Sin(phi);
        var cosPhi = MathF.Cos(phi);
        var x = r * sinPhi * cosTheta;
        var y = r * sinPhi * sinTheta;
        var z = r * cosPhi;
        return new Vector3(x, y, z);
    }

    public static Vector3 Project(Vector3 vector, Vector3 onNormal)
    {
        if (vector == Vector3.Zero) return Vector3.Zero;
        float num = Vector3.Dot(onNormal, onNormal); // This is right
        if (num < float.Epsilon || !float.IsNormal(num))
            return Vector3.Zero;
        return onNormal * Vector3.Dot(vector, onNormal) / num;
    }

    public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
    {
        if (vector == Vector3.Zero) return Vector3.Zero;
        return vector - Project(vector, planeNormal);
    }

    public static Vector3 RandomVector3(float min, float max)
    {
        return new(
            Random.Shared.NextSingle() * (max - min) + min,
            Random.Shared.NextSingle() * (max - min) + min,
            Random.Shared.NextSingle() * (max - min) + min
        );
    }

    public static Vector3 RandomVector3(Vector3 min, Vector3 max)
    {
        return new(
            Random.Shared.NextSingle() * (max.X - min.X) + min.X,
            Random.Shared.NextSingle() * (max.Y - min.Y) + min.Y,
            Random.Shared.NextSingle() * (max.Z - min.Z) + min.Z
        );
    }

    public static Vector3 SquashScale(float height)
    {
        return new(
            1f/height,
            height,
            1f/height
        );
    }

    public static float Mod(float a, float b)
    {
        return ((a % b) + b) % b;
    }

    public static Vector2 Mod(Vector2 a, Vector2 b)
    {
        return new Vector2(Mod(a.X, b.X), Mod(a.Y, b.Y));
    }

    public static Vector3 Mod(Vector3 a, Vector3 b)
    {
        return new Vector3(Mod(a.X, b.X), Mod(a.Y, b.Y), Mod(a.Z, b.Z));
    }

    public static (ushort first, ushort second) Split(uint value)
    {
        ushort first = (ushort)(value >> 16);
        ushort second = (ushort)(value & ushort.MaxValue);
        return (first, second);
    }

    public static (byte first, byte second) Split(ushort value)
    {
        byte first = (byte)(value >> 8);
        byte second = (byte)(value & byte.MaxValue);
        return (first, second);
    }

    public static uint Join(ushort firstHalf, ushort secondHalf)
    {
        uint first = firstHalf;
        uint second = secondHalf;
        return first << 16 | second & 0xffff;
    }

    public static ushort Join(byte firstHalf, byte secondHalf)
    {
        ushort first = firstHalf;
        ushort second = secondHalf;
        return (ushort)(first << 8 | second & 0xff);
    }

    public static ushort Merge(ushort first, ushort second)
    {
        return (ushort)((first << 8) | (second & 0xff));
    }

    public static Vector3 ToVector3(this Vector2 vector, bool yTangent = false, float tangent = 0f)
    {
        return yTangent ? new Vector3(vector.X, tangent, vector.Y) : new Vector3(vector.X, vector.Y, tangent);
    }

    public static Vector3 ToVector3(this Point vector, bool yTangent = false, float tangent = 0f)
    {
        return ToVector3(vector.ToVector2(), yTangent, tangent);
    }

    public static Vector2 ToVector2(this Point vector)
    {
        return new Vector2(vector.X, vector.Y);
    }

    public static Vector2 ToVector2(this Vector3 vector, bool yTangent = false)
    {
        return new Vector2(vector.X, yTangent ? vector.Z : vector.Y);
    }

    public static Point ToPoint(this Vector2 vector)
    {
        return new Point((int)vector.X, (int)vector.Y);
    }

    public static float ResponseCurveSine(float x)
    {
        const float halfPi = MathF.PI / 2.0f;
        return Math.Sign(x) * (-MathF.Sin(halfPi * x + halfPi) + 1.0f);
    }

    public static double ResponseCurveSine(double x)
    {
        const double halfPi = Math.PI / 2.0;
        return Math.Sign(x) * (-Math.Sin(halfPi * x + halfPi) + 1.0);
    }

    // broken for unknown reason
    public static float ResponseCurveTan(float x)
    {
        const float quarterPi = MathF.PI / 4.0f;
        return MathF.Pow(MathF.Tan(quarterPi * x), 1.4f);
    }

    public static double ResponseCurveTan(double x)
    {
        const double quarterPi = MathF.PI / 4.0;
        return Math.Pow(Math.Tan(quarterPi * x), 1.4);
    }

    // Source: http://allenchou.net/2015/04/game-math-precise-control-over-numeric-springing/
    public static void Spring(ref float current, ref float velocity, float target, float dampingRatio, float frequency, float deltaTime)
    {
        float f = 1.0f + 2.0f * deltaTime * dampingRatio * frequency;
        float oo = frequency * frequency;
        float hoo = deltaTime * oo;
        float hhoo = deltaTime * hoo;
        float detInv = 1.0f / (f + hhoo);
        float detX = f * current + deltaTime * velocity + hhoo * target;
        float detV = velocity + hoo * (target - current);
        current = detX * detInv;
        velocity = detV * detInv;
    }

    public static void Spring(ref Vector2 current, ref Vector2 velocity, Vector2 target, float dampingRatio, float frequency, float deltaTime)
    {
        Spring(ref current.X, ref velocity.X, target.X, dampingRatio, frequency, deltaTime);
        Spring(ref current.Y, ref velocity.Y, target.Y, dampingRatio, frequency, deltaTime);
    }

    public static void Spring(ref Vector3 current, ref Vector3 velocity, Vector3 target, float dampingRatio, float frequency, float deltaTime)
    {
        Spring(ref current.X, ref velocity.X, target.X, dampingRatio, frequency, deltaTime);
        Spring(ref current.Y, ref velocity.Y, target.Y, dampingRatio, frequency, deltaTime);
        Spring(ref current.Z, ref velocity.Z, target.Z, dampingRatio, frequency, deltaTime);
    }

    public static Vector2 RandomVector2InRect(Rectangle rect)
    {
        return new Vector2(
            RandomRange(rect.X, rect.X + rect.Size.X),
            RandomRange(rect.Y, rect.Y + rect.Size.Y)
        );
    }

    public static Point RandomPointInRect(Rectangle rect)
    {
        return new Point(
            RandomRange(rect.X, rect.X + rect.Size.X),
            RandomRange(rect.Y, rect.Y + rect.Size.Y)
        );
    }

    public static Vector2 BezierPoint(float t, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
    {
        var a1 = Vector2.Lerp(p0, p1, t);
        var b1 = Vector2.Lerp(p1, p2, t);
        var c1 = Vector2.Lerp(p2, p3, t);

        var a1b1 = Vector2.Lerp(a1, b1, t);
        var b1c1 = Vector2.Lerp(b1, c1, t);

        var finalPoint = Vector2.Lerp(a1b1, b1c1, t);
        return finalPoint;
    }

    public static Vector2 BezierPoint(float t, Vector2 p0, Vector2 p1, Vector2 p2)
    {
        var a1 = Vector2.Lerp(p0, p1, t);
        var b1 = Vector2.Lerp(p1, p2, t);

        var a1b1 = Vector2.Lerp(a1, b1, t);

        return a1b1;
    }

    public static (float h, float s, float l) HsvToHsl(float h, float s, float v)
    {
        float l = v * (1f - s / 2f);
        s = l is 0 or 1 ? 0f : (v - l) / MathF.Min(l, 1 - l);
        return (h, s, l);
    }

    public static (float h, float s, float v) HslToHsv(float h, float s, float l)
    {
        float v = l + s * MathF.Min(l, 1 - l);
        s = (v is 0) ? 0f : 2 * (1f - l / v);
        return (h, s, v);
    }

    public static float DegToRad(float degrees)
    {
        return MathHelper.ToRadians(degrees);
    }

    public static double DegToRad(double degrees)
    {
        return degrees * (Math.PI / 180.0);
    }

    public static float RadToDeg(float radians)
    {
        return MathHelper.ToDegrees(radians);
    }

    public static double RadToDeg(double radians)
    {
        return radians * (180.0 / Math.PI);
    }

    // Code based on https://gist.github.com/HelloKitty/91b7af87aac6796c3da9
    public static Quaternion AngleAxis(float radians, Vector3 axis)
    {
        return Quaternion.CreateFromAxisAngle(axis, radians);
    }

    public static Quaternion AngleAxisDegrees(float degrees, Vector3 axis)
    {
        return AngleAxis(MathHelper.ToRadians(degrees), axis);
    }

    public static Matrix RotateAround(this Matrix transform3D, Vector3 point, Vector3 axis, float angle)
    {
        return transform3D * Matrix.CreateTranslation(-point) * Matrix.CreateFromAxisAngle(axis, angle) * Matrix.CreateTranslation(point);
    }

    public static Vector3 TranslateAround(this Vector3 vector, Vector3 point, Quaternion rotation)
    {
        vector = point + Vector3.Transform(vector - point, rotation);
        return vector;
    }
}
