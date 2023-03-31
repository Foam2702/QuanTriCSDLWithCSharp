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
        //Application.Run(new Login());
        // Application.Run(new MainWindow());
<<<<<<< HEAD
       //Application.Run(new ListOfUsers());
        // Application.Run(new UserPrivileges());
        Application.Run(new UserEditPrivileges());
    }    
=======
        //Application.Run(new ListOfUsers());
        //Application.Run(new UserPrivileges());

    }
>>>>>>> bbc0040fcfdaff4f3569443a085040b3909494e2
}