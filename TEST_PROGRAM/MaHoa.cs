using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class MaHoa
    {
        public static string BinaryCode(string data)
        {
            string first = "", last = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (i % 2 == 0)
                {
                    first += Decimal_to_Binary(Convert.ToInt32(data[i]));
                }
                else
                {
                    last += Decimal_to_Binary(Convert.ToInt32(data[i]));
                }
            }
            return first + last;
        }
        public static string BinaryCode_GiaiMa(string binaryCode)
        {
            string giaiMa = "";
            int[] arr = new int[binaryCode.Length / 8];
            for (int index = 0; index < arr.Length; index++)
            {
                arr[index] = Binary_to_Decimal(binaryCode.Substring(index * 8, 8));
            }
            int i = 0, j = (arr.Length / 2);
            bool check = false;
            if (arr.Length % 2 != 0)
            {
                j++;
                while (j <= arr.Length)
                {
                    if (check)
                    {
                        giaiMa += Convert.ToChar(arr[j]);
                        j++;
                        check = false;
                    }
                    else
                    {
                        giaiMa += Convert.ToChar(arr[i]);
                        i++;
                        check = true;
                    }
                    if (i == arr.Length / 2 + 1)
                        break;
                }
            }
            else
            {
                while (j < arr.Length)
                {
                    if (check)
                    {
                        giaiMa += Convert.ToChar(arr[j]);
                        j++;
                        check = false;
                    }
                    else
                    {
                        giaiMa += Convert.ToChar(arr[i]);
                        i++;
                        check = true;
                    }
                }
            }
            return giaiMa;
        }
        private static string Decimal_to_Binary(int deci)
        {
            string binary = "";
            for (int i = 1; i <= 8; i++)
            {
                binary = (deci % 2).ToString() + binary;
                deci /= 2;
            }
            return binary;
        }
        private static int Binary_to_Decimal(string binary)
        {
            int deci = 0;
            for (int i = 0; i < 8; i++)
            {
                deci += int.Parse(binary[i].ToString()) * (int)Math.Pow(2, 8 - i - 1);
            }
            return deci;
        }
    }
}
