namespace QuizApp
{
    partial class GuizGUI
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
            if (disposing && (components != null)) {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClaimDifficulty = new System.Windows.Forms.Label();
            this.cmbClaimDifficulty = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.numCntClaims = new System.Windows.Forms.NumericUpDown();
            this.lblCntClaims = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnTrue = new System.Windows.Forms.Button();
            this.lblClaim = new System.Windows.Forms.Label();
            this.txbClaim = new System.Windows.Forms.TextBox();
            this.lblNumberOfPoints = new System.Windows.Forms.Label();
            this.lblNumberOfClaims = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblCntClaimsToAnswer = new System.Windows.Forms.Label();
            this.lblQuizGame = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCntClaims)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblClaimDifficulty);
            this.panel1.Controls.Add(this.cmbClaimDifficulty);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.numCntClaims);
            this.panel1.Controls.Add(this.lblCntClaims);
            this.panel1.Location = new System.Drawing.Point(12, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 390);
            this.panel1.TabIndex = 0;
            // 
            // lblClaimDifficulty
            // 
            this.lblClaimDifficulty.AutoSize = true;
            this.lblClaimDifficulty.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClaimDifficulty.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblClaimDifficulty.Location = new System.Drawing.Point(54, 77);
            this.lblClaimDifficulty.Name = "lblClaimDifficulty";
            this.lblClaimDifficulty.Size = new System.Drawing.Size(284, 23);
            this.lblClaimDifficulty.TabIndex = 4;
            this.lblClaimDifficulty.Text = "Choose difficulty level of claims:";
            // 
            // cmbClaimDifficulty
            // 
            this.cmbClaimDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClaimDifficulty.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbClaimDifficulty.ForeColor = System.Drawing.Color.ForestGreen;
            this.cmbClaimDifficulty.FormattingEnabled = true;
            this.cmbClaimDifficulty.Items.AddRange(new object[] {
            "easy",
            "medium",
            "hard"});
            this.cmbClaimDifficulty.Location = new System.Drawing.Point(407, 74);
            this.cmbClaimDifficulty.MaxDropDownItems = 3;
            this.cmbClaimDifficulty.Name = "cmbClaimDifficulty";
            this.cmbClaimDifficulty.Size = new System.Drawing.Size(111, 31);
            this.cmbClaimDifficulty.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStart.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.Lavender;
            this.btnStart.Location = new System.Drawing.Point(197, 188);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(5);
            this.btnStart.Size = new System.Drawing.Size(186, 54);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // numCntClaims
            // 
            this.numCntClaims.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numCntClaims.ForeColor = System.Drawing.Color.ForestGreen;
            this.numCntClaims.Location = new System.Drawing.Point(467, 25);
            this.numCntClaims.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCntClaims.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numCntClaims.Name = "numCntClaims";
            this.numCntClaims.Size = new System.Drawing.Size(51, 31);
            this.numCntClaims.TabIndex = 1;
            this.numCntClaims.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCntClaims.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblCntClaims
            // 
            this.lblCntClaims.AutoSize = true;
            this.lblCntClaims.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCntClaims.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCntClaims.Location = new System.Drawing.Point(54, 26);
            this.lblCntClaims.Name = "lblCntClaims";
            this.lblCntClaims.Size = new System.Drawing.Size(398, 23);
            this.lblCntClaims.TabIndex = 0;
            this.lblCntClaims.Text = "Enter number of claims you want to play with:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFalse);
            this.panel2.Controls.Add(this.btnTrue);
            this.panel2.Controls.Add(this.lblClaim);
            this.panel2.Controls.Add(this.txbClaim);
            this.panel2.Controls.Add(this.lblNumberOfPoints);
            this.panel2.Controls.Add(this.lblNumberOfClaims);
            this.panel2.Controls.Add(this.lblPoints);
            this.panel2.Controls.Add(this.lblCntClaimsToAnswer);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(12, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 390);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // btnFalse
            // 
            this.btnFalse.BackColor = System.Drawing.Color.Firebrick;
            this.btnFalse.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFalse.ForeColor = System.Drawing.Color.LightCyan;
            this.btnFalse.Location = new System.Drawing.Point(355, 248);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(201, 58);
            this.btnFalse.TabIndex = 7;
            this.btnFalse.Text = "False";
            this.btnFalse.UseVisualStyleBackColor = false;
            this.btnFalse.Click += new System.EventHandler(this.BtnFalse_Click);
            // 
            // btnTrue
            // 
            this.btnTrue.BackColor = System.Drawing.Color.DarkGreen;
            this.btnTrue.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTrue.ForeColor = System.Drawing.Color.LightCyan;
            this.btnTrue.Location = new System.Drawing.Point(15, 248);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(201, 58);
            this.btnTrue.TabIndex = 6;
            this.btnTrue.Text = "True";
            this.btnTrue.UseVisualStyleBackColor = false;
            this.btnTrue.Click += new System.EventHandler(this.BtnTrue_Click);
            // 
            // lblClaim
            // 
            this.lblClaim.AutoSize = true;
            this.lblClaim.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClaim.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblClaim.Location = new System.Drawing.Point(15, 118);
            this.lblClaim.Name = "lblClaim";
            this.lblClaim.Size = new System.Drawing.Size(68, 23);
            this.lblClaim.TabIndex = 5;
            this.lblClaim.Text = "Claim :";
            // 
            // txbClaim
            // 
            this.txbClaim.Font = new System.Drawing.Font("Franklin Gothic Book", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbClaim.Location = new System.Drawing.Point(15, 144);
            this.txbClaim.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txbClaim.Multiline = true;
            this.txbClaim.Name = "txbClaim";
            this.txbClaim.ReadOnly = true;
            this.txbClaim.Size = new System.Drawing.Size(541, 72);
            this.txbClaim.TabIndex = 4;
            // 
            // lblNumberOfPoints
            // 
            this.lblNumberOfPoints.AutoSize = true;
            this.lblNumberOfPoints.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfPoints.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblNumberOfPoints.Location = new System.Drawing.Point(97, 61);
            this.lblNumberOfPoints.Name = "lblNumberOfPoints";
            this.lblNumberOfPoints.Size = new System.Drawing.Size(38, 23);
            this.lblNumberOfPoints.TabIndex = 3;
            this.lblNumberOfPoints.Text = "0/0";
            // 
            // lblNumberOfClaims
            // 
            this.lblNumberOfClaims.AutoSize = true;
            this.lblNumberOfClaims.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfClaims.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblNumberOfClaims.Location = new System.Drawing.Point(280, 26);
            this.lblNumberOfClaims.Name = "lblNumberOfClaims";
            this.lblNumberOfClaims.Size = new System.Drawing.Size(20, 23);
            this.lblNumberOfClaims.TabIndex = 2;
            this.lblNumberOfClaims.Text = "0";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPoints.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPoints.Location = new System.Drawing.Point(15, 61);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(72, 23);
            this.lblPoints.TabIndex = 1;
            this.lblPoints.Text = "Points :";
            // 
            // lblCntClaimsToAnswer
            // 
            this.lblCntClaimsToAnswer.AutoSize = true;
            this.lblCntClaimsToAnswer.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCntClaimsToAnswer.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCntClaimsToAnswer.Location = new System.Drawing.Point(15, 25);
            this.lblCntClaimsToAnswer.Name = "lblCntClaimsToAnswer";
            this.lblCntClaimsToAnswer.Size = new System.Drawing.Size(259, 23);
            this.lblCntClaimsToAnswer.TabIndex = 0;
            this.lblCntClaimsToAnswer.Text = "Number of claims to answer :";
            // 
            // lblQuizGame
            // 
            this.lblQuizGame.AutoSize = true;
            this.lblQuizGame.Font = new System.Drawing.Font("Cooper Black", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuizGame.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblQuizGame.Location = new System.Drawing.Point(132, 26);
            this.lblQuizGame.Name = "lblQuizGame";
            this.lblQuizGame.Size = new System.Drawing.Size(332, 64);
            this.lblQuizGame.TabIndex = 1;
            this.lblQuizGame.Text = "Quiz Game";
            this.lblQuizGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblScore);
            this.panel3.Controls.Add(this.lblScoreValue);
            this.panel3.Controls.Add(this.lblEnd);
            this.panel3.Location = new System.Drawing.Point(12, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(572, 390);
            this.panel3.TabIndex = 4;
            this.panel3.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblScore.Location = new System.Drawing.Point(234, 159);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(104, 23);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Your score:";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScoreValue.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblScoreValue.Location = new System.Drawing.Point(108, 191);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(356, 23);
            this.lblScoreValue.TabIndex = 1;
            this.lblScoreValue.Text = "Your answered 0 from 0 claims correctly.";
            this.lblScoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnd.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEnd.Location = new System.Drawing.Point(187, 57);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(198, 29);
            this.lblEnd.TabIndex = 0;
            this.lblEnd.Text = "The Game Ended!";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuizGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(596, 522);
            this.Controls.Add(this.lblQuizGame);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Name = "GuizGUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Game";
            this.Load += new System.EventHandler(this.GuizGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCntClaims)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lblQuizGame;
        private NumericUpDown numCntClaims;
        private Label lblCntClaims;
        private Button btnStart;
        private Panel panel2;
        private Label lblCntClaimsToAnswer;
        private Label lblClaim;
        private TextBox txbClaim;
        private Label lblNumberOfPoints;
        private Label lblNumberOfClaims;
        private Label lblPoints;
        private Button btnFalse;
        private Button btnTrue;
        private Label lblClaimDifficulty;
        private ComboBox cmbClaimDifficulty;
        private Panel panel3;
        private Label lblEnd;
        private Label lblScore;
        private Label lblScoreValue;
    }
}