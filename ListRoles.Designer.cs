namespace Myfirst;

partial class ListRoles
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
        CreateButtonLeft1();
        CreateButtonLeft2();
        CreateButtonLeft3();
        CreateButtonLeft4();
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
        title1.Text = "LIST OF ROLES";
        title1.Location = new Point(400, 20);
        title1.Size = new Size(500, 60);
        title1.Font = new Font(title1.Font.FontFamily, 18, title1.Font.Style);
        this.Controls.Add(title1);
    }

    private void CreateButtonLeft1()
    {
        Button button=new Button();
        button.Text="Quản lý bóng đá";
        button.Location=new Point(30,120);
        button.Size=new Size(250,60);
        button.Font=new Font(button.Font.FontFamily, 12, button.Font.Style);
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
            button.BackColor=Color.SkyBlue;
            button.Enabled = false; // Disable button đang được chọn
        }
    }
    private void CreateButtonLeft2()
    {
        Button button=new Button();
        button.Text="Quản lý thư viện";
        button.Location=new Point(30,250);
        button.Size=new Size(250,60);
        button.Font=new Font(button.Font.FontFamily, 12, button.Font.Style);
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
            button.BackColor=Color.SkyBlue;
            button.Enabled = false; // Disable button đang được chọn
        }
    }

    private void CreateButtonLeft3()
    {
        Button button=new Button();
        button.Text="Quản lý đề tài";
        button.Location=new Point(30,370);
        button.Size=new Size(250,60);
        button.Font=new Font(button.Font.FontFamily, 12, button.Font.Style);
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
            button.BackColor=Color.SkyBlue;
            button.Enabled = false; // Disable button đang được chọn
        }
    }

    private void CreateButtonLeft4()
    {
        Button button=new Button();
        button.Text="Quản lý nhân viên";
        button.Location=new Point(30,500);
        button.Size=new Size(250,60);
        button.Font=new Font(button.Font.FontFamily, 12, button.Font.Style);
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
            button.BackColor=Color.SkyBlue;
            button.Enabled = false; // Disable button đang được chọn
        }
    }
    private void CreateMainLabel()
    {
        Label mainlabel=new Label();
        mainlabel.Location=new Point(350,120);
        mainlabel.Size=new Size(550,550);
        mainlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        mainlabel.Font = new Font(mainlabel.Font.FontFamily, 12, mainlabel.Font.Style);
        this.Controls.Add(mainlabel);

        int n=5;
        int a=0;
        List<Label>list_username=new List<Label>();
        List<Button>list_priviuser=new List<Button>();
        for (int i=1;i<=n;i++){
            Label userlabel=new Label();
            userlabel.Location=new Point(50,30+a);
            userlabel.Size=new Size(500,60);
            userlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            userlabel.TextAlign = ContentAlignment.MiddleCenter;
            userlabel.Font = new Font(userlabel.Font.FontFamily, 11, userlabel.Font.Style);
            mainlabel.Controls.Add(userlabel);
            

            
            for(int j=0;j<2;j++){
                Label usernamechild=new Label();
                usernamechild.Location=new Point(5,5);
                usernamechild.Size=new Size(100,50);
                usernamechild.Text="Role "+i;
                usernamechild.TextAlign = ContentAlignment.MiddleCenter;
                userlabel.Controls.Add(usernamechild);
                list_username.Add(usernamechild);

                Button userprivichild=new Button();
                userprivichild.Location=new Point(200,5);
                userprivichild.Size=new Size(120,50);
                userprivichild.Text="Udapte";
                userlabel.Controls.Add(userprivichild);
                list_priviuser.Add(userprivichild);
                
                void loginbutton_Click(object sender, EventArgs e)
                {
                    //userprivichild.Text=""+list_username[i].Text;
                }
                userprivichild.Click += new EventHandler(loginbutton_Click);
                

                Button userdeletechild=new Button();
                userdeletechild.Location=new Point(350,5);
                userdeletechild.Size=new Size(120,50);
                userdeletechild.Text="Delete";
                userlabel.Controls.Add(userdeletechild);
            }
            a+=90;
            if(i%5==0){
                a=0;
            }
        }
        
        Button prebutton=new Button();
        prebutton.Location=new Point(50,480);
        prebutton.Size=new Size(120,50);
        prebutton.Text="Pre";
        mainlabel.Controls.Add(prebutton);

        Button nextbutton=new Button();
        nextbutton.Location=new Point(200,480);
        nextbutton.Size=new Size(120,50);
        nextbutton.Text="Next";
        mainlabel.Controls.Add(nextbutton);
    


        Button addbutton=new Button();
        addbutton.Location=new Point(420,480);
        addbutton.Size=new Size(120,50);
        addbutton.Text="Add";
        mainlabel.Controls.Add(addbutton);

        

    }

    private void CreateBackButton(){
        Button backbutton = new Button();
        backbutton.Location=new Point(70,600);
        backbutton.Size=new Size(100,60);
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