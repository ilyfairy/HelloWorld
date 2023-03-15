using System.Runtime.CompilerServices;
namespace HelloWorld;

public static class Extensions
{
    public static ValueTaskAwaiter<int> GetAwaiter(this (int n, int v) val) => ValueTask.FromResult(val.n << val.v).GetAwaiter();
    public static ValueTaskAwaiter<char> GetAwaiter(this int val) => ValueTask.FromResult((char)val).GetAwaiter();
    public static IEnumerator<int> GetEnumerator(this Range val)
    {
        int start = val.Start.Value * 3;
        yield return start;
        if (val.Start.IsFromEnd) yield return start - val.End.Value;
        else yield return start + val.End.Value;
    }
}
