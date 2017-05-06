using System.IO;
using Newbe.CQP.Framework.Logging;

namespace Newbe.CQP.Framework
{
    public class PluginInfo
    {
        private static readonly ILog Logger = LogProvider.For<PluginInfo>();

        /// <summary>
        /// �������
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ����ʱ���dll·����CQP������ʱ�Ὣ���dll���Ƶ�tmpĿ¼���У����������ָ�����·��
        /// </summary>
        public string PluginApiExporterRuntimeFullpath { get; set; }

        /// <summary>
        /// �����ʵ�����dll�ļ�·��
        /// </summary>
        public string PluginEntryPointDllFullFilename { get; set; }

        /// <summary>
        /// ���Dll�����ļ���
        /// </summary>
        public string PluginEntyPointDirectory { get; set; }

        /// <summary>
        /// �����app.config�ļ�·��
        /// </summary>
        public string PluginEntryPointConfigFullFilename { get; set; }

        public override string ToString()
        {
            return
                $"{nameof(Name)}: {Name}, {nameof(PluginApiExporterRuntimeFullpath)}: {PluginApiExporterRuntimeFullpath}, {nameof(PluginEntryPointDllFullFilename)}: {PluginEntryPointDllFullFilename}, {nameof(PluginEntyPointDirectory)}: {PluginEntyPointDirectory}, {nameof(PluginEntryPointConfigFullFilename)}: {PluginEntryPointConfigFullFilename}";
        }

        public void ValidateFiles()
        {
            Logger.Debug(ToString);
            if (!File.Exists(PluginEntryPointDllFullFilename))
            {
                throw new FileNotFoundException(
                    $"�޷��ҵ�{Name}��������Dll����Ҫ��{Name}.dll����������Ƶ�{PluginEntyPointDirectory}");
            }
        }
    }
}