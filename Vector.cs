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
    public abstract float Dot(T v);
    public abstract double Angle(T v);
    /// <summary>
    /// this 在v上的平行向量
    /// </summary>
    /// <param name="v"></param>
    /// <returns></returns>
    public abstract T ParallelVector(T v);
    public abstract float Length();
    public abstract T Normalized();
    /// <summary>
    /// 对比两向量的长度
    /// </summary>
    /// <returns>0:相似 1:大于 -1:小于</returns>
    public abstract int CompareLength(T v);
    public abstract float Distance(T v);
    public abstract bool Equals(T v);
    public abstract T Clone();
    public abstract override string ToString();
}