using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class SigninResult
    {
        public string Token { get; set; }
        public UserData User { get; set; }
    }
}
