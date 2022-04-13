using Magicodes.ExporterAndImporter.Core;
using Magicodes.ExporterAndImporter.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(new EncryptionAndDecryption().SHA("Bsi2019"));
            //Console.WriteLine(da);

            #region Log编辑记录
            //Data data1 = new Data { Id = 3, Name = "关羽", Age = 20, Set = 1 };//新值
            //Data data2 = new Data { Id = 3, Name = "张飞", Age = 25, Set = 0 };//旧值 
            //var da = new LogContrast<Data>();
            //var dat=da.DataComparison(data1,data2,data1.Id,44);
            //foreach (var item in dat)
            //{
            //    Console.WriteLine("编辑项:"+item.EditItem+"  新值:"+item.Newvalue+"  旧值:"+item.Oldvalue+"    Id:"+item.Id+"  用户Id:"+item.UserId+"    编辑时间:"+item.EditTime);
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Data data3 = new Data { Id = 4, Name = "韩信", Age = 25, Set = 1 };//新值
            //Data data4 = new Data { Id = 4, Name = "张良", Age = 25, Set = 1 };//旧值 
            //var dat1 = da.DataComparison(data3, data4, data3.Id, 44);
            //foreach (var item in dat1)
            //{
            //    Console.WriteLine("编辑项:" + item.EditItem + "  新值:" + item.Newvalue + "  旧值:" + item.Oldvalue + "    Id:" + item.Id + "  用户Id:" + item.UserId + "    编辑时间:" + item.EditTime);
            //}
            #endregion
            #region 模板导入导出
            //导出
            List<Tesc> tescs = new List<Tesc>()
            {
                new Tesc{ Id=1,Name="测试1",Age=20 },
                new Tesc{ Id=2,Name="测试2",Age=30 }
            };
            //string filePhysicalPath = BookingFileDirectory("export");
            //if (!Directory.Exists(filePhysicalPath))
            //{
            //    Directory.CreateDirectory(filePhysicalPath);
            //}
            //TimeoutFileDelete(filePhysicalPath);
            //string path = BookingFilePath("export", "测试导出" + ".xlsx");
            //var filePath = Path.Combine(path);
            //IExporter exporter = new ExcelExporter();
            //exporter.Export(filePath, tescs).Wait();
            ////读取模板文件标题数据

            //var Paths = BookingFilePath("export", "测试导出.xlsx");
            //FileStream stream = File.OpenRead(Paths);

            //using (ExcelPackage package = new ExcelPackage(stream))
            //{

            //    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
            //    //获取表格的列数和行数
            //    int rowCount = worksheet.Dimension.Rows;
            //    int ColCount = worksheet.Dimension.Columns;
            //    DataTable data = new DataTable();
            //    for (int i = 1; i <= ColCount; i++)
            //    {
            //            Console.WriteLine(worksheet.GetValue (1,i));
            //    }
            //}
            //IImporter Importer = new ExcelImporter();
            //IExcelImporter excel = new ExcelImporter();
            // var import =  Importer.Import<Tesc>(path);
            //
            //var filePaths = Path.Combine(Directory.GetCurrentDirectory(), "DataTable测试.xlsx");

            //var dt = new DataTable();
            ////创建带列名和类型名的列
            //Tesc tesc = new Tesc();
            //Type t = tesc.GetType();
            //foreach (var item in t.GetProperties())
            //{
            //    //Console.WriteLine(item.Name);
            //    //Console.WriteLine(item.PropertyType);
            //    dt.Columns.Add(item.Name, Type.GetType(item.PropertyType.ToString()));
            //}
            //foreach (var item in tescs)
            //{
            //    DataColumn data = new DataColumn();
            //    data.DefaultValue = item.Id;
            //    data.DefaultValue = item.Name;
            //    data.DefaultValue = item.Age;
            //}
            //加个筛选器导出
            //var result = exporter.Export<DataTable>(filePaths, dt);

            #endregion
            #region DataTable动态导出
           // List<Tescx> tescx = new List<Tescx>()
           //{
           //    new Tescx{ Name="名称",CodeName="Name",CName="名称" },
           //    new Tescx{ Name="年龄",CodeName="Age",CName="年龄" }
           //};
           // List<string> Template = new List<string>();
           // List<string> basic = new List<string>();
           // //获取表头
           // Type type = typeof(Tesc);
           // PropertyInfo[] pis = type.GetProperties();
           // foreach (var item in pis)
           // {
           //     basic.Add(item.Name);
           // }
           // foreach (var item in tescx)
           // {
           //     Template.Add(item.CodeName);
           // }
           // //交集 要导出Excel的表头
           // var list = basic.Intersect(Template).ToList();
           // DataTable dt = new DataTable();
           // //创建列并设置列名
           // foreach (var item in list)
           // {
           //     var da= tescx.Find(a => a.CodeName == item);
           //     dt.Columns.Add(da.Name);
           // }
           // //数据添加到DataTable
           // foreach (var item in tescs)
           // {
           //     List<string> rows = new List<string>();
           //     Type types = item.GetType();
           //     PropertyInfo[] piss = type.GetProperties();
           //     foreach (var it in piss)
           //     {
           //         foreach (var im in list)
           //         {
           //             if (it.Name == im)
           //             {
           //                 rows.Add(it.GetValue(item).ToString());
           //             }
           //         }
           //     }
           //     DataRow dataRow = dt.NewRow();
           //     for (int i = 0; i < rows.Count; i++)
           //     {
                    
           //         dataRow[i] = rows[i];
           //     }
           //     dt.Rows.Add(dataRow);
           // }
           // var filePaths = Path.Combine(Directory.GetCurrentDirectory(), "DataTable动态导出测试.xlsx");
           // IExporter exporter = new ExcelExporter();
           // exporter.Export<DataTable>(filePaths, dt).Wait();
            #endregion
            Console.Read();
        }

        #region Log编辑记录
        //public class Data
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public int Age { get; set; }
        //    public int Set { get; set; }
        //}
        //public class LogContrast<T>
        //{
        //    /// <summary>
        //    /// 编辑数据对比
        //    /// </summary>
        //    /// <param name="Newvalue">新值</param>
        //    /// <param name="Oldvalue">旧址</param>
        //    /// <param name="Id"></param>
        //    /// <param name="UserId"></param>
        //    /// <returns></returns>
        //    public List<EditRecord> DataComparison(object Newvalue, object Oldvalue, int Id, int UserId)
        //    {
        //        PropertyInfo[] pis = Newvalue.GetType().GetProperties();
        //        PropertyInfo[] pis1 = Oldvalue.GetType().GetProperties();
        //        List<EditRecord> logs = new List<EditRecord>();
        //        for (int i = 0; i < pis.Length; i++)
        //        {
        //            for (int j = 0; j < pis1.Length; j++)
        //            {
        //                if (pis[i].Name == pis1[j].Name)
        //                {
        //                    if (pis[i].GetValue(Newvalue) is not null && pis1[j].GetValue(Oldvalue) is not null)
        //                    {
        //                        if (pis[i].GetValue(Newvalue).ToString() != pis1[j].GetValue(Oldvalue).ToString())
        //                        {
        //                            EditRecord log = new EditRecord();
        //                            log.Newvalue = pis[i].GetValue(Newvalue).ToString();
        //                            log.Oldvalue = pis1[j].GetValue(Oldvalue).ToString();
        //                            log.EditTime = DateTime.Now;
        //                            log.UserId = UserId;
        //                            log.EditItem = pis[i].Name;
        //                            log.Id = Id;
        //                            logs.Add(log);
        //                        }
        //                    }
        //                    else if (pis[i].GetValue(Newvalue) is null && pis1[j].GetValue(Oldvalue) is null)
        //                    {
        //                        continue;
        //                    }
        //                    else if (pis[i].GetValue(Newvalue) is null && pis1[j].GetValue(Oldvalue) is not null)
        //                    {
        //                        EditRecord log = new EditRecord();
        //                        log.Newvalue = "/";
        //                        log.Oldvalue = pis1[j].GetValue(Oldvalue).ToString();
        //                        log.EditTime = DateTime.Now;
        //                        log.UserId = UserId;
        //                        log.EditItem = pis[i].Name;
        //                        log.Id = Id;
        //                        logs.Add(log);
        //                    }
        //                    else if (pis[i].GetValue(Newvalue) is not null && pis1[j].GetValue(Oldvalue) is null)
        //                    {
        //                        EditRecord log = new EditRecord();
        //                        log.Newvalue = pis[i].GetValue(Newvalue).ToString();
        //                        log.Oldvalue = "/";
        //                        log.EditTime = DateTime.Now;
        //                        log.UserId = UserId;
        //                        log.EditItem = pis[i].Name;
        //                        log.Id = Id;
        //                        logs.Add(log);
        //                    }
        //                }
        //            }
        //        }
        //        return logs;
        //    }

        //    /// <summary>
        //    /// 编辑数据对比
        //    /// </summary>
        //    /// <param name="Newvalue">新值</param>
        //    /// <param name="Oldvalue">旧址</param>
        //    /// <param name="Id"></param>
        //    /// <param name="UserId"></param>
        //    /// <returns></returns>
        //    public List<EditRecord> ToDataComparison(object Newvalue, object Oldvalue, int Id, int UserId)
        //    {
        //        PropertyInfo[] pis = Newvalue.GetType().GetProperties();
        //        PropertyInfo[] pis1 = Oldvalue.GetType().GetProperties();
        //        List<EditRecord> logs = new List<EditRecord>();
        //        foreach (var item in Newvalue.GetType().GetProperties())
        //        {
        //            foreach (var it in Oldvalue.GetType().GetProperties())
        //            {
        //                if (item.Name == it.Name)
        //                {

        //                }
        //            }
        //        }
        //        for (int i = 0; i < pis.Length; i++)
        //        {
        //            for (int j = 0; j < pis1.Length; j++)
        //            {
        //                if (pis[i].Name == pis1[j].Name)
        //                {
        //                    if (pis[i].GetValue(Newvalue) is not null && pis1[j].GetValue(Oldvalue) is not null)
        //                    {
        //                        if (pis[i].GetValue(Newvalue).ToString() != pis1[j].GetValue(Oldvalue).ToString())
        //                        {
        //                            EditRecord log = new EditRecord();
        //                            log.Newvalue = pis[i].GetValue(Newvalue).ToString();
        //                            log.Oldvalue = pis1[j].GetValue(Oldvalue).ToString();
        //                            log.EditTime = DateTime.Now;
        //                            log.UserId = UserId;
        //                            log.EditItem = pis[i].Name;
        //                            log.Id = Id;
        //                            logs.Add(log);
        //                        }
        //                    }
        //                    else if (pis[i].GetValue(Newvalue) is null && pis1[j].GetValue(Oldvalue) is null)
        //                    {
        //                        continue;
        //                    }
        //                    else if (pis[i].GetValue(Newvalue) is null && pis1[j].GetValue(Oldvalue) is not null)
        //                    {
        //                        EditRecord log = new EditRecord();
        //                        log.Newvalue = "/";
        //                        log.Oldvalue = pis1[j].GetValue(Oldvalue).ToString();
        //                        log.EditTime = DateTime.Now;
        //                        log.UserId = UserId;
        //                        log.EditItem = pis[i].Name;
        //                        log.Id = Id;
        //                        logs.Add(log);
        //                    }
        //                    else if (pis[i].GetValue(Newvalue) is not null && pis1[j].GetValue(Oldvalue) is null)
        //                    {
        //                        EditRecord log = new EditRecord();
        //                        log.Newvalue = pis[i].GetValue(Newvalue).ToString();
        //                        log.Oldvalue = "/";
        //                        log.EditTime = DateTime.Now;
        //                        log.UserId = UserId;
        //                        log.EditItem = pis[i].Name;
        //                        log.Id = Id;
        //                        logs.Add(log);
        //                    }
        //                }
        //            }
        //        }
        //        return logs;
        //    }
        //}
        ///// <summary>
        ///// 编辑记录
        ///// </summary>
        //public class EditRecord
        //{
        //    /// <summary>
        //    /// 编辑数据Id
        //    /// </summary>
        //    public int Id { get; set; }
        //    /// <summary>
        //    /// 编辑项
        //    /// </summary>
        //    public string EditItem { get; set; }
        //    /// <summary>
        //    /// 旧址
        //    /// </summary>
        //    public string Oldvalue { get; set; }
        //    /// <summary>
        //    /// 新值
        //    /// </summary>
        //    public string Newvalue { get; set; }
        //    /// <summary>
        //    /// 编辑人Id
        //    /// </summary>
        //    public int UserId { get; set; }
        //    /// <summary>
        //    /// 编辑时间
        //    /// </summary>
        //    public DateTime EditTime { get; set; }
        //}
        #endregion
        #region 模板导入导出
        //////导出
        ////[ExcelExporter(Name = "订单导入模板", TableStyle = TableStyles.Dark4, AutoFitAllColumn = true, MaxRowNumberOnASheet = 100)]
        //public class Tesc
        //{
        //    //[ExporterHeader(DisplayName = "Id")]
        //    // [Required(ErrorMessage = "Id不能为空")]
        //    public int Id { get; set; }
        //    //[ExporterHeader(DisplayName = "名称")]
        //    //[Required(ErrorMessage = "名称不能为空")]
        //    public string Name { get; set; }
        //    //  [ExporterHeader(DisplayName = "年龄")]
        //    //  [Required(ErrorMessage = "年龄不能为空")]
        //    public int Age { get; set; }
        //}

        ////导入
        //[ExcelImporter(IsLabelingError = true)]
        //public class Tescs
        //{
        //    [ImporterHeader(Name = "Id")]
        //    [Required(ErrorMessage = "Id不能为空")]
        //    public int Id { get; set; }
        //    [ImporterHeader(Name = "名称")]
        //    [Required(ErrorMessage = "名称不能为空")]
        //    public string Name { get; set; }
        //    [ImporterHeader(Name = "年龄")]
        //    [Required(ErrorMessage = "年龄不能为空")]
        //    public int Age { get; set; }
        //}
        ///// <summary>
        ///// 时间差
        ///// </summary>
        ///// <param name="dateBegin">开始时间</param>
        ///// <param name="dateEnd">结束时间</param>
        ///// <returns>返回单位秒</returns>
        //public static int ExecDateDiff(DateTime dateBegin, DateTime dateEnd)
        //{
        //    TimeSpan ts1 = new TimeSpan(dateBegin.Ticks);
        //    TimeSpan ts2 = new TimeSpan(dateEnd.Ticks);
        //    TimeSpan ts3 = ts1.Subtract(ts2).Duration();
        //    int Seconds = ts3.Seconds;
        //    if (ts3.Minutes > 0)
        //    {
        //        Seconds += ts3.Minutes * 60;
        //    }
        //    if (ts3.Hours > 0)
        //    {
        //        Seconds += ts3.Hours * 60 * 60;
        //    }
        //    if (ts3.Days > 0)
        //    {
        //        Seconds += ts3.Days * 60 * 60 * 24;
        //    }
        //    return Seconds;
        //}
        ///// <summary>
        ///// 超时文件删除
        ///// </summary>
        ///// <param name="FolderAddress">文件夹地址</param>
        //public static void TimeoutFileDelete(string FolderAddress)
        //{
        //    var DA = Directory.GetFiles(FolderAddress);
        //    foreach (var item in DA)
        //    {
        //        DateTime dateTime = Directory.GetCreationTime(item);
        //        int DATA = ExecDateDiff(dateTime, DateTime.Now);
        //        if (DATA > (1 * 60 * 60 * 24 * 7)) //保存7天超过删除
        //        {
        //            DeleteFile(item);
        //        }
        //    }
        //}
        ///// <summary>
        ///// 根据路径删除文件
        ///// </summary>
        ///// <param name="path"></param>
        //public static void DeleteFile(string path)
        //{
        //    FileAttributes attr = File.GetAttributes(path);
        //    if (attr == FileAttributes.Directory)
        //    {
        //        Directory.Delete(path, true);
        //    }
        //    else
        //    {
        //        File.Delete(path);
        //    }
        //}
        ///// <summary>
        ///// 获取指定文件夹路劲
        ///// </summary>
        ///// <param name="foldername">文件夹名称</param>
        ///// <returns></returns>
        //public static string BookingFileDirectory(string foldername)
        //{
        //    var rootPath = AppContext.BaseDirectory;
        //    var contentRootPath = Path.Combine(rootPath, "Content", "Download", foldername);
        //    return contentRootPath;
        //}
        ///// <summary>
        ///// 获取指定文件路劲
        ///// </summary>
        ///// <param name="foldername">文件夹名称</param>
        ///// <param name="fileName">文件名称</param>
        ///// <returns></returns>
        //public static string BookingFilePath(string foldername, string fileName)
        //{
        //    var rootPath = AppContext.BaseDirectory;
        //    var contentRootPath = Path.Combine(rootPath, "Content", "Download", foldername, fileName);
        //    return contentRootPath;
        //}
        #endregion



    }//----------------------------------------------------------------------------------------------------------------------
    #region DataTable

    public class Tescx
    {
        /// <summary>
        /// 客户名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 源代码名称
        /// </summary>
        public string CodeName { get; set; }
        /// <summary>
        /// 原名称
        /// </summary>
        public string CName { get; set; }
    }
    public class Common<T>
    {
        public async Task<DataTable> GetDataTable(List<T> ts)
        {
            Type type = typeof(T);
            PropertyInfo[] pis = type.GetProperties();
            DataTable dt = new DataTable();
            Type type1 = ts.GetType();
            PropertyInfo[] pis1 = type1.GetProperties();
            foreach (var item in pis)
            {
                dt.Columns.Add(item.Name, Type.GetType(item.PropertyType.ToString()));
                DataColumn column = new DataColumn();
                //DataRow dataRow = new DataRow();
                //foreach (var items in ts)
                //{
                //    var ta= items.GetType();
                //    PropertyInfo[] tas = ta.GetProperties();
                //    foreach (var it in tas)
                //    {
                //        if (it.Name == item.Name)
                //        {
                //            dataRow.
                //        }
                //    }

                //}
            }
            return null;
        }
    }
    #endregion
}
