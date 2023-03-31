namespace Myfirst;

partial class UserEditPrivileges
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
        this.Text = "User Privileges";
        ResizeWindowForm();
        CreateLabel();
        CreateRoleLabel();
        CreateSelectButton();
        CreateInsertButton();
        CreateDeleteButton();
        CreateUpdateButton();
        CreateLabelRoleResult();
        CreateMainLabel();
        CreateEditRoleButton();
        CreateBackButton();
        CreateEditPrivileges();
    }
    private void ResizeWindowForm(){
        this.MinimumSize= new Size(800,600);
        this.MaximumSize = new Size(1000, 800);
    }

    private void CreateLabel()
    {
        Label title1 = new Label();
        title1.Text = "USERS'S Privileges";
        title1.Location = new Point(350, 20);
        title1.Size = new Size(500, 60);
        title1.Font = new Font(title1.Font.FontFamily, 18, title1.Font.Style);
        this.Controls.Add(title1);
    }
    
    private void CreateLabelRole()
    {
        Label title1 = new Label();
        title1.Text = "USERS'S Privileges";
        title1.Location = new Point(350, 20);
        title1.Size = new Size(500, 60);
        title1.Font = new Font(title1.Font.FontFamily, 18, title1.Font.Style);
        this.Controls.Add(title1);
    }
    
    private void CreateRoleLabel()
    {
        Label title1 = new Label();
        title1.Text = "ROLE";
        title1.Location = new Point(50, 100);
        title1.Size = new Size(120, 60);
        title1.Font = new Font(title1.Font.FontFamily, 12, title1.Font.Style);
        title1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        title1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(title1);
    }
    
    private void CreateSelectButton()
    {
        Button button = new Button();
        button.Text = "SELECT";
        button.Location = new Point(50, 210);
        button.Size = new Size(120, 60);
        button.Font = new Font(button.Font.FontFamily, 12, button.Font.Style);
        button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(button);

        button.Click += myButton_Click;
        void myButton_Click(object sender, EventArgs e)
        {   
            if (selectedButton != null) // Nếu đã có button được chọn
            {
                selectedButton.BackColor = SystemColors.Control;
                selectedButton.Enabled = true; // Enable button trước đó
            }
            selectedButton = button; // Gán selectedButton bằng button mới
            button.BackColor=Color.Gray;
            button.Enabled = false; // Disable button đang được chọn
        }
    }
    private void CreateInsertButton()
    {
        Button button = new Button();
        button.Text = "INSERT";
        button.Location = new Point(50, 320);
        button.Size = new Size(120, 60);
        button.Font = new Font(button.Font.FontFamily, 12, button.Font.Style);
        button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(button);

        button.Click += myButton_Click;
        void myButton_Click(object sender, EventArgs e)
        {   
            if (selectedButton != null) // Nếu đã có button được chọn
            {
                selectedButton.BackColor = SystemColors.Control;
                selectedButton.Enabled = true; // Enable button trước đó
            }
            selectedButton = button; // Gán selectedButton bằng button mới
            button.BackColor=Color.Gray;
            button.Enabled = false; // Disable button đang được chọn
        }
    }
    private void CreateUpdateButton()
    {
        Button button = new Button();
        button.Text = "UPDATE";
        button.Location = new Point(50, 430);
        button.Size = new Size(120, 60);
        button.Font = new Font(button.Font.FontFamily, 12, button.Font.Style);
        button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(button);

        button.Click += myButton_Click;
        void myButton_Click(object sender, EventArgs e)
        {   
            if (selectedButton != null) // Nếu đã có button được chọn
            {
                selectedButton.BackColor = SystemColors.Control;
                selectedButton.Enabled = true; // Enable button trước đó
            }
            selectedButton = button; // Gán selectedButton bằng button mới
            button.BackColor=Color.Gray;
            button.Enabled = false; // Disable button đang được chọn
        }
    }
    private void CreateDeleteButton()
    {
        Button button = new Button();
        button.Text = "DELETE";
        button.Location = new Point(50, 540);
        button.Size = new Size(120, 60);
        button.Font = new Font(button.Font.FontFamily, 12, button.Font.Style);
        button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(button);

        button.Click += myButton_Click;
        void myButton_Click(object sender, EventArgs e)
        {   
            if (selectedButton != null) // Nếu đã có button được chọn
            {
                selectedButton.BackColor = SystemColors.Control;
                selectedButton.Enabled = true; // Enable button trước đó
            }
            selectedButton = button; // Gán selectedButton bằng button mới
            button.BackColor=Color.Gray;
            button.Enabled = false; // Disable button đang được chọn
        }
    }

    private void CreateLabelRoleResult()
    {
        Label title1 = new Label();
        title1.Text = "Admin";
        title1.Location = new Point(300, 100);
        title1.Size = new Size(600, 60);
        title1.Font = new Font(title1.Font.FontFamily, 12, title1.Font.Style);
        title1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        title1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(title1);
    }

    private void CreateMainLabel()
    {
        Label mainlabel = new Label();
        mainlabel.Location = new Point(300, 210);
        mainlabel.Size = new Size(600, 430);
        mainlabel.Font = new Font(mainlabel.Font.FontFamily, 12, mainlabel.Font.Style);
        mainlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        mainlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        string dongDa = "DONGDA:\n\tCAUTHU(HOTEN,VITRI)\n\tDOIBONG(TENDOIBONG)";
        string thuVien = "THUVIEN:\n\tSACH(MASACH,TENSACH)\n\tDOCGIA(TENDOCGIA)";
        string qlNhanVien = "QLNHANVIEN:\n\tNHANVIEN(MANHANVIEN,TUOI)\n\tPHONGBAN(MAPHONGBAN)";

        string formattedString = String.Format("{0}\n\n{1}\n\n{2}", dongDa, thuVien, qlNhanVien);
        mainlabel.Text = formattedString;
       


        this.Controls.Add(mainlabel);
    }

    private void CreateEditRoleButton()
    {
        Button button = new Button();
        button.Location = new Point(300, 660);
        button.Size = new Size(200, 50);
        button.Text="Edit Role";
        button.Font = new Font(button.Font.FontFamily, 12, button.Font.Style);
        button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(button);

        button.Click += myButton_Click;
        void myButton_Click(object sender, EventArgs e)
        {   
            //Login form2 = new Login();
            //form2.Show();
        }
    }

    private void CreateEditPrivileges()
    {
        Button button = new Button();
        button.Location = new Point(700, 660);
        button.Size = new Size(200, 50);
        button.Text="Edit Privileges";
        button.Font = new Font(button.Font.FontFamily, 12, button.Font.Style);
        button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(button);


        button.Click += myButton_Click;
        void myButton_Click(object sender, EventArgs e)
        {   
            //Login form2 = new Login();
            //form2.Show();
        }
        
    }

    private void CreateBackButton(){
        Button backbutton = new Button();
        backbutton.Location=new Point(50,660);
        backbutton.Size=new Size(100,50);
        backbutton.Font = new Font(backbutton.Font.FontFamily, 12, backbutton.Font.Style);
        backbutton.Text="Back";
        this.Controls.Add(backbutton);

        backbutton.Click += new EventHandler(backbutton_Click);
        void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    #endregion
}
