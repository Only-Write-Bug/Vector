namespace Vector;

public class Vector2 : Vector<Vector2>
{
    public Vector2()
    {
        x = y = 0;
    }

    public Vector2(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public Vector2(Vector2 v)
    {
        this.x = v.x;
        this.y = v.y;
    }

    #region operator

    public static Vector2 operator +(Vector2 v1, Vector2 v2)
    {
        return new Vector2(v1.x + v2.x, v1.y + v2.y);
    }

    public static Vector2 operator -(Vector2 v1, Vector2 v2)
    {
        return new Vector2(v1.x - v2.x, v1.y - v2.y);
    }

    public static Vector2 operator *(Vector2 v1, float scalar)
    {
        return new Vector2(v1.x * scalar, v1.y * scalar);
    }

    public static Vector2 operator /(Vector2 v1, float scalar)
    {
        return new Vector2(v1.x / scalar, v1.y / scalar);
    }

    public static bool operator ==(Vector2 v1, Vector2 v2)
    {
        return v1.x == v2.x && v1.y == v2.y;
    }

    public static bool operator !=(Vector2 v1, Vector2 v2)
    {
        return !(v1 == v2);
    }

    #endregion

    public override Vector2 Up()
    {
        return new Vector2(0, 1);
    }

    public override Vector2 Down()
    {
        return new Vector2(0, 1);
    }

    public override Vector2 Left()
    {
        return new Vector2(-1, 0);
    }

    public override Vector2 Right()
    {
        return new Vector2(1, 0);
    }

    public override Vector2 Add(Vector2 v)
    {
        return this + v;
    }

    public override Vector2 Sub(Vector2 v)
    {
        return this - v;
    }

    public override Vector2 Multiply<T1>(T1 scalar)
    {
        var float_scalar = Convert.ToSingle(scalar);
        return this * float_scalar;
    }

    public override float Length()
    {
        return Convert.ToSingle(Math.Sqrt(this.x * this.x + this.y * this.y));
    }

    public override int CompareLength(Vector2 v)
    {
        const float epsilon = 0.00001f; // 容差值
        var this_len = this.x * this.x + this.y * this.y;
        var v_len = v.x * v.x + v.y * v.y;
        if (Math.Abs(v_len - this_len) < epsilon)
            return 0;
        return this_len - v_len > 0 ? 1 : -1;
    }

    public override float Distance(Vector2 v)
    {
        return Convert.ToSingle(Math.Sqrt((v.x - this.x) * (v.x - this.x) + (v.y - this.y) * (v.y - this.y)));
    }

    public override bool Equals(Vector2 v)
    {
        return this == v;
    }

    public override Vector2 Clone()
    {
        return new Vector2(this.x, this.y);
    }

    public override string ToString()
    {
        return $"(x:{this.x}, y:{this.y})";
    }
}