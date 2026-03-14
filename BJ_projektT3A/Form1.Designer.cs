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
            Start = new Button();
            Stop = new Button();
            Sazka = new Label();
            Sazkaplus10 = new Button();
            Sazkaminus10 = new Button();
            StavPenez = new Label();
            Double = new Button();
            SuspendLayout();
            // 
            // Hit
            // 
            Hit.Location = new Point(277, 207);
            Hit.Name = "Hit";
            Hit.Size = new Size(67, 49);
            Hit.TabIndex = 0;
            Hit.Text = "Hit";
            Hit.UseVisualStyleBackColor = true;
            Hit.Click += Hit_Click;
            // 
            // Stand
            // 
            Stand.Location = new Point(400, 207);
            Stand.Name = "Stand";
            Stand.Size = new Size(67, 49);
            Stand.TabIndex = 2;
            Stand.Text = "Stand";
            Stand.UseVisualStyleBackColor = true;
            Stand.Click += Stand_Click;
            // 
            // KartyD
            // 
            KartyD.AutoSize = true;
            KartyD.Location = new Point(357, 40);
            KartyD.Name = "KartyD";
            KartyD.Size = new Size(13, 15);
            KartyD.TabIndex = 3;
            KartyD.Text = "0";
            // 
            // KartyH
            // 
            KartyH.AutoSize = true;
            KartyH.Location = new Point(357, 116);
            KartyH.Name = "KartyH";
            KartyH.Size = new Size(13, 15);
            KartyH.TabIndex = 4;
            KartyH.Text = "0";
            // 
            // Start
            // 
            Start.Location = new Point(21, 372);
            Start.Name = "Start";
            Start.Size = new Size(67, 49);
            Start.TabIndex = 5;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Stop
            // 
            Stop.Location = new Point(704, 372);
            Stop.Name = "Stop";
            Stop.Size = new Size(67, 49);
            Stop.TabIndex = 6;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // Sazka
            // 
            Sazka.Location = new Point(357, 166);
            Sazka.Name = "Sazka";
            Sazka.Size = new Size(35, 23);
            Sazka.TabIndex = 12;
            Sazka.Text = "0";
            // 
            // Sazkaplus10
            // 
            Sazkaplus10.Location = new Point(277, 372);
            Sazkaplus10.Name = "Sazkaplus10";
            Sazkaplus10.Size = new Size(67, 49);
            Sazkaplus10.TabIndex = 8;
            Sazkaplus10.Text = "+10";
            Sazkaplus10.UseVisualStyleBackColor = true;
            Sazkaplus10.Click += Sazkaplus10_Click;
            // 
            // Sazkaminus10
            // 
            Sazkaminus10.Location = new Point(400, 372);
            Sazkaminus10.Name = "Sazkaminus10";
            Sazkaminus10.Size = new Size(67, 49);
            Sazkaminus10.TabIndex = 9;
            Sazkaminus10.Text = "-10";
            Sazkaminus10.UseVisualStyleBackColor = true;
            Sazkaminus10.Click += Sazkaminus10_Click;
            // 
            // StavPenez
            // 
            StavPenez.AutoSize = true;
            StavPenez.Location = new Point(12, 9);
            StavPenez.Name = "StavPenez";
            StavPenez.Size = new Size(31, 15);
            StavPenez.TabIndex = 10;
            StavPenez.Text = "1000";
            // 
            // Double
            // 
            Double.Location = new Point(153, 218);
            Double.Name = "Double";
            Double.Size = new Size(57, 38);
            Double.TabIndex = 11;
            Double.Text = "Double";
            Double.UseVisualStyleBackColor = true;
            Double.Click += Double_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Double);
            Controls.Add(StavPenez);
            Controls.Add(Sazkaminus10);
            Controls.Add(Sazkaplus10);
            Controls.Add(Sazka);
            Controls.Add(Stop);
            Controls.Add(Start);
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
        private Button Start;
        private Button Stop;
        private Label Sazka;
        private Button Sazkaplus10;
        private Button Sazkaminus10;
        private Label StavPenez;
        private Button Double;
    }
}
