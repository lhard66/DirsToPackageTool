using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirsToPackageTool
{
    public class ToolEnum
    {
        public enum WebName
        {
            [Description("ZGW网站打包")]
            zgw,
            [Description("ZMS网站打包")]
            zms
        }
        public enum WebType
        {
            [Description("测试环境打包")]
            test,
            [Description("正式环境打包")]
            formal,
            [Description("导出文件")]
            export
        }
    }
}
