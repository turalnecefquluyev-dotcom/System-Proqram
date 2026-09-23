using System.Diagnostics;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var currentProcess = Process.GetCurrentProcess();
            //Console.WriteLine($"Process name: {currentProcess.ProcessName}");
            //Console.WriteLine($"Process Id: {currentProcess.Id}");
            //Console.WriteLine($"Start time: {currentProcess.StartTime}");
            //Console.WriteLine($"Thread count: {currentProcess.Threads.Count}");
            //Console.WriteLine($"Proccess: {currentProcess.TotalProcessorTime}");
            //Thread.Sleep(1000);
            //currentProcess.Kill();
            //for (int i = 0; i < 100; i++)
            //{
            //    Process.Start("mspaint.exe");
            //}
            //var all_process = Process.GetProcesses();
            //foreach (var process in all_process)
            //{
            //    Console.WriteLine(process.ProcessName);
            //}
            //Thread.Sleep(5000);
            //var all_proccess = Process.GetProcesses();
            //foreach (var process in all_process)
            //{
            //    if (process.ProcessName.Contains("mspaint"))
            //    {
            //        process.Kill();
            //    }
            //}
            //Process.Start(@"C:\\Program Files (x86)\\Microsoft\\Edge\\Application\msedge.exe", @"https://www.google.com/search?sca_esv=831fd6021be0bd8e&rlz=1C1GCEB_enAZ1232&sxsrf=APpeQnvCT-3jjmzLSMHfcgSPUeSJ24l4yA:1789896249058&udm=2&fbs=ABfTbFVge1M6sHI9uiJLBEEUlg7zLEs43eyhF4kow2-M4-MSYqq6uPuu_taeqoTIujba0kV9F6D2s9PKcf-WxvBoGZHkvv7nVVBVxVCN6QN7ExJF7GuZHwpBJjKhgV_d1l8Jx8OzIyMlaBNzM7juCMDvoFea8Njj8C4dQJoMsym_IBZzVpD2t9ZY3UStdyrmFlnf79wgqqbnL3gx9j6TP9f0bre_w-k1XA&q=madaqascar&sa=X&ved=2ahUKEwiyk_CQ6_yWAxV4R_EDHRuLEtUQtKgLegQIFxAB&biw=929&bih=917&dpr=1#sv=CAMSXhoyKhBlLWYtNjZreERCSGVUSldNMg5mLTY2a3hEQkhlVEpXTToON2xhYjZUeExiQVlrOE0gBCokCg5PaGlIMUNXZXYyVW1OTRIQZS1mLTY2a3hEQkhlVEpXTRgAMAEYByDrsfDzAUoIEAEYASABKAE%22);
            Console.WriteLine("Youtubeda axtarmaq istediyiniz video adini yazin: ");
            var query = Console.ReadLine();
            Process.Start(@"C:\\Program Files (x86)\\Microsoft\\Edge\\Application\msedge.exe", @$"https://www.youtube.com/watch?v=mhfJSTJTnXU{query}");
        }
    }
}