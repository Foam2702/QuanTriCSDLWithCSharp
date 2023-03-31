namespace Myfirst;

partial class MainWindow
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
        this.Text = "Main Window";
        ResizeWindowForm();
        CreateLabelTittle();
        CreateLabelUser();
        CreateButtonLogout();
        CreateMainLabel();
    }

    private void ResizeWindowForm(){
        this.MinimumSize= new Size(800,600);
        this.MaximumSize = new Size(1000, 800);
    }

    private void CreateLabelTittle()
    {
        Label title1 = new Label();
        title1.Text = "MAIN WINDOW";
        title1.Location = new Point(350, 20);
        title1.Size = new Size(300, 60);
        title1.Font = new Font(title1.Font.FontFamily, 18, title1.Font.Style);
        this.Controls.Add(title1);
    }
    
    private void CreateLabelUser()
    {
        Label title1 = new Label();
        title1.Text = "User Name";
        title1.Location = new Point(50, 20);
        title1.Size = new Size(200, 60);
        title1.Font = new Font(title1.Font.FontFamily, 12, title1.Font.Style);
        title1.TextAlign = ContentAlignment.MiddleCenter;
        this.Controls.Add(title1);
    }

    private void CreateButtonLogout()
    {
        Button logoutbutton=new Button();
        logoutbutton.Text="Log out";
        logoutbutton.Location=new Point(700,20);
        logoutbutton.Size=new Size(200,60);
        logoutbutton.Font = new Font(logoutbutton.Font.FontFamily, 12, logoutbutton.Font.Style);
        this.Controls.Add(logoutbutton);
    }

    private void CreateMainLabel()
    {
        Label mainlabel=new Label();
        mainlabel.Location=new Point(100,150);
        mainlabel.Size=new Size(800,300);
        mainlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        mainlabel.Font = new Font(mainlabel.Font.FontFamily, 14, mainlabel.Font.Style);
        this.Controls.Add(mainlabel);

        Button button1=new Button();
        button1.Location=new Point(200,50);
        button1.Size=new Size(350,50);
        button1.Text="List of Users";
        button1.Font = new Font(button1.Font.FontFamily, 14, button1.Font.Style);
        mainlabel.Controls.Add(button1);
        button1.Click += myButton_Click;
        void myButton_Click(object sender, EventArgs e)
        {   
            if (selectedButton != null) // Nếu đã có button được chọn
            {
                selectedButton.BackColor = SystemColors.Control;
                selectedButton.Enabled = true; // Enable button trước đó
            }
            selectedButton = button1; // Gán selectedButton bằng button mới
            button1.BackColor=Color.Gray;
            button1.Enabled = false; // Disable button đang được chọn
        }

        Button button2=new Button();
        button2.Location=new Point(200,170);
        button2.Size=new Size(350,50);
        button2.Text="List of Role";
        button2.Font = new Font(button2.Font.FontFamily, 14, button2.Font.Style);
        mainlabel.Controls.Add(button2);

        button2.Click += myButton_Click1;
        void myButton_Click1(object sender, EventArgs e)
        {   
            if (selectedButton != null) // Nếu đã có button được chọn
            {
                selectedButton.BackColor = SystemColors.Control;
                selectedButton.Enabled = true; // Enable button trước đó
            }
            selectedButton = button2; // Gán selectedButton bằng button mới
            button2.BackColor=Color.Gray;
            button2.Enabled = false; // Disable button đang được chọn
        }
    }

    #endregion
}
