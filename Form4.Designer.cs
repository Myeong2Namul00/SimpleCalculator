namespace SimpleCalculator
{
    partial class Form4
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
            btnTan = new Button();
            btnSin = new Button();
            btnCos = new Button();
            SuspendLayout();
            // 
            // btnTan
            // 
            btnTan.BackColor = Color.White;
            btnTan.FlatStyle = FlatStyle.Flat;
            btnTan.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnTan.Location = new Point(45, 105);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(111, 69);
            btnTan.TabIndex = 18;
            btnTan.Text = "tan";
            btnTan.UseVisualStyleBackColor = false;
            btnTan.Click += this.btnTan_Click;
            // 
            // btnSin
            // 
            btnSin.BackColor = Color.White;
            btnSin.FlatStyle = FlatStyle.Flat;
            btnSin.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSin.Location = new Point(45, 19);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(111, 69);
            btnSin.TabIndex = 16;
            btnSin.Text = "sin";
            btnSin.UseVisualStyleBackColor = false;
            btnSin.Click += this.btnSin_Click;
            // 
            // btnCos
            // 
            btnCos.BackColor = Color.White;
            btnCos.FlatStyle = FlatStyle.Flat;
            btnCos.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCos.Location = new Point(171, 19);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(111, 69);
            btnCos.TabIndex = 15;
            btnCos.Text = "cos";
            btnCos.UseVisualStyleBackColor = false;
            btnCos.Click += btnCos_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(329, 193);
            Controls.Add(btnTan);
            Controls.Add(btnSin);
            Controls.Add(btnCos);
            Name = "Form4";
            Text = "Trianglular";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTan;
        private Button btnSin;
        private Button btnCos;
    }
}