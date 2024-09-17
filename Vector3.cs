namespace Vector;

public class Vector3 : Vector<Vector3>
{
    public float z { get; set; }

    public Vector3()
    {
        x = y = z = 0;
    }

    public Vector3(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Vector3(Vector3 v)
    {
        this.x = v.x;
        this.y = v.y;
        this.z = v.z;
    }

    #region operator

    public static Vector3 operator +(Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
    }

    public static Vector3 operator -(Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
    }

    public static Vector3 operator *(Vector3 v1, float scalar)
    {
        return new Vector3(v1.x * scalar, v1.y * scalar, v1.z * scalar);
    }
    
    public static Vector3 operator *(Vector3 v1, double scalar)
    {
        return new Vector3((float)(v1.x * scalar), (float)(v1.y * scalar), (float)(v1.z * scalar));
    }

    public static Vector3 operator /(Vector3 v1, float scalar)
    {
        return new Vector3(v1.x / scalar, v1.y / scalar, v1.z / scalar);
    }
    
    public static Vector3 operator /(Vector3 v1, double scalar)
    {
        return new Vector3((float)(v1.x / scalar), (float)(v1.y / scalar), (float)(v1.z / scalar));
    }

    public static bool operator ==(Vector3 v1, Vector3 v2)
    {
        return v1.x == v2.x && v1.y == v2.y && v1.z == v2.z;
    }

    public static bool operator !=(Vector3 v1, Vector3 v2)
    {
        return !(v1 == v2);
    }

    #endregion

    public override Vector3 Up()
    {
        return new Vector3(0, 1, 0);
    }

    public override Vector3 Down()
    {
        return new Vector3(0, -1, 0);
    }

    public override Vector3 Left()
    {
        return new Vector3(-1, 0, 0);
    }

    public override Vector3 Right()
    {
        return new Vector3(1, 0, 0);
    }

    public Vector3 Forward()
    {
        return new Vector3(0, 0, 1);
    }

    public Vector3 Backward()
    {
        return new Vector3(0, 0, -1);
    }

    public override Vector3 Add(Vector3 v)
    {
        return this + v;
    }

    public override Vector3 Sub(Vector3 v)
    {
        return this - v;
    }

    public override Vector3 Multiply<T1>(T1 scalar)
    {
        var float_scalar = Convert.ToSingle(scalar);
        return this * float_scalar;
    }

    public override float Dot(Vector3 v)
    {
        return this.x * v.x + this.y * v.y + this.z * v.z;
    }

    public override double Angle(Vector3 v)
    {
        return Math.Acos(this.Dot(v) / (this.Length() * v.Length()));
    }

    public override Vector3 ParallelVector(Vector3 v)
    {
        var result = v * (this.Length() * Math.Cos(this.Angle(v)) / v.Length());
        return result;
    }

    public override float Length()
    {
        return Convert.ToSingle(Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z));
    }

    public override int CompareLength(Vector3 v)
    {
        const float epsilon = 0.00001f; // 容差值
        var this_len = this.x * this.x + this.y * this.y + this.z * this.z;
        var v_len = v.x * v.x + v.y * v.y + v.z * v.z;
        if (Math.Abs(v_len - this_len) < epsilon)
            return 0;
        return this_len - v_len > 0 ? 1 : -1;
    }

    public override float Distance(Vector3 v)
    {
        return Convert.ToSingle(Math.Sqrt((v.x - this.x) * (v.x - this.x) + (v.y - this.y) * (v.y - this.y) +
                                          (v.z - this.z) * (v.z - this.z)));
    }

    public override bool Equals(Vector3 v)
    {
        return this == v;
    }

    public override Vector3 Clone()
    {
        return new Vector3(this.x, this.y, this.z);
    }

    public override string ToString()
    {
        return $"(x:{this.x}, y:{this.y}, z:{this.z})";
    }
}