namespace BJ_projektT3A
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
            Hit = new Button();
            Stand = new Button();
            KartyD = new Label();
            KartyH = new Label();
            SuspendLayout();
            // 
            // Hit
            // 
            Hit.Location = new Point(275, 335);
            Hit.Name = "Hit";
            Hit.Size = new Size(67, 49);
            Hit.TabIndex = 0;
            Hit.Text = "Hit";
            Hit.UseVisualStyleBackColor = true;
            // 
            // Stand
            // 
            Stand.Location = new Point(380, 335);
            Stand.Name = "Stand";
            Stand.Size = new Size(67, 49);
            Stand.TabIndex = 2;
            Stand.Text = "Stand";
            Stand.UseVisualStyleBackColor = true;
            // 
            // KartyD
            // 
            KartyD.AutoSize = true;
            KartyD.Location = new Point(357, 88);
            KartyD.Name = "KartyD";
            KartyD.Size = new Size(13, 15);
            KartyD.TabIndex = 3;
            KartyD.Text = "0";
            // 
            // KartyH
            // 
            KartyH.AutoSize = true;
            KartyH.Location = new Point(357, 205);
            KartyH.Name = "KartyH";
            KartyH.Size = new Size(13, 15);
            KartyH.TabIndex = 4;
            KartyH.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(KartyH);
            Controls.Add(KartyD);
            Controls.Add(Stand);
            Controls.Add(Hit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Hit;
        private Button Stand;
        private Label KartyD;
        private Label KartyH;
    }
}
