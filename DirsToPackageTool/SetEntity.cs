using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirsToPackageTool
{
    public static class SetEntity
    {
        private static string _testTarPath;
        private static string _testExpPath;
        private static string _testBinPath;
        private static int _testNum;

        private static string _formalTarPath;
        private static string _formalExpPath;
        private static string _formalBinPath;
        private static int _formalNum;

        public static System.Drawing.Point Point { get; set; }

        //初始化值 
        private static ToolEnum.WebName _webName=ToolEnum.WebName.zgw;//是打zgw包还是zms包

        //移动到的文件夹
        public static string TestTarPath
        {
            get
            {
                if (_testExpPath == null)
                {
                    return "";
                }
                return _testTarPath;
            }
            set
            {
                //写入文件中，如何没有问题则赋值给TestTarPath

                _testTarPath = value;
            }
        }
        //从这个文件夹移动
        public static string TestExpPath
        {
            get
            {
                if (_testTarPath == null)
                {
                    return "";
                }
                return _testExpPath;
            }
            set
            {
                //写入文件中，如何没有问题则赋值给TestTarPath

                _testExpPath = value;
            }
        }
        public static int TestNum
        {
            get
            {
                if (_testNum == 0)
                {
                    return 1;
                }
                return _testNum;
            }
            set
            {
                _testNum = value;
            }
        }        
        public static string TestBinPath
        {
            get
            {
                if (_testBinPath == null)
                {
                    return "";
                }
                return _testBinPath;
            }
            set
            {
                _testBinPath = value;
            }
        }

        //正式环境
        public static string FormalExpPath
        {
            get
            {
                if (_formalTarPath == null)
                {
                    return "";
                }
                return _formalExpPath;
            }
            set
            {
                //写入文件中，如何没有问题则赋值给TestTarPath

                _formalExpPath = value;
            }
        }
        public static string FormalTarPath
        {
            get
            {
                if (_formalExpPath == null)
                {
                    return "";
                }
                return _formalTarPath;
            }
            set
            {               

                _formalTarPath = value;
            }
        }
        public static string FormalBinPath
        {
            get
            {
                if (_formalBinPath == null)
                {
                    return "";
                }
                return _formalBinPath;
            }
            set
            {
                _formalBinPath = value;
            }
        }
        public static int FormalNum
        {
            get
            {
                if (_formalNum == 0)
                {
                    return 1;
                }
                return _formalNum;
            }
            set
            {
                _formalNum = value;
            }
        }
        public static ToolEnum.WebName WebName
        {
            get
            {
                return _webName;
            }
            set
            {
                _webName = value;
            }
        }
        
    }
}
