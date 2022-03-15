using System;

namespace SampleCalc
{
    public class clsCalc
    {
        /// <summary>
        /// 計算メソッド
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public string Calc(string A, string B)
        {
            return (Convert.ToInt16(A) * Convert.ToInt16(B)).ToString();
        }

        public string InText = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        public void XXX()
        {
            InText = "TEST";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int YYY(string a, string b, string c)
        {
            return 0;
        }
    }
}
