namespace Myfirst;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
<<<<<<< HEAD

        Application.Run(new Login());
        // Application.Run(new MainWindow();
        //Application.Run(new ListRoles());
        // Myfirst.Oracle test = new Oracle();
        // test.Test();

=======
<<<<<<< HEAD
        Application.Run(new Login());
=======
        Oracle.ConnectOracle();
        //Application.Run(new Login());
>>>>>>> 5ff5bb15ec59c4b6421a820ab985daf7aad0ceed
        // Application.Run(new MainWindow());
        //Application.Run(new ListRoles());
>>>>>>> 24a28b68ffa4278b0e20c155faae20e16d5ee0c9
        //Application.Run(new ListOfUsers());
        // Application.Run(new UserPrivileges());
        //Application.Run(new UserEditPrivileges());
       


    }
}