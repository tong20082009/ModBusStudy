using Microsoft.Extensions.DependencyInjection;

namespace ModBusStudy.App;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        // 1. 创建依赖注入容器
        var services = new ServiceCollection();

        // 2. 注册主窗体（以后每新增一个服务/驱动，都在这里加一行）
        services.AddSingleton<MainForm>();

        // 3. 构建容器，解析出主窗体并启动
        using var provider = services.BuildServiceProvider();
        Application.Run(provider.GetRequiredService<MainForm>());
    }    
}