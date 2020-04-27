using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.MODULE.XyLuDatabase
{
    public class ChuyenDoi<T>
    {
        public static List<T> Hashtable_to_List(Hashtable hashtable)
        {
            List<T> list = new List<T>();
            foreach (DictionaryEntry obj in hashtable)
                list.Add((T)obj.Value);
            return list;
        }
    }
}
