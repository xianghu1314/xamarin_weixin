using System;
using System.Text;
using Microsoft.International.Converters.PinYinConverter;

namespace linli.Utils
{
    public class SpellUtils
    {
        public SpellUtils()
        {
        }
        /// <summary> 
        /// 汉字转化为拼音
        /// </summary> 
        /// <param name="str">汉字</param> 
        /// <returns>全拼</returns> 
        public static string GetPinyin(string str)
        {
            string r = string.Empty;
            foreach (char obj in str)
            {
                try
                {
                    ChineseChar chineseChar = new ChineseChar(obj);
                    string t = chineseChar.Pinyins[0].ToString();
                    r += t.Substring(0, t.Length - 1);
                }
                catch
                {
                    r += obj.ToString();
                }
            }
            return r;
        }
        /// <summary> 
        /// 汉字转化为拼音首字母
        /// </summary> 
        /// <param name="str">汉字</param> 
        /// <returns>首字母</returns> 
        public static string GetFirstPinyin(char str,string def = null)
        {

            //如果是字母，则直接返回

            if ((((int)str) > 96 && ((int)str) < 123)||(((int)str) > 64 && ((int)str) < 91))
            {
                return str.ToString().ToUpper();
            }
            else
            {
                string r = string.Empty;
                try
                {
                    ChineseChar chineseChar = new ChineseChar(str);
                    string t = chineseChar.Pinyins[0].ToString();
                    r += t.Substring(0, 1);
                }
                catch
                {
                    r += def ?? str.ToString();
                }
                return r;
            }
        }
    }
}
