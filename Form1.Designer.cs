namespace PostgresDBfirstCore
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Btn_reset = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Btn_reset
            // 
            Btn_reset.Dock = DockStyle.Bottom;
            Btn_reset.ForeColor = Color.Brown;
            Btn_reset.Location = new Point(0, 240);
            Btn_reset.Name = "Btn_reset";
            Btn_reset.Size = new Size(357, 33);
            Btn_reset.TabIndex = 0;
            Btn_reset.Text = "Reset all";
            Btn_reset.UseVisualStyleBackColor = true;
            Btn_reset.Click += Btn_reset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(331, 225);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 273);
            Controls.Add(label1);
            Controls.Add(Btn_reset);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Utility dekidaka app.  by Pik  2025-02-25 ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_reset;
        private Label label1;
    }
}
