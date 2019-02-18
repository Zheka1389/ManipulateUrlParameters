using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateUrlParameters
{
    public class ManipulateUrlParameters
    {
        public static string AddOrChangeUrlParameter(string url, string param)
        {
            int index = url.IndexOf('?');
            int index1 = url.IndexOf('=');
            int index2 = param.IndexOf('=');
            Console.WriteLine(index2);
            string st = "", result = "";
            for (int i = 0; i < index2; i++)
            {
                st += param[i];
            }
            if (url.Contains(st))
            {
                result = url.Remove(index + 1);
                result = result.Insert(index + 1, param);
            }
            else
            {
                if(index1 == -1)
                    result = url + "?" + param;
                else
                    result = url + "&" + param;
            }               
            return result;
        }
    }
}
