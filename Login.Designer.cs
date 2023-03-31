namespace Myfirst;

partial class Login
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    public void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1000, 800);
        this.Text = "Login";
        ResizeWindowForm();
        CreateLabel();
        CreateMainLabel();
        CreateLoginButton();
        CreateBackButton();
    }

    private void ResizeWindowForm(){
        this.MinimumSize= new Size(800,600);
        this.MaximumSize = new Size(1000, 800);
    }

    private void CreateLabel()
    {
        //string[] rs=Oracle.ConnectOracle();
        Label title1 = new Label();
        title1.Text = "LOGIN";
        title1.Location = new Point(350, 20);
        title1.Size = new Size(500, 60);
        title1.Font = new Font(title1.Font.FontFamily, 18, title1.Font.Style);
        this.Controls.Add(title1);
    }
    private void CreateMainLabel()
    {
        Label mainlabel=new Label();
        mainlabel.Location=new Point(100,150);
        mainlabel.Size=new Size(800,400);
        mainlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        mainlabel.Font = new Font(mainlabel.Font.FontFamily, 14, mainlabel.Font.Style);
        this.Controls.Add(mainlabel);
         
        
        Label servername=new Label();
        servername.Location=new Point(100,70);
        servername.Size=new Size(200,50);
        servername.Text="ServerName";
        servername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        servername.Font = new Font(servername.Font.FontFamily, 14, servername.Font.Style);
        //servername.BackColor=Color.Blue;
        mainlabel.Controls.Add(servername);

        ComboBox serverinput = new ComboBox();
        serverinput.Location=new Point(350,70);
        serverinput.Size=new Size(400,50);
        serverinput.Items.AddRange(new string[] { "Item 1", "Item 2", "Item 3" });
        servername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //serverinput.BackColor=Color.Red;
        mainlabel.Controls.Add(serverinput);

        Label userlabel=new Label();
        userlabel.Location=new Point(100,170);
        userlabel.Size=new Size(200,50);
        userlabel.Text="UserName";
        userlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        userlabel.Font = new Font(userlabel.Font.FontFamily, 14, userlabel.Font.Style);
        //userlabel.BackColor=Color.Blue;
        mainlabel.Controls.Add(userlabel);

        TextBox userinput = new TextBox();
        userinput.Location=new Point(350,170);
        userinput.Size=new Size(400,50);
        servername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //userinput.BackColor=Color.Red;
        mainlabel.Controls.Add(userinput);
        

        Label password=new Label();
        password.Location=new Point(100,270);
        password.Size=new Size(200,50);
        password.Text="Password";
        password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        password.Font = new Font(password.Font.FontFamily, 14, password.Font.Style);
        //password.BackColor=Color.Blue;
        mainlabel.Controls.Add(password);

        TextBox passwordinput = new TextBox();
        passwordinput.Location=new Point(350,270);
        passwordinput.Size=new Size(400,50);
        servername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //passwordinput.BackColor=Color.Red;
        mainlabel.Controls.Add(passwordinput);

    }

    private void CreateLoginButton(){
        Button loginbutton = new Button();
        loginbutton.Location=new Point(120,600);
        loginbutton.Size=new Size(200,80);
        loginbutton.Text="Login";
        this.Controls.Add(loginbutton);

        loginbutton.Click += new EventHandler(loginbutton_Click);
        void loginbutton_Click(object sender, EventArgs e)
        {
            //loginbutton.Text="Success";
        }
    }

    private void CreateBackButton(){
        Button backbutton = new Button();
        backbutton.Location=new Point(680,600);
        backbutton.Size=new Size(200,80);
        backbutton.Text="Back";
        this.Controls.Add(backbutton);

        backbutton.Click += new EventHandler(backbutton_Click);
        void backbutton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
   

    #endregion
}
