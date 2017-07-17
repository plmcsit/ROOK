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
            this.Code = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.gvLexical = new System.Windows.Forms.DataGridView();
            this.Lexeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvLexical)).BeginInit();
            this.SuspendLayout();
            // 
            // Code
            // 
            this.Code.BackColor = System.Drawing.SystemColors.Info;
            this.Code.Location = new System.Drawing.Point(4, 4);
            this.Code.Multiline = true;
            this.Code.Name = "Code";
            this.Code.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Code.Size = new System.Drawing.Size(511, 554);
            this.Code.TabIndex = 0;
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
            this.Lexeme,
            this.Token,
            this.Description});
            this.gvLexical.Location = new System.Drawing.Point(522, 192);
            this.gvLexical.Name = "gvLexical";
            this.gvLexical.RowHeadersVisible = false;
            this.gvLexical.Size = new System.Drawing.Size(302, 150);
            this.gvLexical.TabIndex = 2;
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
            // ROOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(832, 563);
            this.Controls.Add(this.gvLexical);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.Code);
            this.Name = "ROOK";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvLexical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridView gvLexical;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}

