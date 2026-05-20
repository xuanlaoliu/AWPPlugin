using System.ComponentModel;
using Exiled.API.Interfaces;

namespace AWPPlugin
{
    public class Config : IConfig
    {
        [Description("是否启用本插件")]
        public bool IsEnabled { get; set; } = true;

        [Description("是否输出调试日志到控制台")]
        public bool Debug { get; set; } = false;
    }
}