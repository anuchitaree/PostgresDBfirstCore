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
            Btn_reset = new Button();
            SuspendLayout();
            // 
            // Btn_reset
            // 
            Btn_reset.Location = new Point(68, 92);
            Btn_reset.Name = "Btn_reset";
            Btn_reset.Size = new Size(104, 50);
            Btn_reset.TabIndex = 0;
            Btn_reset.Text = "Reset";
            Btn_reset.UseVisualStyleBackColor = true;
            Btn_reset.Click += Btn_reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_reset);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_reset;
    }
}
