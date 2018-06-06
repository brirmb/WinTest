using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 金额大写
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            double m = 13.55 * 10000;
            string money = ConvertToChinese2(m);
            MessageBox.Show(money);
        }

        private string ConvertToChinese(double dou)
        {
            string s = dou.ToString("#L#E#D#C#K#E#D#C#J#E#D#C#I#E#D#C#H#E#D#C#G#E#D#C#F#E#D#C#.0B0A");
            string d = Regex.Replace(s,
                @"((?<=-|^)[^\-1-9]*)|((?'z'0)[0A-E]*((?=[1-9])|(?'-z'(?=[F-L\.]|$))))  
    |((?'b'[F-L])(?'z'0)[0A-L]*((?=[1-9])|(?'-z'(?=[\.]|$))))", "${b}${z}");
            string RMB = "负元空零壹贰叁肆伍陆柒捌玖空空空空空空空分角拾佰仟万亿兆京垓秭穰";
            string r = Regex.Replace(d, ".", m => RMB[m.Value[0] - '-'].ToString());
            //        string r = Regex.Replace(d, ".",
            //delegate (Match m) { return RMB[m.Value[0] - '-'].ToString(); });
            if (r.EndsWith("元"))
                r = r + "整";

            // 替换零佰、零仟、零拾之类的字符  
            r = Regex.Replace(r, "[零]+仟", "零");
            r = Regex.Replace(r, "[零]+佰", "零");
            r = Regex.Replace(r, "[零]+拾", "零");
            r = Regex.Replace(r, "[零]+亿", "亿");
            r = Regex.Replace(r, "[零]+万", "万");
            r = Regex.Replace(r, "[零]+", "零");
            r = Regex.Replace(r, "亿[万|仟|佰|拾]+", "亿");
            r = Regex.Replace(r, "万[仟|佰|拾]+", "万");
            r = Regex.Replace(r, "仟[佰|拾]+", "仟");
            r = Regex.Replace(r, "佰拾", "佰");
            r = Regex.Replace(r, "[零]+元整", "元整");
            return r;
        }

        private string ConvertToChinese2(double dou)
        {
            // 大写数字数组  
            string[] num = { "零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖" };
            // 数量单位数组，个位数为空  
            string[] unit = { "", "拾", "佰", "仟", "万", "拾", "佰", "仟", "亿", "拾", "佰", "仟", "兆" };
            string d = dou.ToString();
            string zs = string.Empty;// 整数  
            string xs = string.Empty;// 小数  
            int i = d.IndexOf(".");
            string str = string.Empty;
            if (i > -1)
            {
                // 仅考虑两位小数  
                zs = d.Substring(0, i);
                xs = d.Substring(i + 1, d.Length - i - 1);
                str = "元";
                if (xs.Length == 1)
                    str = str + xs + "角";
                else if (xs.Length == 2)
                    str = str + xs.Substring(0, 1) + "角" + xs.Substring(1, 1) + "分";
            }
            else
            {
                zs = d;
                str = "元整";
            }
            // 处理整数部分  
            if (!string.IsNullOrEmpty(zs))
            {
                i = 0;
                // 从整数部分个位数起逐一添加单位  
                foreach (char s in zs.Reverse())
                {
                    str = s.ToString() + unit[i] + str;
                    i++;
                }
            }
            // 将阿拉伯数字替换成中文大写数字  
            for (int m = 0; m < 10; m++)
            {
                str = str.Replace(m.ToString(), num[m]);
            }
            // 替换零佰、零仟、零拾之类的字符  
            str = Regex.Replace(str, "[零]+仟", "零");
            str = Regex.Replace(str, "[零]+佰", "零");
            str = Regex.Replace(str, "[零]+拾", "零");
            str = Regex.Replace(str, "[零]+亿", "亿");
            str = Regex.Replace(str, "[零]+万", "万");
            str = Regex.Replace(str, "[零]+", "零");
            str = Regex.Replace(str, "亿[万|仟|佰|拾]+", "亿");
            str = Regex.Replace(str, "万[仟|佰|拾]+", "万");
            str = Regex.Replace(str, "仟[佰|拾]+", "仟");
            str = Regex.Replace(str, "佰拾", "佰");
            //str = Regex.Replace(str, "[零]+元整", "元整");
            str = Regex.Replace(str, "[零]+元整", "");
            return str;
        }

    }
}
