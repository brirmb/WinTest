using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Aspose.Cells;
using Aspose.Words;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using NPOI.OpenXmlFormats.Dml;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace WinFormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //npoi
        private void button1_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream(@"2year.xlsx", FileMode.Open, FileAccess.Read);
            XSSFWorkbook workbook = new XSSFWorkbook(file);
            file.Close();

            ISheet sheet1 = workbook.GetSheet("Sheet1");
            sheet1.GetRow(2).GetCell(0).SetCellValue(40000);

            sheet1.ForceFormulaRecalculation = true;
            FileStream file2 = new FileStream(@"test.xlsx", FileMode.Create);
            workbook.Write(file2);
            file2.Close();
            MessageBox.Show("OK");

            FileStream file3 = new FileStream(@"test.xlsx", FileMode.Open, FileAccess.Read);
            XSSFWorkbook workbook3 = new XSSFWorkbook(file3);
            ISheet sheet3 = workbook3.GetSheet("Sheet1");
            ICell cell3 = sheet3.GetRow(2).GetCell(2);
            MessageBox.Show(cell3.ToString());
            MessageBox.Show(cell3.NumericCellValue.ToString());

            //ICell cell = sheet1.GetRow(2).GetCell(2);
            ////cell.SetCellFormula("IPMT(0.085/12,B3,24,A$3)");
            //XSSFFormulaEvaluator eva = new XSSFFormulaEvaluator(workbook);
            //cell = eva.EvaluateInCell(cell);

            //MessageBox.Show(cell.NumericCellValue.ToString());

        }

        //com组件
        private void button2_Click(object sender, EventArgs e)
        {
            //直接调用Excel函数
            Microsoft.Office.Interop.Excel.ApplicationClass excel = new Microsoft.Office.Interop.Excel.ApplicationClass();
            double interests = excel.WorksheetFunction.Ipmt(0.085 / 12, 2, 24, 40000);
            MessageBox.Show(interests.ToString());

            //Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel.Workbook wbook = app.Workbooks.Open(@"2year.xlsx", Type.Missing, Type.Missing,
            //     Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            //     Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            //     Type.Missing, Type.Missing);

            //Microsoft.Office.Interop.Excel.Worksheet workSheet = (Microsoft.Office.Interop.Excel.Worksheet)wbook.Worksheets[1];

            ////输入值
            //((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[2, 1]).Value2 = 40000;
            ////获取值
            //string temp = ((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[3, 3]).Text.ToString();
            //MessageBox.Show(temp);

            //wbook.Close(false, @"2year.xlsx", false);
            //app.Quit();
            //NAR(app);
            //NAR(wbook);
            //NAR(workSheet);
        }
        public string GetExcelCalcResult(string fileName, int row, int column, string value)
        {
            //获取值
            string temp = "";

            return temp;
        }

        //此函数用来释放对象的相关资源  
        private void NAR(Object o)
        {
            try
            {
                //使用此方法，来释放引用某些资源的基础 COM 对象。 这里的o就是要释放的对象  
                System.Runtime.InteropServices.Marshal.ReleaseComObject(o);
            }
            catch { }
            finally
            {
                o = null; GC.Collect();
            }
        }

        //aspose
        private void button3_Click(object sender, EventArgs e)
        {
            Workbook workbook = new Workbook(@"2year.xlsx");
            Aspose.Cells.Worksheet worksheet = workbook.Worksheets[0];
            Cell cell = worksheet.Cells[2, 0];
            cell.PutValue(40000);

            var options = new CalculationOptions();
            options.IgnoreError = true;
            worksheet.CalculateFormula(options, true);
            workbook.Save(@"test2.xlsx", Aspose.Cells.SaveFormat.Xlsx);

            Workbook workbook2 = new Workbook(@"2year.xlsx");
            Aspose.Cells.Worksheet worksheet2 = workbook2.Worksheets[0];
            Cell cell2 = worksheet2.Cells[2, 2];
            MessageBox.Show(cell2.Value.ToString());
        }

        //测试文件地址
        private void button4_Click(object sender, EventArgs e)
        {
            //D:\RD\sherp\LeaRun.Application\LeaRun.Application.Web\Resource/PictureFile/20170922/IDCardPositiveNegative/1a518bb5-ac93-40ba-83cc-ab0bec00a0f9.jpg
            //~/Resource/PictureFile/20170922/IDCardPositiveNegative/1a518bb5-ac93-40ba-83cc-ab0bec00a0f9.jpg
            string fileName = @"D:\RD\sherp\LeaRun.Application\LeaRun.Application.Web\Resource/PictureFile/20170922/IDCardPositiveNegative/1a518bb5-ac93-40ba-83cc-ab0bec00a0f9.jpg";

            string[] arrPath = fileName.Replace("\\", "/").Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            MessageBox.Show(arrPath[arrPath.Length - 2]);
        }

        //IPMT
        private void button5_Click(object sender, EventArgs e)
        {
            //每月还款额=贷款本金×[月利率×(1+月利率) ^ 还款月数]÷{[(1+月利率) ^ 还款月数]-1}
            //200000*（9%/12）*(1+9%/12)^180/[(1+9%/12)^180-1] 
            double a = (10000 * (0.085 / 12) * Math.Pow((1 + 0.085 / 12), 24));
            double b = Math.Pow((1 + 0.085 / 12), 24) - 1;
            double c = a / b;

            MessageBox.Show(c.ToString());
        }

        // 测试
        private void button6_Click(object sender, EventArgs e)
        {
            TestModel model = new TestModel
            {
                test1 = "abc",
                test2 = "123"
            };

            //string q = "test1";
            //string r = model[q];

            List<string> orderIdList = new List<string>();
            List<string> ttList = new List<string>();
            orderIdList.AddRange(ttList);
            var count = orderIdList.Distinct().Count();

            decimal? aa = null;
            string ab = aa.ToString();

            var thisyear = DateTime.Now.Year;
            for (int year = thisyear; year >= thisyear - 1; thisyear--)
            {
                int i = year;
            }

            string dd = DateTime.Now.ToString("yyyy年MM月dd日");
            DateTime dateTime = Convert.ToDateTime("2018-01-26 9:47:22");
            var flag = dateTime == DateTime.Today;
            var next = dateTime.AddMonths(1);

            var dt = DateTime.Parse("2018-02-28 11:47:22");
            DateTime d1;
            var bl = DateTime.TryParse("20180404", out d1);

            TimeSpan span= dt - dateTime;
            var days = span.Days;
            var hours = span.Hours;
            var thours = span.TotalHours;

            string no = "JSSSZSXCQ-170201004";
            string date1 = no.Substring(no.IndexOf('-') + 1, 6); //"170809";
            DateTime dtTime = DateTime.ParseExact(date1, "yyMMdd", System.Globalization.CultureInfo.CurrentCulture);
            int dayOfContractSign = dtTime.Day;
            DateTime firstPaymentDate = dtTime.AddMonths(1).AddDays(-1);

            //MessageBox.Show(DateTime.MinValue.ToString("yyyy-MM-dd"));

            //尾号4位
            string no4 = no.Substring(no.Length - 4);

            string sufix = DateTime.Now.ToFileTime().ToString();

            decimal amount = 38450;
            var finalAmount1 = Math.Round(amount / 10000, 2);
            var finalAmount2 = Math.Round(amount / 10000, 2, MidpointRounding.AwayFromZero);

            decimal amount2 = 63165;
            var finalAmount3 = Math.Round(amount2 / 10000, 2);
            var finalAmount4 = Math.Round(amount2 / 10000, 2, MidpointRounding.AwayFromZero);

            var strTime = DateTime.Now.ToString("yyyMMddHHmmssSSS");

            bool bb = true;
            //MessageBox.Show(bb.ToString());

        }

        //aspose.word
        private void button7_Click(object sender, EventArgs e)
        {
            #region html插入word
            ////Document doc = new Document("temp.doc"); //使用模板 只有一个书签
            //Aspose.Words.Document doc = new Aspose.Words.Document();
            //DocumentBuilder builder = new DocumentBuilder(doc);
            ////builder.Font.Name = "宋体";
            //using (StreamReader reader = new StreamReader("苏州抵押合同模板.html")) //苏州抵押合同模板.html 苏州借款合同模板-3月.html
            //{
            //    string content = reader.ReadToEnd();
            //    //builder.MoveToBookmark("content");//如果设置了书签可以直接定位到书签处
            //    builder.InsertHtml(content, true);
            //    //doc.Range.Bookmarks.Clear();//清除书签  

            //    doc.Save("苏州抵押合同模板.docx", Aspose.Words.SaveFormat.Docx);
            //    //doc.Save("苏州借款合同模板.doc");
            //}
            #endregion

            #region word模板变量填充

            string tempPath = "contracttemp.doc";
            string outputPath = "templateout.doc";
            //载入模板
            var doc = new Aspose.Words.Document(tempPath);
            string name = doc.OriginalFileName;

            //提供数据源
            String[] fieldNames = new String[] { "合同编号", "客户姓名", "借款人", "手机号码" };
            Object[] fieldValues = new Object[] { "HT001", "张三", "李四", "12345678900" };
            //合并模版，相当于页面的渲染
            doc.MailMerge.Execute(fieldNames, fieldValues);

            String[] fieldNames2 = new String[] { "车辆品牌", "车牌号码" };
            Object[] fieldValues2 = new Object[] { "蹦床", "苏E123456" };
            doc.MailMerge.Execute(fieldNames2, fieldValues2);

            //保存合并后的文档
            doc.Save(outputPath, Aspose.Words.SaveFormat.Doc);

            #endregion
        }

        private DataSet GetSource()
        {
            //用户表结构
            DataTable table = new DataTable("UserList");
            table.Columns.Add(new DataColumn("Id", typeof(int)));
            table.Columns.Add("UserName");
            var row = table.NewRow();
            row["Id"] = 1;
            row["UserName"] = "黄华东";
            var row1 = table.NewRow();
            row1["Id"] = 2;
            row1["UserName"] = "黄华东B";
            table.Rows.Add(row);
            table.Rows.Add(row1);
            //分数表结构
            DataTable table2 = new DataTable("ScoreList");
            table2.Columns.Add(new DataColumn("UserId", typeof(int)));
            table2.Columns.Add("Name");
            table2.Columns.Add("Score");
            var rowt = table2.NewRow();
            rowt["UserId"] = 1;
            rowt["Name"] = "语文";
            rowt["Score"] = "80";
            var rowm = table2.NewRow();
            rowm["UserId"] = 1;
            rowm["Name"] = "数学";
            rowm["Score"] = "90";
            var rowa = table2.NewRow();
            rowa["UserId"] = 2;
            rowa["Name"] = "语文";
            rowa["Score"] = "40";
            var rowb = table2.NewRow();
            rowb["UserId"] = 2;
            rowb["Name"] = "数学";
            rowb["Score"] = "30";
            table2.Rows.Add(rowt);
            table2.Rows.Add(rowm);
            table2.Rows.Add(rowa);
            table2.Rows.Add(rowb);
            //提供数据源
            DataSet dataSet = new DataSet();
            var userTable = table;
            var userScoreTable = table2;
            dataSet.Tables.Add(userTable);
            dataSet.Tables.Add(userScoreTable);
            dataSet.Relations.Add(new DataRelation("ScoreListForUser", userTable.Columns["Id"], userScoreTable.Columns["UserId"]));

            return dataSet;
        }

        //SHA256加密
        private void button8_Click(object sender, EventArgs e)
        {
            string mes = "123456789ABCDEFGH-";
            string secret = "27c7e4bc518c48d095d9caf544771876";
            string signBody = CommonHelper.SHA256Encrypt(mes, secret);

            MessageBox.Show(string.Format("明文：{0}，密文：{1}", mes, signBody));
        }

        //OpenXML Word中写入html
        private void button9_Click(object sender, EventArgs e)
        {
            string docName = @"openxmltest-copy.docx";
            File.Copy(@"openxmltest.docx", docName, true);
            using (WordprocessingDocument doc = WordprocessingDocument.Open(docName, true))
            {
                string altChunkId = "myId";
                MainDocumentPart mainDocPart = doc.MainDocumentPart;

                var run = new DocumentFormat.OpenXml.Wordprocessing.Run(new Text("test"));
                var paragraph = new DocumentFormat.OpenXml.Wordprocessing.Paragraph(new ParagraphProperties(
                     new Justification() { Val = JustificationValues.Center }),
                                   run);

                //RunProperties runProperties = new RunProperties(); //属性

                //RunFonts fonts = new RunFonts() { EastAsia = "DFKai-SB" }; // 设置字体
                //FontSize size = new FontSize() { Val = "52" }; // 设置字体大小
                //DocumentFormat.OpenXml.Wordprocessing.Color color = new DocumentFormat.OpenXml.Wordprocessing.Color() { Val = "red" }; // 设置字体样式

                //// 将样式添加到属性里面
                //runProperties.Append(color);
                //runProperties.Append(size);
                //runProperties.Append(fonts);

                //run.Append(runProperties);
                //paragraph.Append(run);

                var body = mainDocPart.Document.Body;
                body.Append(paragraph);

                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes("<html><head></head><body><h1>HELLO</h1></body></html>"));
                // Uncomment the following line to create an invalid word document.
                // MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes("<h1>HELLO</h1>"));

                using (StreamReader reader = new StreamReader("苏州抵押合同模板.html")) //苏州抵押合同模板.html 苏州借款合同模板-3月.html
                {
                    string content = reader.ReadToEnd();
                    ms = new MemoryStream(Encoding.UTF8.GetBytes(content));
                }

                // Create alternative format import part.
                AlternativeFormatImportPart formatImportPart =
               mainDocPart.AddAlternativeFormatImportPart(AlternativeFormatImportPartType.Html, altChunkId);
                //ms.Seek(0, SeekOrigin.Begin);

                // Feed HTML data into format import part (chunk).
                formatImportPart.FeedData(ms);
                AltChunk altChunk = new AltChunk();
                altChunk.Id = altChunkId;

                body.Append(altChunk);
                //mainDocPart.Document.Save();
            }
        }

        //xml测试
        private void button10_Click(object sender, EventArgs e)
        {
            string xmlText = "<?xml version=\"1.0\" encoding=\"GBK\"?>";
            xmlText += @"<AIPG>
  <INFO>
    <TRX_CODE>200004</TRX_CODE>
    <VERSION>03</VERSION>
    <DATA_TYPE>2</DATA_TYPE>
    <REQ_SN>200604000000445-201710201026342337143</REQ_SN>
    <RET_CODE>0000</RET_CODE>
    <ERR_MSG>处理完成</ERR_MSG>
<SIGNED_MSG>877c0fbc48185250b2cc97bb558fc90741e865f8fd0daff75e69f5e864070a6795c0695cab56faf98f5aa6d77839d0cde134755942095f66d84945567ae790ecd72aa7a34a9de95bbc2cece2bf7a307198e294603e311f11893dcc7eddc918dd4e97da048b148c4ce1899f2686bd48fbd64feacbad094a998b57e3657131d22c8fd903542bf4e948cdb33bbd12d63f21b0eb3bb7e6678f71307ce8528ce0745e37ac60a0517b16936def769183f92ffd24b285fa3cbab0c8fc2932b66dd705a08624f24c3d808819e87ad9cc0d8232bce24b52e4534d2ce568e6c8278de688ab052a2b632010d8f79b8ba3ffdca2bae3378294e824beebcd5a4ca831ee049f98</SIGNED_MSG>
  </INFO>
  <QTRANSRSP>
    <QTDETAIL>
      <BATCHID>200604000000445-201710200955354367058</BATCHID>
      <SN>0</SN>
      <TRXDIR>1</TRXDIR>
      <SETTDAY>20171020</SETTDAY>
      <FINTIME>20171020095558</FINTIME>
      <SUBMITTIME>20171020095557</SUBMITTIME>
      <ACCOUNT_NO>6217003110002218988</ACCOUNT_NO>
      <ACCOUNT_NAME>小奇奇</ACCOUNT_NAME>
      <AMOUNT>993556</AMOUNT>
      <CUST_USERID>123abc</CUST_USERID>
      <REMARK>车贷</REMARK>
      <RET_CODE>0000</RET_CODE>
      <ERR_MSG>处理成功</ERR_MSG>
    </QTDETAIL>
 <QTDETAIL>
      <BATCHID>VSP20130820001000</BATCHID>
      <SN>6545</SN>
      <TRXDIR>0</TRXDIR>
      <SETTDAY>20130820</SETTDAY>
      <FINTIME>20130820001042</FINTIME>
      <SUBMITTIME>20130820000959</SUBMITTIME>
      <ACCOUNT_NO>6226090203455922</ACCOUNT_NO>
      <ACCOUNT_NAME>张广海</ACCOUNT_NAME>
      <AMOUNT>3333</AMOUNT>
      <CUST_USERID>1092130820246545</CUST_USERID>
      <REMARK>代付保险费</REMARK>
      <RET_CODE>3066</RET_CODE>
      <ERR_MSG>渠道已关闭，交易无法进行</ERR_MSG>
    </QTDETAIL>
  </QTRANSRSP>
</AIPG>";

            //TltQTransResponse model = XmlUtil.Deserialize(typeof(TltQTransResponse), xmlText) as TltQTransResponse;  //xml转实体
            //var qdetails = model.QTRANSRSP;

            //TextReader tr = new StringReader(xmlText);
            //XDocument xmlDoc = XDocument.Load(tr);  //linq to xml
            //var info = xmlDoc.Elements("AIPG").Elements("INFO");
            //var details = xmlDoc.Elements("AIPG").Elements("QTRANSRSP").Elements("QTDETAIL");

            string xml = "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\"?>" +
                         "<qrytransrsp><ret>111167</ret><memo>查询请求过于频繁,稍后再试</memo></qrytransrsp>";
            FuiouQueryResponse model = XmlUtil.Deserialize(typeof(FuiouQueryResponse), xml) as FuiouQueryResponse;  //xml转实体
            var qdetails = model.trans;
            var detail = model.trans[0];
        }

        //MD5
        private void button11_Click(object sender, EventArgs e)
        {
            string xml = "0002900F0345178|123456|sincomeforreq|<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\"?>";
            xml +=
                "<incomeforreq><ver>1.00</ver><merdt>20171026</merdt><orderno>201710261653015550334</orderno><bankno>0102</bankno><accntno>9558801001114990716</accntno><accntnm>奇奇</accntnm><amt>21200</amt><entseq>test</entseq><memo>65c457b1-ab2a-4945-ac7b-d6cb688915ce</memo><mobile>15062505125</mobile><certtp>0</certtp><certno>512501196512305186</certno></incomeforreq>";

            string result = CommonHelper.MD5Encrypt32(xml);
            MessageBox.Show(result);
        }

        //DES
        private void button12_Click(object sender, EventArgs e)
        {
            string desE = CommonHelper.DESEncrypt("11111111");
            MessageBox.Show(desE);

            string desD = CommonHelper.DESDecrypt(desE);
            MessageBox.Show(desD);
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }



    public class TestModel
    {
        public string test1 { get; set; }
        public string test2 { get; set; }
    }
}
