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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROOK));
            this.gvLexical = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvLexicalErrors = new System.Windows.Forms.DataGridView();
            this.txtCode = new Ionic.WinForms.RichTextBoxEx();
            this.btnRun = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.styleManager3 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.styleManager4 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.lblROOK = new DevComponents.DotNetBar.LabelX();
            this.styleManager5 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lblStatus = new DevComponents.DotNetBar.LabelItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLexError = new DevComponents.DotNetBar.LabelX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.st_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_Production = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_Sets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Errors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.se_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.se_Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.se_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.se_Errors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvLexical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLexicalErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gvLexical
            // 
            this.gvLexical.AllowUserToAddRows = false;
            this.gvLexical.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvLexical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLexical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Lexeme,
            this.Token,
            this.Description});
            this.gvLexical.Location = new System.Drawing.Point(816, 85);
            this.gvLexical.Name = "gvLexical";
            this.gvLexical.RowHeadersVisible = false;
            this.gvLexical.Size = new System.Drawing.Size(405, 178);
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
            this.Lexeme.Width = 160;
            // 
            // Token
            // 
            this.Token.Frozen = true;
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            this.Token.ReadOnly = true;
            this.Token.Width = 130;
            // 
            // Description
            // 
            this.Description.Frozen = true;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 130;
            // 
            // gvLexicalErrors
            // 
            this.gvLexicalErrors.AllowUserToAddRows = false;
            this.gvLexicalErrors.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvLexicalErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLexicalErrors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Errors});
            this.gvLexicalErrors.Location = new System.Drawing.Point(11, 506);
            this.gvLexicalErrors.Name = "gvLexicalErrors";
            this.gvLexicalErrors.RowHeadersVisible = false;
            this.gvLexicalErrors.Size = new System.Drawing.Size(623, 150);
            this.gvLexicalErrors.TabIndex = 3;
            // 
            // txtCode
            // 
            this.txtCode.AcceptsTab = true;
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.Location = new System.Drawing.Point(1, 59);
            this.txtCode.Name = "txtCode";
            this.txtCode.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.txtCode.NumberBackground1 = System.Drawing.Color.Maroon;
            this.txtCode.NumberBackground2 = System.Drawing.Color.Maroon;
            this.txtCode.NumberBorder = System.Drawing.Color.DarkRed;
            this.txtCode.NumberBorderThickness = 2F;
            this.txtCode.NumberColor = System.Drawing.Color.White;
            this.txtCode.NumberFont = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.NumberLeadingZeroes = false;
            this.txtCode.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.txtCode.NumberPadding = 3;
            this.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCode.ShowLineNumbers = true;
            this.txtCode.Size = new System.Drawing.Size(809, 412);
            this.txtCode.TabIndex = 5;
            this.txtCode.Text = "";
            // 
            // btnRun
            // 
            this.btnRun.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRun.BackColor = System.Drawing.Color.Transparent;
            this.btnRun.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnRun.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(4, 30);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(81, 23);
            this.btnRun.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRun.Symbol = "";
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = " RUN";
            this.btnRun.TextColor = System.Drawing.Color.Maroon;
            this.btnRun.Click += new System.EventHandler(this.btnRn_Click_1);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager2.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // styleManager3
            // 
            this.styleManager3.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager3.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // metroShell1
            // 
            this.metroShell1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroShell1.CaptionVisible = true;
            this.metroShell1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroShell1.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroShell1.ForeColor = System.Drawing.Color.Black;
            this.metroShell1.HelpButtonText = null;
            this.metroShell1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.metroShell1.Location = new System.Drawing.Point(1, 1);
            this.metroShell1.Name = "metroShell1";
            this.metroShell1.Size = new System.Drawing.Size(1223, 23);
            this.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.metroShell1.SystemText.QatDialogAddButton = "&Add >>";
            this.metroShell1.SystemText.QatDialogCancelButton = "Cancel";
            this.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.metroShell1.SystemText.QatDialogOkButton = "OK";
            this.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatDialogRemoveButton = "&Remove";
            this.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.metroShell1.TabIndex = 7;
            this.metroShell1.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroShell1.Text = "metroShell1";
            // 
            // styleManager4
            // 
            this.styleManager4.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager4.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // lblROOK
            // 
            this.lblROOK.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblROOK.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblROOK.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblROOK.ForeColor = System.Drawing.Color.Black;
            this.lblROOK.Location = new System.Drawing.Point(43, 1);
            this.lblROOK.Name = "lblROOK";
            this.lblROOK.Size = new System.Drawing.Size(213, 23);
            this.lblROOK.TabIndex = 8;
            this.lblROOK.Text = "ROOK Compiler";
            // 
            // styleManager5
            // 
            this.styleManager5.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager5.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // metroStatusBar1
            // 
            this.metroStatusBar1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.BackColor = System.Drawing.Color.Maroon;
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.DragDropSupport = true;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblStatus});
            this.metroStatusBar1.Location = new System.Drawing.Point(1, 662);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(1223, 22);
            this.metroStatusBar1.TabIndex = 9;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "Ready";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(847, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "LEXICAL TABLE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLexError
            // 
            this.lblLexError.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblLexError.BackgroundStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLexError.BackgroundStyle.BorderColor = System.Drawing.Color.Maroon;
            this.lblLexError.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLexError.BackgroundStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLexError.EnableMarkup = false;
            this.lblLexError.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLexError.FontBold = true;
            this.lblLexError.ForeColor = System.Drawing.Color.Black;
            this.lblLexError.Location = new System.Drawing.Point(170, 477);
            this.lblLexError.Name = "lblLexError";
            this.lblLexError.SingleLineColor = System.Drawing.Color.White;
            this.lblLexError.Size = new System.Drawing.Size(298, 23);
            this.lblLexError.TabIndex = 13;
            this.lblLexError.Text = "LEXICAL ERROR";
            this.lblLexError.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.st_ID,
            this.st_Production,
            this.st_Point,
            this.st_Sets});
            this.dataGridView1.Location = new System.Drawing.Point(816, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(405, 167);
            this.dataGridView1.TabIndex = 14;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.se_Id,
            this.se_Line,
            this.se_Column,
            this.se_Errors});
            this.dataGridView2.Location = new System.Drawing.Point(640, 506);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(581, 150);
            this.dataGridView2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(847, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "SYNTAX TABLE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelX1.BackgroundStyle.BorderColor = System.Drawing.Color.Maroon;
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.BackgroundStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.EnableMarkup = false;
            this.labelX1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.FontBold = true;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(784, 477);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.Color.White;
            this.labelX1.Size = new System.Drawing.Size(298, 23);
            this.labelX1.TabIndex = 17;
            this.labelX1.Text = "SYNTAX ERROR";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // st_ID
            // 
            this.st_ID.HeaderText = "ID";
            this.st_ID.Name = "st_ID";
            this.st_ID.ReadOnly = true;
            this.st_ID.Width = 30;
            // 
            // st_Production
            // 
            this.st_Production.HeaderText = "Productions";
            this.st_Production.Name = "st_Production";
            this.st_Production.ReadOnly = true;
            this.st_Production.Width = 150;
            // 
            // st_Point
            // 
            this.st_Point.HeaderText = "->";
            this.st_Point.Name = "st_Point";
            this.st_Point.ReadOnly = true;
            this.st_Point.Width = 40;
            // 
            // st_Sets
            // 
            this.st_Sets.HeaderText = "Sets";
            this.st_Sets.Name = "st_Sets";
            this.st_Sets.ReadOnly = true;
            this.st_Sets.Width = 182;
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
            this.Errors.Width = 590;
            // 
            // se_Id
            // 
            this.se_Id.HeaderText = "ID";
            this.se_Id.Name = "se_Id";
            this.se_Id.ReadOnly = true;
            this.se_Id.Width = 30;
            // 
            // se_Line
            // 
            this.se_Line.HeaderText = "Line";
            this.se_Line.Name = "se_Line";
            this.se_Line.ReadOnly = true;
            this.se_Line.Width = 50;
            // 
            // se_Column
            // 
            this.se_Column.HeaderText = "Column";
            this.se_Column.Name = "se_Column";
            this.se_Column.ReadOnly = true;
            this.se_Column.Width = 50;
            // 
            // se_Errors
            // 
            this.se_Errors.HeaderText = "Errors";
            this.se_Errors.Name = "se_Errors";
            this.se_Errors.ReadOnly = true;
            this.se_Errors.Width = 447;
            // 
            // ROOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1225, 685);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblLexError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.lblROOK);
            this.Controls.Add(this.metroShell1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.gvLexicalErrors);
            this.Controls.Add(this.gvLexical);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ROOK";
            this.Sizable = false;
            this.SystemMenuMaximize = "Minimize";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvLexical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLexicalErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gvLexical;
        private System.Windows.Forms.DataGridView gvLexicalErrors;
        private Ionic.WinForms.RichTextBoxEx txtCode;
        private DevComponents.DotNetBar.ButtonX btnRun;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.StyleManager styleManager2;
        private DevComponents.DotNetBar.StyleManager styleManager3;
        private DevComponents.DotNetBar.Metro.MetroShell metroShell1;
        private DevComponents.DotNetBar.StyleManager styleManager4;
        private DevComponents.DotNetBar.LabelX lblROOK;
        private DevComponents.DotNetBar.StyleManager styleManager5;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem lblStatus;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.LabelX lblLexError;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Errors;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_Production;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_Sets;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn se_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn se_Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn se_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn se_Errors;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}

