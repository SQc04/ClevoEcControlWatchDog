using System.Diagnostics;

namespace ClevoEcControlWatchDog
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            // ���������ѭ��
            while (true)
            {
                // ִ�����������������...

                // ��� ClevoEcControl.exe �Ƿ���������
                Process[] processes = Process.GetProcessesByName("ClevoEcControl");
                if (processes.Length == 0)
                {
                    // ��� ClevoEcControl.exe û�����У���ô������
                    Process.Start("ClevoEcControl.exe");
                    //Process.Start("D:\\I\\FAIRING STUDIO\\FSSoftware\\FSGarvityTool\\ClevoEcControl\\bin\\Debug\\net6.0-windows10.0.22000.0\\ClevoEcControl.exe");
                }

                // �ȴ�һ��ʱ����ٴμ��
                System.Threading.Thread.Sleep(5000);
            }
        }
    }
}