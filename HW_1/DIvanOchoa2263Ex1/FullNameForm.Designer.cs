namespace DIvanOchoa2263Ex1;

partial class FullNameForm
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
    private void InitializeComponent()
    {
            this.btnGiveResponse = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstNameBox = new System.Windows.Forms.TextBox();
            this.txtLastNameBox = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiveResponse
            // 
            this.btnGiveResponse.Location = new System.Drawing.Point(161, 246);
            this.btnGiveResponse.Name = "btnGiveResponse";
            this.btnGiveResponse.Size = new System.Drawing.Size(93, 59);
            this.btnGiveResponse.TabIndex = 0;
            this.btnGiveResponse.Text = "Say Hello!";
            this.btnGiveResponse.UseVisualStyleBackColor = true;
            this.btnGiveResponse.Click += new System.EventHandler(this.btnGiveResponse_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(76, 90);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 20);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstNameBox
            // 
            this.txtFirstNameBox.Location = new System.Drawing.Point(161, 90);
            this.txtFirstNameBox.Name = "txtFirstNameBox";
            this.txtFirstNameBox.Size = new System.Drawing.Size(158, 27);
            this.txtFirstNameBox.TabIndex = 2;
            // 
            // txtLastNameBox
            // 
            this.txtLastNameBox.Location = new System.Drawing.Point(161, 157);
            this.txtLastNameBox.Name = "txtLastNameBox";
            this.txtLastNameBox.Size = new System.Drawing.Size(158, 27);
            this.txtLastNameBox.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(76, 157);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 20);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // FullNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 361);
            this.Controls.Add(this.txtLastNameBox);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstNameBox);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnGiveResponse);
            this.Name = "FullNameForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button btnGiveResponse;
    private Label lblFirstName;
    private TextBox txtFirstNameBox;
    private TextBox txtLastNameBox;
    private Label lblLastName;
}
