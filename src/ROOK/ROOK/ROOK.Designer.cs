namespace ROOK
{
    partial class ROOK
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
            this.btnRun = new System.Windows.Forms.Button();
            this.gvLexical = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvLexicalErrors = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Errors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCode = new Ionic.WinForms.RichTextBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.gvLexical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLexicalErrors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(589, 92);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(182, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // gvLexical
            // 
            this.gvLexical.AllowUserToAddRows = false;
            this.gvLexical.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvLexical.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvLexical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLexical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Lexeme,
            this.Token,
            this.Description});
            this.gvLexical.Location = new System.Drawing.Point(522, 192);
            this.gvLexical.Name = "gvLexical";
            this.gvLexical.RowHeadersVisible = false;
            this.gvLexical.Size = new System.Drawing.Size(302, 150);
            this.gvLexical.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 30;
            // 
            // Lexeme
            // 
            this.Lexeme.Frozen = true;
            this.Lexeme.HeaderText = "Lexeme";
            this.Lexeme.Name = "Lexeme";
            this.Lexeme.ReadOnly = true;
            // 
            // Token
            // 
            this.Token.Frozen = true;
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            this.Token.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.Frozen = true;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // gvLexicalErrors
            // 
            this.gvLexicalErrors.AllowUserToAddRows = false;
            this.gvLexicalErrors.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvLexicalErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLexicalErrors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Errors});
            this.gvLexicalErrors.Location = new System.Drawing.Point(522, 348);
            this.gvLexicalErrors.Name = "gvLexicalErrors";
            this.gvLexicalErrors.RowHeadersVisible = false;
            this.gvLexicalErrors.Size = new System.Drawing.Size(302, 150);
            this.gvLexicalErrors.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // Errors
            // 
            this.Errors.HeaderText = "Errors";
            this.Errors.Name = "Errors";
            this.Errors.ReadOnly = true;
            this.Errors.Width = 268;
            // 
            // txtCode
            // 
            this.txtCode.AcceptsTab = true;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCode.Location = new System.Drawing.Point(0, 0);
            this.txtCode.Name = "txtCode";
            this.txtCode.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.txtCode.NumberBackground1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCode.NumberBackground2 = System.Drawing.SystemColors.MenuText;
            this.txtCode.NumberBorder = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCode.NumberBorderThickness = 5F;
            this.txtCode.NumberColor = System.Drawing.Color.White;
            this.txtCode.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.NumberLeadingZeroes = false;
            this.txtCode.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.txtCode.NumberPadding = 5;
            this.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCode.ShowLineNumbers = true;
            this.txtCode.Size = new System.Drawing.Size(517, 542);
            this.txtCode.TabIndex = 5;
            this.txtCode.Text = "";
            // 
            // ROOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(839, 542);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.gvLexicalErrors);
            this.Controls.Add(this.gvLexical);
            this.Controls.Add(this.btnRun);
            this.Name = "ROOK";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvLexical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLexicalErrors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridView gvLexical;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridView gvLexicalErrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Errors;
        private Ionic.WinForms.RichTextBoxEx txtCode;
    }
}

