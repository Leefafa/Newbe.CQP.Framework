using System;

namespace Newbe.CQP.Framework
{
    /// <summary>
    /// ��������쳣
    /// </summary>
    public class PluginLoadException : Exception
    {
        /// <summary>
        /// �������
        /// </summary>
        public string PluginName { get; }

        /// <summary>
        /// ԭ��
        /// </summary>
        public string Reason { get; }

        /// <summary>
        /// ��ʼ��
        /// </summary>
        /// <param name="pluginName"></param>
        /// <param name="reason"></param>
        public PluginLoadException(string pluginName, string reason)
        {
            PluginName = pluginName;
            Reason = reason;
        }

        /// <summary>
        /// ������Ϣ
        /// </summary>
        public override string Message => $"{PluginName}�������ʧ�ܣ�ԭ����:{Reason}";
    }
}