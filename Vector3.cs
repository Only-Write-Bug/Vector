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

    public static Vector3 operator /(Vector3 v1, float scalar)
    {
        return new Vector3(v1.x / scalar, v1.y / scalar, v1.z / scalar);
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
        return new Vector3(0,1,0);
    }

    public override Vector3 Down()
    {
        return new Vector3(0,-1,0);
    }

    public override Vector3 Left()
    {
        return new Vector3(-1,0,0);
    }

    public override Vector3 Right()
    {
        return new Vector3(1,0,0);
    }

    public Vector3 Forward()
    {
        return new Vector3(0,0,1);
    }

    public Vector3 Backward()
    {
        return new Vector3(0,0,-1);
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