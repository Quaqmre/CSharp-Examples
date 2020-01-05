// var tm = new TestModel() { Value = 5, Message = "Hello World" };
// int size = Marshal.SizeOf(tm);
// byte[] data = new byte[size];
// IntPtr ptr = Marshal.AllocHGlobal(size);
// Marshal.StructureToPtr(tm, ptr, true);
// Marshal.Copy(ptr, data, 0, size);
// Marshal.FreeHGlobal(ptr);
// var response = await _client.PostAsync("http://localhost:5020/api/values", new ByteArrayContent(data));

// byte[] data;
// using (var ms = new MemoryStream())
// {
// 	base.Request.Body.CopyToAsync(ms);
// 	data = ms.ToArray();
// }

// var tm = new TestModel();
// var size = Marshal.SizeOf(tm);
// IntPtr ptr = Marshal.AllocHGlobal(size);
// Marshal.Copy(data, 0, ptr, size);
// Marshal.PtrToStructure(ptr, tm);
// Marshal.FreeHGlobal(ptr);


// [StructLayout(LayoutKind.Sequential)]
// public class TestModel
// {
//     public int Value;
//     [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
//     public string Message;
// }