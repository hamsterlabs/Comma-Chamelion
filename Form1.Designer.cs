namespace CommaChamelion
{
    partial class Form1
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
            this.textLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.outBox = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbDelimiter = new System.Windows.Forms.CheckBox();
            this.btnSQLVanity = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnTableMaker = new System.Windows.Forms.Button();
            this.btnProcDrop = new System.Windows.Forms.Button();
            this.btnTableDrop = new System.Windows.Forms.Button();
            this.btnViewDrop = new System.Windows.Forms.Button();
            this.btnSQLTables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // 
            // textBox
            //
            this.textBox.Font =new System.Drawing.Font("Microsoft Sans Serif", 8.000F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(10,10);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(500,300);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "Copy/Paste here";
            this.textBox.Multiline = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.MaxLength = 8192;
            // 
            // outBox
            //
            this.outBox.Font =new System.Drawing.Font("Microsoft Sans Serif", 8.000F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outBox.Location = new System.Drawing.Point(10,320);
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(500,300);
            this.outBox.TabIndex = 1;
            this.outBox.Text = "results go here";
            this.outBox.Multiline = true;
            this.outBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outBox.MaxLength = 8192;
            //
            // btnCopy
            //
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.000F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(540, 10);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(150, 45);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";  
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);          
            //
            // btnClear
            //
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.000F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(540, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 45);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // btnSort
            //
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.000F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(540, 120);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(140, 45);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sort";
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            //
            // btnComma
            //
            this.btnComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.000F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComma.Location = new System.Drawing.Point(540, 175);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(140, 45);
            this.btnComma.TabIndex = 4;
            this.btnComma.Text = "Comma Join";
            this.btnComma.Click += new System.EventHandler(this.btnComma_Click);
            //
            // cbDelimiter
            //
            this.cbDelimiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.000F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDelimiter.Location = new System.Drawing.Point(540, 220);
            this.cbDelimiter.Name = "cbDelimiter";
            this.cbDelimiter.Size = new System.Drawing.Size(140, 45);
            this.cbDelimiter.TabIndex = 5;
            this.cbDelimiter.Text = "Delimiter";
            this.cbDelimiter.CheckedChanged += new System.EventHandler(this.cbDelimiter_CheckChanged);
            //
            // btnTableMaker
            //
            this.btnTableMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.000F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableMaker.Location = new System.Drawing.Point(540, 285);
            this.btnTableMaker.Name = "btnTableMaker";
            this.btnTableMaker.Size = new System.Drawing.Size(140, 45);
            this.btnTableMaker.TabIndex = 6;
            this.btnTableMaker.Text = "Tables";
            this.btnTableMaker.Click += new System.EventHandler(this.btnTableMaker_Click);
            //
            // btnProcDrop
            //
            this.btnProcDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.000F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcDrop.Location = new System.Drawing.Point(540, 340);
            this.btnProcDrop.Name = "btnProcDrop";
            this.btnProcDrop.Size = new System.Drawing.Size(140, 45);
            this.btnProcDrop.TabIndex = 7;
            this.btnProcDrop.Text = "Proc Drop";
            this.btnProcDrop.Click += new System.EventHandler(this.btnProcDrop_Click);
            //
            // btnTableDrop
            //
            this.btnTableDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.000F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableDrop.Location = new System.Drawing.Point(540, 395);
            this.btnTableDrop.Name = "btnTableDrop";
            this.btnTableDrop.Size = new System.Drawing.Size(140, 45);
            this.btnTableDrop.TabIndex = 8;
            this.btnTableDrop.Text = "Table Drop";
            this.btnTableDrop.Click += new System.EventHandler(this.btnTableDrop_Click);
            //
            // btnViewDrop
            //
            this.btnViewDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.000F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDrop.Location = new System.Drawing.Point(540, 450);
            this.btnViewDrop.Name = "btnViewDrop";
            this.btnViewDrop.Size = new System.Drawing.Size(140, 45);
            this.btnViewDrop.TabIndex = 9;
            this.btnViewDrop.Text = "View Drop";
            this.btnViewDrop.Click += new System.EventHandler(this.btnViewDrop_Click);
            //
            // btnSQLVanity
            //
            this.btnSQLVanity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.000F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSQLVanity.Location = new System.Drawing.Point(540, 505);
            this.btnSQLVanity.Name = "btnSQLVanity";
            this.btnSQLVanity.Size = new System.Drawing.Size(140, 45);
            this.btnSQLVanity.TabIndex = 10;
            this.btnSQLVanity.Text = "SQL Vanity";
            this.btnSQLVanity.Click += new System.EventHandler(this.btnSQLVanity_Click);
            // 
            // btnExit
            // 
            //this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Location = new System.Drawing.Point(540, 560);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 45);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(20, 30);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.cbDelimiter);
            this.Controls.Add(this.btnTableMaker);
            this.Controls.Add(this.btnProcDrop);
            this.Controls.Add(this.btnTableDrop);
            this.Controls.Add(this.btnViewDrop);
            this.Controls.Add(this.btnSQLVanity);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Comma Chamelion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox outBox;
        private System.Windows.Forms.CheckBox cbDelimiter;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button btnSQLTables;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnTableMaker;
        private System.Windows.Forms.Button btnProcDrop;
        private System.Windows.Forms.Button btnTableDrop;
        private System.Windows.Forms.Button btnViewDrop;
        private System.Windows.Forms.Button btnSQLVanity;
        private System.Windows.Forms.Button btnExit;
    }
}

