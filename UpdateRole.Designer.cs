namespace Myfirst;

partial class UpdateRole
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
        this.Text = "Update Role";
        ResizeWindowForm();
        CreateLabel();
        CreateMainLabel();
        CreateBackButton();
        CreateOkButton();
    }

    private void ResizeWindowForm(){
        this.MinimumSize= new Size(800,600);
        this.MaximumSize = new Size(1000, 800);
    }

    private void CreateLabel()
    {
        
        Label title1 = new Label();
        title1.Text = "UPDATE ROLE";
        title1.Location = new Point(350, 20);
        title1.Size = new Size(500, 60);
        title1.Font = new Font(title1.Font.FontFamily, 18, title1.Font.Style);
        this.Controls.Add(title1);
    }

    private void CreateMainLabel()
    {
        Label mainlabel=new Label();
        mainlabel.Location=new Point(150,120);
        mainlabel.Size=new Size(700,550);
        mainlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        mainlabel.Font = new Font(mainlabel.Font.FontFamily, 12, mainlabel.Font.Style);
        this.Controls.Add(mainlabel);

        Label title=new Label();
        title.Location=new Point(50,20);
        title.Size=new Size(600,60);
        title.Text="Role ???";
        title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        title.Font = new Font(mainlabel.Font.FontFamily, 12, mainlabel.Font.Style);
        mainlabel.Controls.Add(title);

        

    }

    private void CreateBackButton(){
        Button backbutton = new Button();
        backbutton.Location=new Point(20,610);
        backbutton.Size=new Size(100,60);
        backbutton.Text="Back";
        this.Controls.Add(backbutton);

        backbutton.Click += new EventHandler(backbutton_Click);
        void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    private void CreateOkButton(){
        Button backbutton = new Button();
        backbutton.Location=new Point(870,610);
        backbutton.Size=new Size(100,60);
        backbutton.Text="OK";
        this.Controls.Add(backbutton);

        backbutton.Click += new EventHandler(backbutton_Click);
        void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


    #endregion
}