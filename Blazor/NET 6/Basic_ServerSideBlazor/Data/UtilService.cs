using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;


namespace BlazorAppSRvNET6.Data
{
    public class UtilService
    {
        private static string _keyCode;

        public string KeyCode
        {
            get
            {
                return _keyCode;
            }
            set
            {
                _keyCode = value;
            }
        }

        public void SetKeyValue(string value)
        {
            _keyCode = value;
        }
    }
}
