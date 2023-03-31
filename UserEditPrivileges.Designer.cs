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
        this.Text = "User Edit Privileges";
        ResizeWindowForm();
        CreateLabel();
        CreateLabelRole();
        CreateQLBongDaButton();
        CreateQLThuVienButton();
        CreateQLDeTaiButton();
        CreateQLNhanVienButton();
        CreateMainLabel();
        CreateBackButton();
    }
    private void ResizeWindowForm(){
        this.MinimumSize= new Size(800,600);
        this.MaximumSize = new Size(1000, 800);
    }

    private void CreateLabel()
    {
        Label title1 = new Label();
        title1.Text = "Edit Privileges";
        title1.Location = new Point(50, 20);
        title1.Size = new Size(850, 60);
        title1.Font = new Font(title1.Font.FontFamily, 18, title1.Font.Style);
        title1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        title1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(title1);
    }
    
    private void CreateLabelRole()
    {
        Label title1 = new Label();
        title1.Text = "Edit Privileges";
        title1.Location = new Point(50, 20);
        title1.Size = new Size(850, 60);
        title1.Font = new Font(title1.Font.FontFamily, 18, title1.Font.Style);
        title1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        title1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(title1);
    }
    
    private void CreateQLBongDaButton()
    {
        Button button = new Button();
        button.Text = "Quản lý bóng đá";
        button.Location = new Point(50, 150);
        button.Size = new Size(200, 60);
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
    private void CreateQLThuVienButton()
    {
        Button button = new Button();
        button.Text = "Quản lý thư viện";
        button.Location = new Point(50, 260);
        button.Size = new Size(200, 60);
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
    private void CreateQLDeTaiButton()
    {
        Button button = new Button();
        button.Text = "Quản lý đề tài";
        button.Location = new Point(50, 370);
        button.Size = new Size(200, 60);
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
    private void CreateQLNhanVienButton()
    {
        Button button = new Button();
        button.Text = "Quản lý Nhân Viên";
        button.Location = new Point(50, 480);
        button.Size = new Size(200, 60);
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

    private void CreateMainLabel()
    {
        Label mainlabel = new Label();
        mainlabel.Location = new Point(300, 150);
        mainlabel.Size = new Size(600, 550);
        mainlabel.Font = new Font(mainlabel.Font.FontFamily, 12, mainlabel.Font.Style);
        mainlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        mainlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        this.Controls.Add(mainlabel);
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
