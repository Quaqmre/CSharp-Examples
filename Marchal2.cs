// public static void WorkWithSpans()
// {
//     // Create a span over an array.
//     var array = new byte[100];
//     var arraySpan = new Span<byte>(array);

//     InitializeSpan(arraySpan);
//     Console.WriteLine($"The sum is {ComputeSum(arraySpan):N0}");

//     // Create an array from native memory.
//     var native = Marshal.AllocHGlobal(100);
//     Span<byte> nativeSpan;
//     unsafe
//     {
//         nativeSpan = new Span<byte>(native.ToPointer(), 100);
//     }

//     InitializeSpan(nativeSpan);
//     Console.WriteLine($"The sum is {ComputeSum(arraySpan):N0}");

//     Marshal.FreeHGlobal(native);

//     // Create a span on the stack.
//     Span<byte> stackSpan = stackalloc byte[100];

//     InitializeSpan(stackSpan);
//     Console.WriteLine($"The sum is {ComputeSum(arraySpan):N0}");
// }

// public static void InitializeSpan(Span<byte> span)
// {
//     byte value = 0;
//     for (int ctr = 0; ctr < span.Length; ctr++)
//         span[ctr] = value++;
// }

// public static int ComputeSum(Span<byte> span)
// {
//     int sum = 0;
//     foreach (var value in span)
//         sum += value;

//     return sum;
// }
// // The example displays the following output:
// //    The sum is 4,950
// //    The sum is 4,950
// //    The sum is 4,950