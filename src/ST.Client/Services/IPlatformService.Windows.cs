using System.Diagnostics;
using System.Runtime.Versioning;

namespace System.Application.Services
{
    partial interface IPlatformService
    {
        /// <summary>
        /// 打开桌面图标设置
        /// </summary>
        [SupportedOSPlatform("Windows7.0")]
        void OpenDesktopIconsSettings()
        {

        }

        [SupportedOSPlatform("Windows7.0")]
        void OpenGameControllers()
        {

        }

        /// <summary>
        /// 已正常权限启动进程
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        [SupportedOSPlatform("Windows7.0")]
        Process? StartAsInvoker(string fileName, string? arguments = null)
        {
            return Process2.Start(fileName, arguments);
        }

        ///// <summary>
        ///// 获取占用端口的进程
        ///// </summary>
        ///// <param name="port"></param>
        ///// <param name="isTCPorUDP"></param>
        ///// <returns></returns>
        //[SupportedOSPlatform("Windows7.0")]
        //Process? GetProcessByPortOccupy(ushort port, bool isTCPorUDP = true)
        //{
        //    return null;
        //}

        /// <summary>
        /// 从管理员权限进程中降权到普通权限启动进程
        /// </summary>
        /// <param name="cmdArgs"></param>
        [SupportedOSPlatform("Windows7.0")]
        void UnelevatedProcessStart(string cmdArgs)
        {

        }

        [SupportedOSPlatform("Windows7.0")]
        void FixAvaloniaFluentWindowStyleOnWin7(IntPtr hWnd)
        {

        }

        /// <summary>
        /// 获取当前 Windows 系统产品名称，例如 Windows 10 Pro
        /// </summary>
        [SupportedOSPlatform("Windows7.0")]
        string WindowsProductName => string.Empty;

        /// <summary>
        /// 获取当前 Windows 系统第四位版本号
        /// </summary>
        [SupportedOSPlatform("Windows7.0")]
        int WindowsVersionRevision => default;

        /// <summary>
        /// 获取当前 Windows 10/11 系统显示版本，例如 21H1
        /// </summary>
        [SupportedOSPlatform("Windows7.0")]
        string WindowsReleaseIdOrDisplayVersion => string.Empty;
    }
}
