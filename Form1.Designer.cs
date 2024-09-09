namespace PRODIGY_SD_04
{
    partial class SudokuSolver
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
            this.btnSolve = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSolve.Location = new System.Drawing.Point(76, 326);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(113, 32);
            this.btnSolve.TabIndex = 82;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(52, 280);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 32);
            this.lblTitle.TabIndex = 83;
            this.lblTitle.Text = "Sudoku Solver";
            // 
            // SudokuSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSolve);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SudokuSolver";
            this.Text = "SodukuSolver";
            this.Load += new System.EventHandler(this.SudokuSolver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label lblTitle;
    }
}

