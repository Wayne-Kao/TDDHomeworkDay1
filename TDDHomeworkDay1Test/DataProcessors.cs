using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TDDHomeworkDay1Test
{
    public class DataProcessors
    {
        public int[] GroupAndSum<T>(List<T> sourceDatas, string propertyName, int numberOfGroups)
        {
            List<int> result = new List<int>();
            int groupSum = 0;
            PropertyInfo pinfo = typeof(T).GetProperty(propertyName);
            for (int i = 0; i < sourceDatas.Count(); i++)
			{
                int propertyValue;
                //確保資料型別是數字
                if (int.TryParse(pinfo.GetValue(sourceDatas.ElementAt(i)).ToString(), out propertyValue))
                {
                    groupSum += propertyValue;
                }

                //整除 或 最後一筆資料
                if (((i + 1) % numberOfGroups) == 0 || (i == sourceDatas.Count() - 1))
                {
                    result.Add(groupSum);
                    //歸0
                    groupSum = 0;
                }
			}
            return result.ToArray();
        }
    }
}
