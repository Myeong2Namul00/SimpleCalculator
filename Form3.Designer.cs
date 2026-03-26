namespace SimpleCalculator
{
    partial class Form3
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
            btnAbs = new Button();
            btnCloseParen = new Button();
            btnPi = new Button();
            btnOpenParen = new Button();
            btnExp = new Button();
            btnLn = new Button();
            btnMod = new Button();
            btnLog = new Button();
            btnTrian = new Button();
            SuspendLayout();
            // 
            // btnAbs
            // 
            btnAbs.BackColor = Color.White;
            btnAbs.FlatStyle = FlatStyle.Flat;
            btnAbs.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnAbs.Location = new Point(334, 16);
            btnAbs.Name = "btnAbs";
            btnAbs.Size = new Size(111, 69);
            btnAbs.TabIndex = 10;
            btnAbs.Text = "|x|";
            btnAbs.UseVisualStyleBackColor = false;
            // 
            // btnCloseParen
            // 
            btnCloseParen.BackColor = Color.White;
            btnCloseParen.FlatStyle = FlatStyle.Flat;
            btnCloseParen.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCloseParen.Location = new Point(207, 16);
            btnCloseParen.Name = "btnCloseParen";
            btnCloseParen.Size = new Size(111, 69);
            btnCloseParen.TabIndex = 9;
            btnCloseParen.Text = ")";
            btnCloseParen.UseVisualStyleBackColor = false;
            // 
            // btnPi
            // 
            btnPi.BackColor = Color.White;
            btnPi.FlatStyle = FlatStyle.Flat;
            btnPi.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnPi.Location = new Point(460, 16);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(111, 69);
            btnPi.TabIndex = 8;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = false;
            // 
            // btnOpenParen
            // 
            btnOpenParen.BackColor = Color.White;
            btnOpenParen.FlatStyle = FlatStyle.Flat;
            btnOpenParen.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOpenParen.Location = new Point(84, 16);
            btnOpenParen.Name = "btnOpenParen";
            btnOpenParen.Size = new Size(111, 69);
            btnOpenParen.TabIndex = 7;
            btnOpenParen.Text = "(";
            btnOpenParen.UseVisualStyleBackColor = false;
            // 
            // btnExp
            // 
            btnExp.BackColor = Color.White;
            btnExp.FlatStyle = FlatStyle.Flat;
            btnExp.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnExp.Location = new Point(334, 102);
            btnExp.Name = "btnExp";
            btnExp.Size = new Size(111, 69);
            btnExp.TabIndex = 14;
            btnExp.Text = "exp";
            btnExp.UseVisualStyleBackColor = false;
            // 
            // btnLn
            // 
            btnLn.BackColor = Color.White;
            btnLn.FlatStyle = FlatStyle.Flat;
            btnLn.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLn.Location = new Point(207, 102);
            btnLn.Name = "btnLn";
            btnLn.Size = new Size(111, 69);
            btnLn.TabIndex = 13;
            btnLn.Text = "ln";
            btnLn.UseVisualStyleBackColor = false;
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.White;
            btnMod.FlatStyle = FlatStyle.Flat;
            btnMod.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnMod.Location = new Point(460, 102);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(111, 69);
            btnMod.TabIndex = 12;
            btnMod.Text = "mod";
            btnMod.UseVisualStyleBackColor = false;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.White;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLog.Location = new Point(84, 102);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(111, 69);
            btnLog.TabIndex = 11;
            btnLog.Text = "log";
            btnLog.UseVisualStyleBackColor = false;
            // 
            // btnTrian
            // 
            btnTrian.BackColor = Color.White;
            btnTrian.FlatStyle = FlatStyle.Flat;
            btnTrian.Font = new Font("나눔고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnTrian.Location = new Point(599, 16);
            btnTrian.Name = "btnTrian";
            btnTrian.Size = new Size(34, 155);
            btnTrian.TabIndex = 15;
            btnTrian.Text = "▶";
            btnTrian.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(655, 193);
            Controls.Add(btnTrian);
            Controls.Add(btnExp);
            Controls.Add(btnLn);
            Controls.Add(btnMod);
            Controls.Add(btnLog);
            Controls.Add(btnAbs);
            Controls.Add(btnCloseParen);
            Controls.Add(btnPi);
            Controls.Add(btnOpenParen);
            Name = "Form3";
            Text = "Expanded";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbs;
        private Button btnCloseParen;
        private Button btnPi;
        private Button btnOpenParen;
        private Button btnExp;
        private Button btnLn;
        private Button btnMod;
        private Button btnLog;
        private Button btnTrian;
    }
}