namespace Myfirst;

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
        Oracle.ConnectOracle();
        //Application.Run(new Login());
        // Application.Run(new MainWindow());
        Application.Run(new ListRoles());
        //Application.Run(new ListOfUsers());
        // Application.Run(new UserPrivileges());
        //Application.Run(new UserEditPrivileges());
    }
}