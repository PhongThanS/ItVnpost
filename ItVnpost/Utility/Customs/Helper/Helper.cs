using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ItVnpost.Utility.Customs.Helper
{
    public static class Helper
    {
        public static string FormatString(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }
            var step1 = Regex.Replace(value, @"<[^>]+>", "").Trim();
            var step2 = Regex.Replace(step1, @"&nbsp;", " ");
            var step3 = Regex.Replace(step2, @"\s{2,}", " ");
            return step3;
        }
        public static string ConvertAliasVN(string chuoicodau)
        {
            if (string.IsNullOrEmpty(chuoicodau))
            {
                return "";
            }
            const string FindText = "áàảãạâấầẩẫậăắằẳẵặđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶĐÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴ";
            const string ReplText = "aaaaaaaaaaaaaaaaadeeeeeeeeeeeiiiiiooooooooooooooooouuuuuuuuuuuyyyyyAAAAAAAAAAAAAAAAADEEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOOOUUUUUUUUUUUYYYYY";
            int index = -1;
            char[] arrChar = FindText.ToCharArray();
            while ((index = chuoicodau.IndexOfAny(arrChar)) != -1)
            {
                int index2 = FindText.IndexOf(chuoicodau[index]);
                chuoicodau = chuoicodau.Replace(chuoicodau[index], ReplText[index2]);
            }
            return chuoicodau.ToLower();
        }
        public static string ConvertAlias_VN(string chuoicodau)
        {
            if (string.IsNullOrEmpty(chuoicodau))
            {
                return "";
            }
            const string FindText = "áàảãạâấầẩẫậăắằẳẵặđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶĐÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴ";
            const string ReplText = "aaaaaaaaaaaaaaaaadeeeeeeeeeeeiiiiiooooooooooooooooouuuuuuuuuuuyyyyyAAAAAAAAAAAAAAAAADEEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOOOUUUUUUUUUUUYYYYY";
            int index = -1;
            char[] arrChar = FindText.ToCharArray();
            while ((index = chuoicodau.IndexOfAny(arrChar)) != -1)
            {
                int index2 = FindText.IndexOf(chuoicodau[index]);
                chuoicodau = chuoicodau.Replace(chuoicodau[index], ReplText[index2]);
            }
            chuoicodau = chuoicodau.Replace(" ", "-");
            return chuoicodau.ToLower();
        }
        public static string GetTextShort(string text, int textLength)
        {
            if (!String.IsNullOrEmpty(text))
            {
                string[] text1 = text.Split(" ");
                text = "";
                try
                {
                    for (int i = 0; i < text1.Length; i++)
                    {
                        text += " " + text1[i];
                        if(i == textLength)
                        {
                            break;
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {

                }
                return text.Trim();
            }
            else
            {
                return "";
            }
           
        }
        /// <summary>
        /// Mã hóa chuỗi MD5
        /// </summary>
        /// <param name="str">Chuỗi cần mã hóa</param>
        /// <returns></returns>
        public static string ToMD5(this string str)
        {
            string result = "";
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            for (int i = 0; i < buffer.Length; i++)
            {
                result += buffer[i].ToString("x2");
            }
            return result;
        }
    }
}
