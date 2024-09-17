namespace Vector;

public abstract class Vector<T>
{
    public float x { get; set; }
    public float y { get; set; }
    public abstract T Up();
    public abstract T Down();
    public abstract T Left();
    public abstract T Right();
    public abstract T Add(T v);
    public abstract T Sub(T v);
    /// <summary>
    /// 向量与标量的乘法
    /// </summary>
    /// <param name="scalar">标量</param>
    /// <returns></returns>
    public abstract T Multiply<T1>(T1 scalar) where T1 : struct, IConvertible;

    public abstract bool Equals(T v);
    public abstract T Clone();
    public abstract override string ToString();
}