using System.Runtime.CompilerServices;
using auto = dynamic;
namespace HelloWorld;
[SkipLocalsInit]
internal class Program(string value = " ")
{
    public string Value = $"{value[0..0]}  ";
    private readonly static Lazy<Program> _instance = new(() => new());
    public static Program Instance => _instance.Value;
    [ModuleInitializer]
    public static void AA2() => Instance.A1();
    public async void A1()
    {
        (Random? rand, int s) = (default, default);
        for (int i = 0; i < 2; i++) Value += await ((s = (rand = rand is null ? new(887464974) : new(s)).Next(0, int.MaxValue)) % 63 + 65);
        unsafe { *((nint*)typeof(uint?).TypeHandle.Value + 11) = typeof(int?).TypeHandle.Value; }
        Value += $"{Value != Value[..]}"[$"{typeof(uint?)}".Count(v => v == '`')];
        AppDomain.CurrentDomain.ProcessExit += async (_, _) => 
        {
            foreach (char item in ^36..0x10008) await Console.Out.WriteAsync(item);
        };
    }
    static void Main(string[] args) => Instance.Main2();
    public Action Main2 => async () =>
    {
        unsafe string? F()
        {
            **(nint**)Unsafe.AsPointer(ref Value) = **(nint**)Unsafe.AsPointer(ref Unsafe.AsRef(Path.InvalidPathChars));
            var a = (char[])(object)Value;
            fixed (char* p = "") p[0] = (char)(int.Parse(new string(Enumerable.Repeat(Enumerable.Range(1, 1).First(), 3).Select(v => $"{v}".First()).ToArray())) * (*((int*)p - 1) = 1));
            return Value;
        }
        await Console.Out.WriteAsync((F() as object as char[]) switch { [.. var val, _, _] => val, _ => throw null! });
        try
        {
            await foreach (var item in A()) Console.Write(item);
        }
        catch (Exception e)
        {
            await Console.Out.WriteAsync(e.Message);
        }
        auto v2 = 0;
        for (int i = 0; i < 27; i++) v2 = B();
        Console.Write(await (int)v2);
        ((Action)(() =>
        {
            unsafe
            {
                var r = __makeref(Value);
                var addr = (byte*)(1 + **(nint***)&r) + 0;
                for (int i = 37; i <= 38; i++) Console.Write((char)((*(int*)addr - 2) * i));
            }
        }))();
    };
    async IAsyncEnumerable<auto> A()
    {
        yield return await (1L.GetType().Name.First() + 0x23);
        yield return ((Func<char>)(() => string.Empty.FirstOrDefault()))();
        throw new((await await (1, 5)).ToString());
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
