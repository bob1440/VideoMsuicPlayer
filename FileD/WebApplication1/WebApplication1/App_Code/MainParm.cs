using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class MainParm
    {
        private static MainParm _Instance;
        public static MainParm Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new MainParm();
                return _Instance;
            }
            set { _Instance = value; }
        }
        private string _Dir = "D:\\WEB\\vmplayer\\music\\";
      //  private string _Dir = "C:\\Users\\PUWU\\Documents\\GitHub\\VideoMsuicPlayer\\FileD\\WebApplication1\\WebApplication1\\music\\";
        public string Dir { get { return _Dir; } }

    
    }
}