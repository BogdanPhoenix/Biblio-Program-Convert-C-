
namespace Biblio_Convert_C_Sharp
{
    partial class Check_Exit_Form
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
            this.panel_Label = new System.Windows.Forms.Panel();
            this.label_Text = new System.Windows.Forms.Label();
            this.panel_Button_Yes = new System.Windows.Forms.Panel();
            this.button_Yes = new System.Windows.Forms.Button();
            this.panel_Button_No = new System.Windows.Forms.Panel();
            this.button_No = new System.Windows.Forms.Button();
            this.panel_Label.SuspendLayout();
            this.panel_Button_Yes.SuspendLayout();
            this.panel_Button_No.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Label
            // 
            this.panel_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.panel_Label.Controls.Add(this.label_Text);
            this.panel_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.panel_Label.Location = new System.Drawing.Point(5, 5);
            this.panel_Label.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Label.Name = "panel_Label";
            this.panel_Label.Size = new System.Drawing.Size(354, 164);
            this.panel_Label.TabIndex = 0;
            // 
            // label_Text
            // 
            this.label_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Text.Location = new System.Drawing.Point(0, 0);
            this.label_Text.Name = "label_Text";
            this.label_Text.Size = new System.Drawing.Size(354, 164);
            this.label_Text.TabIndex = 0;
            this.label_Text.Text = "Ви хочете завершити\r\nроботу програми?\r\nДані не будуть конвертовані\r\n";
            this.label_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Button_Yes
            // 
            this.panel_Button_Yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.panel_Button_Yes.Controls.Add(this.button_Yes);
            this.panel_Button_Yes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Button_Yes.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.panel_Button_Yes.Location = new System.Drawing.Point(5, 169);
            this.panel_Button_Yes.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Button_Yes.Name = "panel_Button_Yes";
            this.panel_Button_Yes.Padding = new System.Windows.Forms.Padding(49, 23, 0, 0);
            this.panel_Button_Yes.Size = new System.Drawing.Size(177, 85);
            this.panel_Button_Yes.TabIndex = 1;
            // 
            // button_Yes
            // 
            this.button_Yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(125)))), ((int)(((byte)(227)))));
            this.button_Yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Yes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Yes.ForeColor = System.Drawing.Color.White;
            this.button_Yes.Location = new System.Drawing.Point(49, 23);
            this.button_Yes.MaximumSize = new System.Drawing.Size(80, 40);
            this.button_Yes.MinimumSize = new System.Drawing.Size(80, 40);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(80, 40);
            this.button_Yes.TabIndex = 1;
            this.button_Yes.Text = "Так";
            this.button_Yes.UseVisualStyleBackColor = false;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // panel_Button_No
            // 
            this.panel_Button_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.panel_Button_No.Controls.Add(this.button_No);
            this.panel_Button_No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Button_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.panel_Button_No.Location = new System.Drawing.Point(182, 169);
            this.panel_Button_No.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Button_No.Name = "panel_Button_No";
            this.panel_Button_No.Padding = new System.Windows.Forms.Padding(49, 23, 0, 0);
            this.panel_Button_No.Size = new System.Drawing.Size(177, 85);
            this.panel_Button_No.TabIndex = 2;
            // 
            // button_No
            // 
            this.button_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(125)))), ((int)(((byte)(227)))));
            this.button_No.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_No.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_No.ForeColor = System.Drawing.Color.White;
            this.button_No.Location = new System.Drawing.Point(49, 23);
            this.button_No.MaximumSize = new System.Drawing.Size(80, 40);
            this.button_No.MinimumSize = new System.Drawing.Size(80, 40);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(80, 40);
            this.button_No.TabIndex = 1;
            this.button_No.Text = "Ні";
            this.button_No.UseVisualStyleBackColor = false;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // Check_Exit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(364, 259);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Button_No);
            this.Controls.Add(this.panel_Button_Yes);
            this.Controls.Add(this.panel_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(370, 265);
            this.MinimumSize = new System.Drawing.Size(370, 265);
            this.Name = "Check_Exit_Form";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_Label.ResumeLayout(false);
            this.panel_Button_Yes.ResumeLayout(false);
            this.panel_Button_No.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Label;
        private System.Windows.Forms.Label label_Text;
        private System.Windows.Forms.Panel panel_Button_Yes;
        private System.Windows.Forms.Button button_Yes;
        private System.Windows.Forms.Panel panel_Button_No;
        private System.Windows.Forms.Button button_No;
    }
}