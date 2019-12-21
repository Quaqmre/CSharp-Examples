// using System;
// using System.Collections.Generic;
// using System.Drawing;
// using System.IO;
// using System.Linq;
// using System.Net.Sockets;
// using System.Reflection;
// using System.Text.RegularExpressions;
// using System.Threading;
// using System.Threading.Tasks.Dataflow;
// using LiteDB;
// using MonkeyCache;
// using MonkeyCache.FileStore;
// using OfficeOpenXml.Drawing;
// using OfficeOpenXml.Drawing.Chart;

// namespace C__Örneklerim
// {
//     /*
//         Bu yapı ile dinlenmekte olan 13000 portuna bir mesaj gönderilmektedir,
//          Ve bu sekilde cmd üzerinde gönderilen mesajları okuma imkanı sunmaktadır,
//      */
//     class Program
//     {
//         static async System.Threading.Tasks.Task Main(string[] args)
//         {
//             var pck = new OfficeOpenXml.ExcelPackage();
//             var emptysheet = pck.Workbook.Worksheets.Add("BsUsages");


//             ExcelChart chart = emptysheet.Drawings.AddChart("FindingsChart",
//             OfficeOpenXml.Drawing.Chart.eChartType.ColumnClustered);
//             chart.Title.Text = "Category Chart";
//             chart.SetPosition(1, 0, 3, 0);
//             chart.SetSize(800, 300);
//             var ser1 = (ExcelChartSerie)(chart.Series.Add(emptysheet.Cells["B4:B6"],
//             emptysheet.Cells["A4:A6"]));
//             ser1.Header = "Category";
//             FileInfo file = new FileInfo(@".\" + "usage.xlsx");

//             var excelPicture = emptysheet.Drawings[0];

//             var t = chart.WorkSheet.Drawings[0];

//             // var z = t.Image;

//             // Bitmap b = new Bitmap(z);

//             // b.Save(@".\test.jpg");


//             // var img = excelPicture.Image; // This is of type System.Drawing.Image
//             pck.SaveAs(file);


//         }

//     }

// }



