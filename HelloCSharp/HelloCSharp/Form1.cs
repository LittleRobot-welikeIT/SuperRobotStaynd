using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace HelloCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello C#");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Hello = "Hello,Wellcome C#藥水店";
            string RedWater = "RedWater";
            string BlueWater = "BlueWater";
            int Percentage = 100;

            MessageBox.Show(Hello + Environment.NewLine + RedWater + ":" + Percentage + "%" + Environment.NewLine + BlueWater + ":" + Percentage
                + "%");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cal = 6 + 3 * 8 / (7 - 3);
            MessageBox.Show(cal.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //簡單型別
            //帶正負號的整數︰sbyte、short、int、long
            //不帶正負號的整數︰byte、ushort、uint、ulong
            //Unicode 字元：char
            //浮點數：float、double
            //高精確度十進位︰decimal
            //布林值：bool

            //列舉型別

            //使用者定義型別，格式為 enum E {...}

            //結構型別
            //使用者定義型別，格式為 struct S {...}
            //可為Null的實值型別
            //含有null值的所有其他數值型別的擴充

            //類別型別
            //所有其他型別的基底類別︰object
            //Unicode 字串：string
            //使用者定義型別，格式為 class C {...}

            //介面型別
            //使用者定義型別，格式為 interface I {...}

            //陣列型別
            //單一維度和多維度，例如 int[] 和 int[,]

            //委派型別

            //使用者定義型別，格式為 delegate int D(...)

            int cal = 11;
            string Test = "test string";

            double FValue1 = 11;
            double FValue2 = 11.11;

            MessageBox.Show("水魔法int cal(99/9)" + "=" + cal + Environment.NewLine + "光魔法string Test(字串測試)" + "=" + Test + Environment.NewLine +
                "狀態魔法(連續湧唱)" + "魔力點數" + "=" + FValue1 + Environment.NewLine + "詠唱結果" + "=" + FValue2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("出村路牌-int陳述式");

            int ValueInt = 2;
            int routeTips = 2;

            if (ValueInt > 1)
            {
                MessageBox.Show("左轉", "第一關");
                routeTips = 2;
            }
            else if (ValueInt < 1)
            {
                MessageBox.Show("右轉", "第一關");
                routeTips = 1;
            }
            else
            {
                MessageBox.Show("此路不通", "第一關");
                routeTips = 3;
            }

            MessageBox.Show("又遇叉路-switch陳述式");

            switch (routeTips)
            {
                case 1:
                    MessageBox.Show("嘿嘿，這坑挖好等你了!", "第二關");
                    break;

                case 2:
                    MessageBox.Show("此為正解，恭喜你找到正確的路", "第二關");
                    break;

                default:
                    MessageBox.Show("這你都能走錯，還是砍掉重練吧", "第二關");
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //將呈現的記錄文字
            string ShowString = "";

            //虺五百年化為蛟，因此狀態改變需要500年(在此以轉職代替)
            int UpdateStatus = 500;


            //迴圈turbo全速運轉，Go
            for (int i = 1; i < 101; i++)
            {
                if (i % 10 == 0)
                {
                    ShowString += "已解決" + i + "隻嫩寶 => 經驗提升，" + "目前經驗值為" + (0 + i) + "距離轉職尚需" + (UpdateStatus - i) + "點經驗值" + Environment.NewLine;
                }
            }
            MessageBox.Show("時光流速turbo全速運轉結果:" + Environment.NewLine + ShowString, "維多利亞港(for迴圈)");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //將呈現的記錄文字
            string Showstring = "";

            //虺五百年化為蛟，因此狀態改變需要500年(在此以二轉代替)
            int UpdateStatus = 400;

            int start = 1; //初始化
            int end = start + 50; //時光50年，需加上初始值

            //迴圈turbo全速運轉，Go
            do
            {
                if (start % 10 == 0)
                {
                    Showstring += "已解決" + start + "隻藍寶 => 經驗提升，" + "目前經驗值為" + (100 + start) + "距離轉職尚需" + (UpdateStatus - start) + "點經驗值" + Environment.NewLine;
                }

                start++; //每跑(執行)一次+1
            } while (start < end);

            MessageBox.Show("時光流速turbo全速運轉結果:" + Environment.NewLine + Showstring, "藍寶海灘(do迴圈)");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //將呈現的記錄文字
            string ShowString = "";

            //虺五百年化為蛟，因此狀態改變需要500年(在此以三轉代替)
            int UpdateStatus = 350;

            int start = 1; //初始化
            int end = start + 150; //時光150年 需加上初始值

            //迴圈turbo全速運轉，Go
            while (start < end)
            {
                if (start % 10 == 0)
                {
                    ShowString += "已解決" + start + "隻紅寶 => 經驗提升，" + "目前經驗值為" + (150 + start) + "距離轉職尚需"
                        + (UpdateStatus - start) + "點經驗值" + Environment.NewLine;
                }

                start++; //每執行一次+1
            }

            MessageBox.Show("時光流速turbo全速運轉結果:" + Environment.NewLine + ShowString, "三叉路(While迴圈");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //將呈現的記錄文字
            string ShowString = "";

            //虺五百年化為蛟，已經過了150年，因此狀態改變需要200年(在此以終轉代替)
            int UpdateStatus = 200;
            int[] ValueArray = new int[] { 125, 75 };
            foreach (int element in ValueArray)



            {
                ShowString += "已解決" + element + "隻木妖 => 經驗提升，" + "目前經驗值為" + (500 - (UpdateStatus - element)) + "距離轉職尚需" + (UpdateStatus - element)
                    + "點經驗值" + Environment.NewLine;
                UpdateStatus = UpdateStatus - element;
            }

            MessageBox.Show("時光流速turbo全速運轉結果:" + Environment.NewLine + ShowString, "勇士之村郊外(Foreach迴圈)");
            MessageBox.Show("恭喜!，已由'初心者'轉職為'劍士'", "勇士之村長老之家");
        }

        public class BraveActionClass
        {
            public void Back()
            {
                MessageBox.Show("正在開啟新手寵物禮包.", "新手禮包");
                MessageBox.Show("正在開啟新手寵物禮包..", "新手禮包");
                MessageBox.Show("正在開啟新手寵物禮包...", "新手禮包");
                MessageBox.Show("請點選招募" + Environment.NewLine + "☆小猴仔 16%" + Environment.NewLine + "☆小魔龍 16%" + Environment.NewLine
                    + "☆小巴洛古 16%" + Environment.NewLine + "☆小機器人 16%" + Environment.NewLine + "☆小黑貓 16%" + Environment.NewLine + "☆哈士奇 16%"
                    + Environment.NewLine + "☆☆☆☆☆皮卡啾 4%", "新手禮包");
            }

            public void Lotterymenber()
            {
                string member = "";

                //實體化Random物件
                Random random = new Random();
                int returnint = random.Next(1, 25);

                switch (returnint)
                {
                    case 1:
                    case 7:
                    case 8:
                    case 9:
                        member = "您得到了夥伴 ☆小猴仔";
                        break;
                    case 2:
                    case 10:
                    case 11:
                    case 12:
                        member = "您得到了夥伴 ☆小魔龍";
                        break;
                    case 3:
                    case 13:
                    case 14:
                    case 15:
                        member = "您得到了夥伴 ☆小巴洛古";
                        break;
                    case 4:
                    case 16:
                    case 17:
                    case 18:
                        member = "您得到了夥伴 ☆小機器人";
                        break;
                    case 5:
                    case 20:
                    case 21:
                    case 22:
                        member = "您得到了夥伴 ☆小黑貓";
                        break;
                    case 6:
                    case 19:
                    case 23:
                    case 24:
                        member = "您得到了夥伴 ☆哈士奇";
                        break;
                    case 25:
                        member = "您得到了夥伴 ☆☆☆☆☆皮卡啾";
                        break;
                }

                MessageBox.Show(member, "一轉好禮:新手寵物抽獎");
            }
        }
        //初始化Dictionary
        Dictionary<string, string> BoxArray = new Dictionary<string, string>(); //箱子
        int count = 10;//顯示容量用

        //實體化BraveActionClass
        private BraveActionClass BraveActionList = new BraveActionClass();

        private void button10_Click(object sender, EventArgs e)
        {
            BraveActionList.Back();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BraveActionList.Lotterymenber();
        }

        //判斷輸入的值是否為數字
        private bool IsNumber(string TextBoxValue)
        {
            try
            {
                int i = Convert.ToInt32(TextBoxValue);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //取得目前盒子內儲存清單
        private void ArrayData()
        {
            string tmpString = "";
            foreach (KeyValuePair<string, string> GetBoxArray in BoxArray)
            {
                tmpString += "第" + GetBoxArray.Key + "空間位置 => " + GetBoxArray.Value + Environment.NewLine;
            }
            label5.Text = tmpString; //目前列表詳細內容
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("歡迎來到哈囉C#谷");
            label2.Text = count.ToString(); //目前容量
            label4.Text = count.ToString(); //容量還剩
            ArrayData();
            textBox2.Text = ConfigurationManager.AppSettings["Blew"];

            //Day 27 ComboBox擴充
            ListItem[] ComboBoxItems = {
        new ListItem("One Star", "one"),
        new ListItem("Two Star", "two"),
        new ListItem("Three Star", "three"),
    };
            comboBox1.Items.AddRange(ComboBoxItems);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string SaveKey = Interaction.InputBox("存入物品鍵值", "存入鍵值", "", -1, -1);  //-1表示在螢幕中間
            string SaveName = Interaction.InputBox("存入物品名稱", "存入名稱", "", -1, -1);  //-1表示在螢幕中間

            //驗證是否為空
            if (!String.IsNullOrEmpty(SaveKey) && !String.IsNullOrEmpty(SaveName))
            {
                BoxArray.Add(SaveKey, SaveName); //加入值到BoxArray
                count--;
                label4.Text = count.ToString(); //容量還剩
            }
            else if (count <= 0)
            {
                MessageBox.Show("可儲存的容量不足", "Error Message");
            }

            //重新取得清單
            ArrayData();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string GetString = Interaction.InputBox("取出物品鍵值", "取出鍵值", "", -1, -1);

            //驗證是否有找到值，如錯誤則跳出錯誤訊息
            try
            {
                MessageBox.Show("取出物品：" + BoxArray[GetString]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "錯誤訊息");
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        //sender代表引發事件的object
        //數字按鈕點擊時的觸發事件
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button buttonNumber = sender as Button;

            if (textBox1.Text == "0")
            {
                textBox1.Text = buttonNumber.Text;
            }
            else
            {
                textBox1.Text += buttonNumber.Text;
            }
        }

        string mathematical = "";
        string beforeValue = null;

        //點擊的運算式時的動作
        private void buttonMathematical_Click(object sender, EventArgs e)
        {
            Button buttonMathematical = sender as Button;
            mathematical = buttonMathematical.Text; //紀錄所點擊的運算式
            beforeValue = textBox1.Text; //記錄使用者輸入前一個值得內容
            textBox1.Text = "" ;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Double GetBeforValue = Double.Parse(beforeValue);
            Double GetAfterValue = Double.Parse(textBox1.Text);
            Double Result = 0;

            switch (mathematical)
            {
                case "+":
                    Result = GetBeforValue + GetAfterValue;
                    break;
                case "-":
                    Result = GetBeforValue - GetAfterValue;
                    break;
                case "*":
                    Result = GetBeforValue * GetAfterValue;
                    break;
                case "/":
                    Result = GetBeforValue / GetAfterValue;
                    break;
            }

            textBox1.Text = Result.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            TaiwanCalendar taiwanCalendar = new TaiwanCalendar();
            DateTime datetime = DateTime.Parse(dateTimePicker1.Text);
            int taiwanCalendarYear = taiwanCalendar.GetYear(datetime); //取得民國年
            label8.Text = taiwanCalendarYear.ToString();//填入label8內
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            //驗證是否每個欄位都有填寫
            if (!String.IsNullOrEmpty(sourcePath.Text) 
                & !String.IsNullOrEmpty(sourceFileName.Text)
                & !String.IsNullOrEmpty(targetPath.Text) 
                & !String.IsNullOrEmpty(targetFileName.Text))
            {
                //組合檔案來源位置字串
                string sourceFile = Path.Combine(sourcePath.Text, sourceFileName.Text);

                //組合檔案目的位置字串
                string destFile = Path.Combine(targetPath.Text, targetFileName.Text);//前為位置 後為資料夾 ?

                //檢查是否有資料夾位置
                if (!Directory.Exists(targetPath.Text))
                {
                    //若沒有則建立資料夾
                    Directory.CreateDirectory(targetPath.Text);
                }

                //複製所指定檔案到指定位置
                File.Copy(sourceFile, destFile, true);

                label14.Text = "傳送成功";
            }
            else
            {
                MessageBox.Show("請把所有位置(TextBOX)填寫完畢");
            }
        }

        /// <summary>
        /// 指定檔案給予下載
        /// </summary>
        /// <param name="windowFilter">開窗限定搜尋副檔名(說明文字|指定格式 EX:Excel|*.xlsx)</param>
        /// <param name="windowTitle">開窗標題</param>
        /// <param name="defaultFileName">開窗預設給予的檔案名稱</param>
        /// <param name="targetFileName2">目標檔案相對位置</param>
        public void SaveFile(string windowFilter, string windowTitle, string defaultFileName, string targetFileName2)
        {
            SaveFileDialog saveFileDialogFunction = new SaveFileDialog();
            saveFileDialogFunction.Filter = windowFilter; //開窗搜尋副檔名
            saveFileDialogFunction.Title = windowTitle; //開窗標題
            saveFileDialogFunction.FileName = defaultFileName; //開窗預設給予的檔案名稱
            if (saveFileDialogFunction.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialogFunction.FileName != "")
                {
                    string NowPath = Directory.GetCurrentDirectory(); //目前程式所在目錄
                    string TargetFile = targetFileName2; //目標檔案相對位置
                    string FormDirectory = NowPath + TargetFile; //目標檔案完整路徑
                    string ToDirectory = @saveFileDialogFunction.FileName; //將儲存檔案的目的地完整路徑(包含檔名)

                    FileInfo FileInfoValue = new FileInfo(FormDirectory);
                    FileInfoValue.CopyTo(ToDirectory, true);
                }
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(windowFilter.Text) && !String.IsNullOrEmpty(windowTitle.Text) && !String.IsNullOrEmpty

            (defaultFileName.Text) && !String.IsNullOrEmpty(targetFileName2.Text))
            {   //使用SaveFile Function
                SaveFile(windowFilter.Text, windowTitle.Text, defaultFileName.Text, targetFileName2.Text);
            }
            else
            {
                MessageBox.Show("請將所有TextBox填寫完畢");
            label19.Text = "下載成功";
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //讀取設定檔
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //移除指定的AppSettings
            config.AppSettings.Settings.Remove("Blew");

            //新增指定的AppSettings
            config.AppSettings.Settings.Add("Blew", textBox2.Text);

            //儲存設定
            config.Save(ConfigurationSaveMode.Modified);

            MessageBox.Show("更新完畢");
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("目前在App.Config數值為:" + ConfigurationManager.AppSettings ["Blew"] );
        }

        //實體化MagicAction
        private MagicAction MagicActionList = new MagicAction();

        public class MagicAction : InterfaceValue
        {
            public void Fire()
            {
                MessageBox.Show("使用 魔法 火焰");
            }

            public void Water(int SelecItem)
            {
                if (SelecItem < 50)
                {
                    MessageBox.Show("Water Gun");
                }
                else
                {
                    MessageBox.Show("Hydro Bump");
                }
            }
        }

        //火系按鈕
        private void button34_Click(object sender, EventArgs e)
        {
            MagicActionList.Fire();
        }

        //水系按鈕
        private void button35_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox3.Text))
            {
                int WaterValue = Convert.ToInt16(textBox3.Text);
                MagicActionList.Water(WaterValue);
            }
            else
            {
                Random Waterpower = new Random();
                int water = Waterpower.Next(1, 100);

                if (water < 50)
                {
                    textBox3.Text = "40";
                }
                else
                {
                    textBox3.Text = "70";
                }
                int WaterValue = Convert.ToInt16(textBox3.Text);
                MagicActionList.Water(WaterValue);
            }
        }

        public class ListItem
        {
            /// <summary>
            /// 使物件有Text及Value值，並能取得所選的代表值
            /// </summary>
            /// <param name="text">代表字</param>
            /// <param name="value">代表值</param>
            public ListItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            /// <summary>
            /// 取得字樣
            /// </summary>
            public string Text { get; set; }


            ///<summary>
            ///取得數值
            ///</summary>
            public string Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            //取出選取的ComboBox值
            MessageBox.Show("取代表字：" + ((ListItem)comboBox1.Items[comboBox1.SelectedIndex]).Text + Environment.NewLine +
                            "取代表值：" + ((ListItem)comboBox1.Items[comboBox1.SelectedIndex]).Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFile = new SaveFileDialog() { Filter = "JPEG|*.jpg" })
            {
                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    //編碼為QR Code，並儲存圖片
                    
                    //1.使用QRcode Library
                    MessagingToolkit.QRCode.Codec.QRCodeEncoder QREncoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();

                    //2.大小
                    QREncoder.QRCodeScale = 8;

                    //3.取得將要編碼的內容
                    string EnCoderString = "Value1:" + value1.Text + "\r\n" + "Value2:" + value2.Text;

                    //4.編碼成Bitmap
                    Bitmap bitmap = QREncoder.Encode(EnCoderString);

                    //5.於image元件顯示
                    pictureBox1.Image = bitmap;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                    //6.儲存編碼好的QR Code圖片
                    bitmap.Save(saveFile.FileName, ImageFormat.Jpeg);
                }
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            //設定儲存檔名
            string pathFileName = @"C:\OutputExcel.xlsx";

            //開啟一個新的應用程式
            Microsoft.Office.Interop.Excel.Application ExcelApplication = new Microsoft.Office.Interop.Excel.Application();

            //使Excel為可見狀態
            ExcelApplication.Visible = true;

            //新增新的活頁簿
            ExcelApplication.Workbooks.Add(Type.Missing);

            //使用第一個活頁簿
            Microsoft.Office.Interop.Excel._Workbook BookName = ExcelApplication.Workbooks[1];

            try
            {
                //引用第一個工作表
                Microsoft.Office.Interop.Excel._Worksheet SheetName = (Microsoft.Office.Interop.Excel._Worksheet)BookName.Worksheets[1];

                //設定工作表的名
                SheetName.Name = "Excel工作表";

                //將目前的工作表變成現用工作表
                SheetName.Activate();

                //設定第1列資料
                ExcelApplication.Cells[1, 1] = "名稱";
                ExcelApplication.Cells[1, 2] = "數值";

                //設定第2列資料
                ExcelApplication.Cells[2, 1] = "C#主角";
                ExcelApplication.Cells[2, 2] = "Null";

                //設定第3列資料
                ExcelApplication.Cells[3, 1] = "皮卡啾";
                ExcelApplication.Cells[3, 2] = "5★";

                //儲存活頁簿
                BookName.SaveAs(pathFileName);
                MessageBox.Show("已儲存完畢" + Environment.NewLine + "儲存路徑為:" + pathFileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("產出Excel出問題" + Environment.NewLine + "錯誤訊息:" + ex.Message);
            }

            //最終問題1:如何解決點到按鈕外會跳出錯誤的問題
            //最終問題2:其中一篇有著匯出音樂檔案的過程  最終無法匯出 (文件可以)
            }
        }
    }