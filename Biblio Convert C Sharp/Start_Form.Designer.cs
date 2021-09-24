
namespace Biblio_Convert_C_Sharp
{
    partial class Start_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Control_Box = new System.Windows.Forms.Panel();
            this.button_Draw = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.panel_Form_Name = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Button = new System.Windows.Forms.Panel();
            this.button_Start = new System.Windows.Forms.Button();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.label_Info = new System.Windows.Forms.Label();
            this.panel_Control_Box.SuspendLayout();
            this.panel_Form_Name.SuspendLayout();
            this.panel_Button.SuspendLayout();
            this.panel_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Control_Box
            // 
            this.panel_Control_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.panel_Control_Box.Controls.Add(this.button_Draw);
            this.panel_Control_Box.Controls.Add(this.button_Exit);
            this.panel_Control_Box.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Control_Box.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.panel_Control_Box.Location = new System.Drawing.Point(0, 0);
            this.panel_Control_Box.MaximumSize = new System.Drawing.Size(420, 40);
            this.panel_Control_Box.MinimumSize = new System.Drawing.Size(420, 40);
            this.panel_Control_Box.Name = "panel_Control_Box";
            this.panel_Control_Box.Size = new System.Drawing.Size(420, 40);
            this.panel_Control_Box.TabIndex = 0;
            // 
            // button_Draw
            // 
            this.button_Draw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(125)))), ((int)(((byte)(227)))));
            this.button_Draw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Draw.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Draw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Draw.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Draw.ForeColor = System.Drawing.Color.White;
            this.button_Draw.Location = new System.Drawing.Point(321, 0);
            this.button_Draw.Margin = new System.Windows.Forms.Padding(0);
            this.button_Draw.Name = "button_Draw";
            this.button_Draw.Size = new System.Drawing.Size(46, 40);
            this.button_Draw.TabIndex = 2;
            this.button_Draw.Text = "-";
            this.button_Draw.UseVisualStyleBackColor = false;
            this.button_Draw.Click += new System.EventHandler(this.button_Draw_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.Red;
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Exit.ForeColor = System.Drawing.Color.White;
            this.button_Exit.Location = new System.Drawing.Point(367, 0);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(53, 40);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "X";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // panel_Form_Name
            // 
            this.panel_Form_Name.Controls.Add(this.label1);
            this.panel_Form_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Form_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.panel_Form_Name.Location = new System.Drawing.Point(0, 40);
            this.panel_Form_Name.MaximumSize = new System.Drawing.Size(420, 100);
            this.panel_Form_Name.MinimumSize = new System.Drawing.Size(420, 100);
            this.panel_Form_Name.Name = "panel_Form_Name";
            this.panel_Form_Name.Size = new System.Drawing.Size(420, 100);
            this.panel_Form_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "Конвертування файлів";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Button
            // 
            this.panel_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.panel_Button.Controls.Add(this.button_Start);
            this.panel_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.panel_Button.Location = new System.Drawing.Point(0, 140);
            this.panel_Button.MaximumSize = new System.Drawing.Size(420, 90);
            this.panel_Button.MinimumSize = new System.Drawing.Size(420, 90);
            this.panel_Button.Name = "panel_Button";
            this.panel_Button.Padding = new System.Windows.Forms.Padding(100, 20, 100, 20);
            this.panel_Button.Size = new System.Drawing.Size(420, 90);
            this.panel_Button.TabIndex = 2;
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(125)))), ((int)(((byte)(227)))));
            this.button_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Start.ForeColor = System.Drawing.Color.White;
            this.button_Start.Location = new System.Drawing.Point(100, 20);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(220, 50);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "Конвертувати";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // panel_Info
            // 
            this.panel_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.panel_Info.Controls.Add(this.label_Info);
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Info.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.panel_Info.Location = new System.Drawing.Point(0, 230);
            this.panel_Info.MaximumSize = new System.Drawing.Size(420, 40);
            this.panel_Info.MinimumSize = new System.Drawing.Size(420, 40);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.panel_Info.Size = new System.Drawing.Size(420, 40);
            this.panel_Info.TabIndex = 3;
            // 
            // label_Info
            // 
            this.label_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.label_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Info.Location = new System.Drawing.Point(100, 17);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(220, 23);
            this.label_Info.TabIndex = 1;
            this.label_Info.Text = "Про додаток";
            this.label_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Info.Click += new System.EventHandler(this.label_Info_Click);
            // 
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(420, 270);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.panel_Button);
            this.Controls.Add(this.panel_Form_Name);
            this.Controls.Add(this.panel_Control_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(426, 276);
            this.MinimumSize = new System.Drawing.Size(426, 276);
            this.Name = "Start_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_Control_Box.ResumeLayout(false);
            this.panel_Form_Name.ResumeLayout(false);
            this.panel_Button.ResumeLayout(false);
            this.panel_Info.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Control_Box;
        private System.Windows.Forms.Button button_Draw;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Panel panel_Form_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Button;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Label label_Info;
    }
}