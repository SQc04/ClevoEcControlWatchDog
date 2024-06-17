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
            // 主程序的主循环
            while (true)
            {
                // 执行主程序的其他任务...

                // 检查 ClevoEcControl.exe 是否正在运行
                Process[] processes = Process.GetProcessesByName("ClevoEcControl");
                if (processes.Length == 0)
                {
                    // 如果 ClevoEcControl.exe 没有运行，那么启动它
                    Process.Start("ClevoEcControl.exe");
                    //Process.Start("D:\\I\\FAIRING STUDIO\\FSSoftware\\FSGarvityTool\\ClevoEcControl\\bin\\Debug\\net6.0-windows10.0.22000.0\\ClevoEcControl.exe");
                }

                // 等待一段时间后再次检查
                System.Threading.Thread.Sleep(5000);
            }
        }
    }
}