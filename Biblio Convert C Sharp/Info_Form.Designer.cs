
namespace Biblio_Convert_C_Sharp
{
    partial class Info_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_Form));
            this.panel_Text = new System.Windows.Forms.Panel();
            this.label_Info = new System.Windows.Forms.Label();
            this.panel_Button = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.panel_Text.SuspendLayout();
            this.panel_Button.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Text
            // 
            this.panel_Text.Controls.Add(this.label_Info);
            this.panel_Text.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Text.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.panel_Text.Location = new System.Drawing.Point(0, 0);
            this.panel_Text.MaximumSize = new System.Drawing.Size(563, 255);
            this.panel_Text.MinimumSize = new System.Drawing.Size(563, 255);
            this.panel_Text.Name = "panel_Text";
            this.panel_Text.Size = new System.Drawing.Size(563, 255);
            this.panel_Text.TabIndex = 0;
            // 
            // label_Info
            // 
            this.label_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.label_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Info.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Info.Location = new System.Drawing.Point(0, 0);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(563, 255);
            this.label_Info.TabIndex = 2;
            this.label_Info.Text = resources.GetString("label_Info.Text");
            this.label_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Button
            // 
            this.panel_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.panel_Button.Controls.Add(this.button_Exit);
            this.panel_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Button.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.panel_Button.Location = new System.Drawing.Point(0, 255);
            this.panel_Button.MaximumSize = new System.Drawing.Size(563, 98);
            this.panel_Button.MinimumSize = new System.Drawing.Size(563, 98);
            this.panel_Button.Name = "panel_Button";
            this.panel_Button.Padding = new System.Windows.Forms.Padding(190, 24, 190, 24);
            this.panel_Button.Size = new System.Drawing.Size(563, 98);
            this.panel_Button.TabIndex = 1;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(125)))), ((int)(((byte)(227)))));
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Exit.ForeColor = System.Drawing.Color.White;
            this.button_Exit.Location = new System.Drawing.Point(190, 24);
            this.button_Exit.MaximumSize = new System.Drawing.Size(183, 50);
            this.button_Exit.MinimumSize = new System.Drawing.Size(183, 50);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(183, 50);
            this.button_Exit.TabIndex = 3;
            this.button_Exit.Text = "Закрити";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Info_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(563, 353);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Button);
            this.Controls.Add(this.panel_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(565, 355);
            this.MinimumSize = new System.Drawing.Size(565, 355);
            this.Name = "Info_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_Text.ResumeLayout(false);
            this.panel_Button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Text;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Panel panel_Button;
        private System.Windows.Forms.Button button_Exit;
    }
}