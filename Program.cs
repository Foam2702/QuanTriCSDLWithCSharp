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
<<<<<<< HEAD
        Application.Run(new Login());
=======
        Oracle.ConnectOracle();
        //Application.Run(new Login());
>>>>>>> 5ff5bb15ec59c4b6421a820ab985daf7aad0ceed
        // Application.Run(new MainWindow());
        //Application.Run(new ListRoles());
        //Application.Run(new ListOfUsers());
        // Application.Run(new UserPrivileges());
        //Application.Run(new UserEditPrivileges());
       


    }
}