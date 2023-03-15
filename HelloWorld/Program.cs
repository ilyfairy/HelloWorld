using System.Runtime.CompilerServices;
using Auto = System.Object;
namespace HelloWorld;
[SkipLocalsInit]
internal class Program(string val = " ")
{
    public string Val = $"{val[0..0]}";
    private static Lazy<Program> _val = new(() => new());
    public static Program Instance => _val.Value;
    [ModuleInitializer]
    public static void AA2() => Instance.A1();
    public async void A1()
    {
        Random? rand = null;
        int s = 0;
        for (int i = 0; i < 2; i++) Val += await ((s = (rand = rand is null ? new(887464974) : new(s)).Next(0, int.MaxValue)) % 63 + 65);
        Val += $"{Val != Val[..]}"[2];
        AppDomain.CurrentDomain.ProcessExit += async (_, _) => { foreach (char item in ^36..0x10008) await Console.Out.WriteAsync(item); };
    }
    static void Main(string[] args) => Instance.Main2();
    public Action Main2 => async () =>
    {
        unsafe string? F()
        {
            fixed (char* p = "") p[0] = (char)(int.Parse(new string(Enumerable.Repeat(Enumerable.Range(1, 1).First(), 3).Select(v => $"{v}".First()).ToArray())) * (*((int*)p - 1) = 1));
            return Val;
        }
        await Console.Out.WriteAsync(new[] { F(), new object { } } switch { [string val, ..] => val, _ and [] or [..] and not null or null => null });
        await foreach (var item in A()) Console.Write(item);
        Auto v2 = 0;
        for (int i = 0; i < 27; i++) v2 = B();
        Console.Write(await(int)v2);
        ((Action)(() =>
        {
            unsafe
            {
                var r = __makeref(Val);
                var addr = 1 + **(nint***)&r;
                for (int i = 37; i <= 38; i++) Console.Write((char)(*(int*)addr * i));
            }
        }))();
    };
    async IAsyncEnumerable<Auto> A()
    {
        yield return await (1L.GetType().Name.First() + 0x23);
        yield return ((Func<char>)(() => string.Empty.FirstOrDefault()))();
        yield return await await (1, 5);
    }
    unsafe int B()
    {
        int* val = stackalloc int[2];
        if (val[0] != 12345678)
        {
            val[0] = 12345678;
            val[1] = 60;
        }
        return ++val[1];
    }
}
