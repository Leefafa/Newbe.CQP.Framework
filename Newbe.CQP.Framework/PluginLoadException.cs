using System;

namespace Newbe.CQP.Framework
{
    public class PluginLoadException : Exception
    {
        public string PluginName { get; }
        public string Reason { get; }

        public PluginLoadException(string pluginName, string reason)
        {
            PluginName = pluginName;
            Reason = reason;
        }

        public override string Message => $"{PluginName}�������ʧ�ܣ�ԭ����:{Reason}";
    }
}