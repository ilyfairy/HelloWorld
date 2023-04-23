#pragma warning disable CS8500
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using unsafe VirtualProtectDelegate = delegate* unmanaged<void*, nint, uint, in nint, void>;
using auto = dynamic;
namespace HelloWorld;
[SkipLocalsInit]
internal class Program(string value = "  ")
{
    public string Value = $"{value[0..0]}쌀 ";
    private readonly static Lazy<Program> _instance = new(() => new());
    public static Program Instance => _instance.Value;
    [ModuleInitializer]
    public static void A1() => Instance.A2();
    public async void A2()
    {
        (Random? rand, int s) = (default, default);
        for (int i = 0; i < 2; i++) Value += await ((s = (rand = rand is null ? new(887464974) : new(s)).Next(0, int.MaxValue)) % 63 + 65);
        unsafe { *((nint*)typeof(uint?).TypeHandle.Value + (nint.Size == 8 ? 11 : 13)) = typeof(int?).TypeHandle.Value; }
        Value += $"{Path.InvalidPathChars == Path.InvalidPathChars[..]}"[$"{typeof(uint?)}".Count(v => v == '`')];
        AppDomain.CurrentDomain.ProcessExit += async (_, _) =>
        {
            foreach (char item in ^36..8) await Console.Out.WriteAsync(item);
            unsafe
            {   
                Value += new string('\0', 8627);
                fixed(char* p = Value)
                {
                    ((VirtualProtectDelegate)NativeLibrary.GetExport(NativeLibrary.Load("kernel32"), "VirtualProtect"))(p - 2, 8, 0x40, 0);
                    Console.Write(((delegate* unmanaged<char>)(p - 2))());
                }
            }
        };
    }
    static void Main(string[] args) => Instance.MainProperty();
    public Action MainProperty => async () =>
    {
        unsafe string? F()
        {
            fixed (char* p = "") 
            fixed (char* p2 = Value)
            {
                p[0] = (char)(int.Parse(new string(Enumerable.Repeat(Enumerable.Range(1, 1).First(), 3).Select(v => $"{v}".First()).ToArray())) * (*((int*)p - 1) = 1));
            }
            **(nint**)Unsafe.AsPointer(ref Value) = **(nint**)Unsafe.AsPointer(ref Unsafe.AsRef(Path.InvalidPathChars));
            var chars = Value as object as char[];
            return Value;
        }
        await Console.Out.WriteAsync((F() as object as char[]) switch { [.. var val] => val[(-(nint.Size - 8) / 2)..(val.Length - (nint.Size - 4) / 2)], _ => throw null! });
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
#pragma warning restore CS8500