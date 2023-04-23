# 详解

这个程序分为两个类, 一个Program, 另一个是Extensions  
Extensions是一些await和Range的扩展方法  

在Program中, 有方法A,B,A1,A2,Main, Main方法指向MainProperty委托
然后有一个静态单例Instance, 一个实例字段Value

[第8行](https://github.com/ilyfairy/HelloWorld/blob/c66513d7cc922dd26dfb2089872e7e3737bf8979/HelloWorld/Program.cs#L8)是.net8的[主构造函数](https://github.com/dotnet/csharplang/issues/2691), 和record类似, 但是它的构造函数的参数是字段  
在第一次访问Instance的时候, 单例Program被实例化出来, 其中构造函数传入了一个"쌀",`Value = $"{value} "`,构造之后, Value是"쌀 ", 这个之后再看

## 开始

### 方法A1,A2

静态方法A1指向方法A2, 然后A1有一个特性[ModuleInitializer](https://learn.microsoft.com/zh-cn/dotnet/api/system.runtime.compilerservices.moduleinitializerattribute), 标注了这个特性的方法, 会在模块加载的时候被执行, 它会比Main先执行  
所以程序会最先执行A1, 然后才会执行Main方法

A1最开始执行, 它执行A2  
[第17行](https://github.com/ilyfairy/HelloWorld/blob/c66513d7cc922dd26dfb2089872e7e3737bf8979/HelloWorld/Program.cs#L17) 一开始定义了一个Random和int, 使用类似元组的方式定义两个变量  
然后进行for循环, rand是一个随机数生成器, 它会把生成的随机赋值s, 这里相当于把上一次的生成的随机数用作下一个随机数的种子   
`s = ((rand = rand is null ? new1 : new2).Next()) % 63 + 65`  
rand是null的时候, 初始化第一个Random, 种子的初始值是887464974, 然后根据它生成一个随机数赋值给s, 再把着整个表达式`%63+65`, 得到第一个数字, 再通过[扩展方法](https://github.com/ilyfairy/HelloWorld/blob/c66513d7cc922dd26dfb2089872e7e3737bf8979/HelloWorld/Extensions.cs#L7)从int转到char得到一个字符'H'  
通过给int增加GetAwaiter扩展方法可以让int进行await, 返回一个char  
以此类推, 第一次输入887464974得到1288584556运算后是'H', 再通过1288584556得到545047686运算后是'e'  
这样就得到了前两个字符"He", 它们会+=到Value中  

[第19行](https://github.com/ilyfairy/HelloWorld/blob/c66513d7cc922dd26dfb2089872e7e3737bf8979/HelloWorld/Program.cs#L19) 它主要的功能是把uint?的泛型参数改成int?, 也就是把`uint?` `Nullable<uint>`改成`int??` `Nullable<Nullable<int>>`类型  
通过修改方法表(MethodTable)来修改一个可空类型的泛型参数  
通过type.TypeHandle.Value来获取类型的方法表指针 `MethodTable*`  
在x64下, 偏移为11\*sizeof(IntPtr)字节是一个它的泛型参数, x86是13\*sizeof(IntPtr)

[第20行](https://github.com/ilyfairy/HelloWorld/blob/c66513d7cc922dd26dfb2089872e7e3737bf8979/HelloWorld/Program.cs#L20) 通过`Path.InvalidPathChars`和`Path.InvalidPathChars[..]`进行比较arr[..]是它的拷贝, 所以为`False` 然后获取它的索引  
获取`$"{typeof(uint?)}"`里有多少个``` ` ```  
由于刚刚把uint?修改成了int??, 所以typeof(uint?).ToString()后是```System.Nullable`1[System.Nullable`1[System.Int32]]```  
里面有两个``` ` ```, 所以获取索引为2的字符, 也就是字符'l'  
`xx.ToString()[xx.Count()]`

然后[第21行](https://github.com/ilyfairy/HelloWorld/blob/c66513d7cc922dd26dfb2089872e7e3737bf8979/HelloWorld/Program.cs#L21)给程序退出加了个事件, 它将是最后执行的代码, 之后再看  

## Main方法(MainProperty)

定义了一个本地方法F

