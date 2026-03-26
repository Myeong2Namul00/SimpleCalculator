namespace SimpleCalculator
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
            txtResult = new TextBox();
            txtInput = new TextBox();
            lblTitle = new Label();
            btnPer = new Button();
            btnBS = new Button();
            btnCE = new Button();
            btnC = new Button();
            btnLoot = new Button();
            btnSq = new Button();
            btnDiv = new Button();
            btnReci = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btnMul = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btnSub = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btnAdd = new Button();
            btn7 = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnEqual = new Button();
            btnSign = new Button();
            btnHistory = new Button();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.BorderStyle = BorderStyle.FixedSingle;
            txtResult.Font = new Font("한컴 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtResult.Location = new Point(84, 111);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(487, 53);
            txtResult.TabIndex = 0;
            // 
            // txtInput
            // 
            txtInput.BorderStyle = BorderStyle.FixedSingle;
            txtInput.Font = new Font("한컴 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtInput.Location = new Point(84, 182);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(487, 53);
            txtInput.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("한컴 말랑말랑 Bold", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.Location = new Point(114, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(431, 62);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Simple Calculator";
            // 
            // btnPer
            // 
            btnPer.BackColor = Color.White;
            btnPer.FlatStyle = FlatStyle.Flat;
            btnPer.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnPer.Location = new Point(84, 256);
            btnPer.Name = "btnPer";
            btnPer.Size = new Size(111, 69);
            btnPer.TabIndex = 3;
            btnPer.Text = "%";
            btnPer.UseVisualStyleBackColor = false;
            // 
            // btnBS
            // 
            btnBS.BackColor = Color.White;
            btnBS.FlatStyle = FlatStyle.Flat;
            btnBS.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnBS.Location = new Point(460, 256);
            btnBS.Name = "btnBS";
            btnBS.Size = new Size(111, 69);
            btnBS.TabIndex = 4;
            btnBS.Text = "◀";
            btnBS.UseVisualStyleBackColor = false;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.White;
            btnCE.FlatStyle = FlatStyle.Flat;
            btnCE.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCE.Location = new Point(207, 256);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(111, 69);
            btnCE.TabIndex = 5;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            btnC.BackColor = Color.White;
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnC.Location = new Point(334, 256);
            btnC.Name = "btnC";
            btnC.Size = new Size(111, 69);
            btnC.TabIndex = 6;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            // 
            // btnLoot
            // 
            btnLoot.BackColor = Color.White;
            btnLoot.FlatStyle = FlatStyle.Flat;
            btnLoot.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLoot.Location = new Point(334, 341);
            btnLoot.Name = "btnLoot";
            btnLoot.Size = new Size(111, 69);
            btnLoot.TabIndex = 10;
            btnLoot.Text = "2√x";
            btnLoot.UseVisualStyleBackColor = false;
            // 
            // btnSq
            // 
            btnSq.BackColor = Color.White;
            btnSq.FlatStyle = FlatStyle.Flat;
            btnSq.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSq.Location = new Point(207, 341);
            btnSq.Name = "btnSq";
            btnSq.Size = new Size(111, 69);
            btnSq.TabIndex = 9;
            btnSq.Text = "x²";
            btnSq.UseVisualStyleBackColor = false;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.White;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDiv.Location = new Point(460, 341);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(111, 69);
            btnDiv.TabIndex = 8;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = false;
            // 
            // btnReci
            // 
            btnReci.BackColor = Color.White;
            btnReci.FlatStyle = FlatStyle.Flat;
            btnReci.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnReci.Location = new Point(84, 341);
            btnReci.Name = "btnReci";
            btnReci.Size = new Size(111, 69);
            btnReci.TabIndex = 7;
            btnReci.Text = "1/x";
            btnReci.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn3.Location = new Point(334, 426);
            btn3.Name = "btn3";
            btn3.Size = new Size(111, 69);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.White;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn2.Location = new Point(207, 426);
            btn2.Name = "btn2";
            btn2.Size = new Size(111, 69);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btnMul
            // 
            btnMul.BackColor = Color.White;
            btnMul.FlatStyle = FlatStyle.Flat;
            btnMul.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnMul.Location = new Point(460, 426);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(111, 69);
            btnMul.TabIndex = 12;
            btnMul.Text = "×";
            btnMul.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn1.Location = new Point(84, 426);
            btn1.Name = "btn1";
            btn1.Size = new Size(111, 69);
            btn1.TabIndex = 11;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.White;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn6.Location = new Point(334, 510);
            btn6.Name = "btn6";
            btn6.Size = new Size(111, 69);
            btn6.TabIndex = 18;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.White;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn5.Location = new Point(207, 510);
            btn5.Name = "btn5";
            btn5.Size = new Size(111, 69);
            btn5.TabIndex = 17;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.White;
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSub.Location = new Point(460, 510);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(111, 69);
            btnSub.TabIndex = 16;
            btnSub.Text = "－";
            btnSub.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.White;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn4.Location = new Point(84, 510);
            btn4.Name = "btn4";
            btn4.Size = new Size(111, 69);
            btn4.TabIndex = 15;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.White;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn9.Location = new Point(334, 595);
            btn9.Name = "btn9";
            btn9.Size = new Size(111, 69);
            btn9.TabIndex = 22;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.White;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn8.Location = new Point(207, 595);
            btn8.Name = "btn8";
            btn8.Size = new Size(111, 69);
            btn8.TabIndex = 21;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnAdd.Location = new Point(460, 595);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 69);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "＋";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.White;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn7.Location = new Point(84, 595);
            btn7.Name = "btn7";
            btn7.Size = new Size(111, 69);
            btn7.TabIndex = 19;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.White;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDot.Location = new Point(334, 681);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(111, 69);
            btnDot.TabIndex = 26;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.White;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn0.Location = new Point(207, 681);
            btn0.Name = "btn0";
            btn0.Size = new Size(111, 69);
            btn0.TabIndex = 25;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(192, 192, 255);
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnEqual.Location = new Point(460, 681);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(111, 69);
            btnEqual.TabIndex = 24;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            // 
            // btnSign
            // 
            btnSign.BackColor = Color.White;
            btnSign.FlatStyle = FlatStyle.Flat;
            btnSign.Font = new Font("나눔고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSign.Location = new Point(84, 681);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(111, 69);
            btnSign.TabIndex = 23;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("한컴 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnHistory.Location = new Point(565, 12);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(78, 40);
            btnHistory.TabIndex = 27;
            btnHistory.Text = "history";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(655, 809);
            Controls.Add(btnHistory);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnEqual);
            Controls.Add(btnSign);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btnAdd);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btnSub);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btnMul);
            Controls.Add(btn1);
            Controls.Add(btnLoot);
            Controls.Add(btnSq);
            Controls.Add(btnDiv);
            Controls.Add(btnReci);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnBS);
            Controls.Add(btnPer);
            Controls.Add(lblTitle);
            Controls.Add(txtInput);
            Controls.Add(txtResult);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private TextBox txtInput;
        private Label lblTitle;
        private Button btnPer;
        private Button btnBS;
        private Button btnCE;
        private Button btnC;
        private Button btnLoot;
        private Button btnSq;
        private Button btnDiv;
        private Button btnReci;
        private Button btn3;
        private Button btn2;
        private Button btnMul;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button btnSub;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btnAdd;
        private Button btn7;
        private Button btnDot;
        private Button btn0;
        private Button btnEqual;
        private Button btnSign;
        private Button btnHistory;
    }
}
