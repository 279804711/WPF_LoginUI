using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginUI
{
    public class LoginModel
    {
        private String _UserName;
        public String UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
                //RaisePropertyChanged("userName");
            }
        }

        private String _PassWord;
        public String PassWord
        {
            get { return _PassWord; }
            set
            {
                _PassWord = value;
                //RaisePropertyChanged("passWord");
            }
        }

    }
}
