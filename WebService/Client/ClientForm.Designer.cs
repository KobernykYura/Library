namespace Client
{
    partial class ClientForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.readersdataGrid = new System.Windows.Forms.DataGridView();
            this.addreader = new System.Windows.Forms.Button();
            this.changereader = new System.Windows.Forms.Button();
            this.Deletereader = new System.Windows.Forms.Button();
            this.adddep = new System.Windows.Forms.Button();
            this.booksdataGrid = new System.Windows.Forms.DataGridView();
            this.addbook = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginadmin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readersdataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksdataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.readersdataGrid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.addreader, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.changereader, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.Deletereader, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.adddep, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.booksdataGrid, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.addbook, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.button6, 8, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.loginadmin, 9, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1312, 452);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // readersdataGrid
            // 
            this.readersdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.readersdataGrid, 3);
            this.readersdataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readersdataGrid.Location = new System.Drawing.Point(134, 48);
            this.readersdataGrid.Name = "readersdataGrid";
            this.tableLayoutPanel1.SetRowSpan(this.readersdataGrid, 5);
            this.readersdataGrid.Size = new System.Drawing.Size(387, 219);
            this.readersdataGrid.TabIndex = 1;
            // 
            // addreader
            // 
            this.addreader.Dock = System.Windows.Forms.DockStyle.Top;
            this.addreader.Location = new System.Drawing.Point(134, 273);
            this.addreader.Name = "addreader";
            this.addreader.Size = new System.Drawing.Size(125, 23);
            this.addreader.TabIndex = 0;
            this.addreader.Text = "Add";
            this.addreader.UseVisualStyleBackColor = true;
            // 
            // changereader
            // 
            this.changereader.Dock = System.Windows.Forms.DockStyle.Top;
            this.changereader.Location = new System.Drawing.Point(265, 273);
            this.changereader.Name = "changereader";
            this.changereader.Size = new System.Drawing.Size(125, 23);
            this.changereader.TabIndex = 2;
            this.changereader.Text = "Change";
            this.changereader.UseVisualStyleBackColor = true;
            // 
            // Deletereader
            // 
            this.Deletereader.Dock = System.Windows.Forms.DockStyle.Top;
            this.Deletereader.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Deletereader.Location = new System.Drawing.Point(396, 273);
            this.Deletereader.Name = "Deletereader";
            this.Deletereader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Deletereader.Size = new System.Drawing.Size(125, 23);
            this.Deletereader.TabIndex = 3;
            this.Deletereader.Text = "Delete";
            this.Deletereader.UseVisualStyleBackColor = true;
            // 
            // adddep
            // 
            this.adddep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adddep.Location = new System.Drawing.Point(265, 318);
            this.adddep.Name = "adddep";
            this.adddep.Size = new System.Drawing.Size(125, 39);
            this.adddep.TabIndex = 4;
            this.adddep.Text = "Add department";
            this.adddep.UseVisualStyleBackColor = true;
            // 
            // booksdataGrid
            // 
            this.booksdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.booksdataGrid, 4);
            this.booksdataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksdataGrid.Location = new System.Drawing.Point(658, 48);
            this.booksdataGrid.Name = "booksdataGrid";
            this.tableLayoutPanel1.SetRowSpan(this.booksdataGrid, 5);
            this.booksdataGrid.Size = new System.Drawing.Size(518, 219);
            this.booksdataGrid.TabIndex = 5;
            // 
            // addbook
            // 
            this.addbook.Dock = System.Windows.Forms.DockStyle.Top;
            this.addbook.Location = new System.Drawing.Point(658, 273);
            this.addbook.Name = "addbook";
            this.addbook.Size = new System.Drawing.Size(125, 23);
            this.addbook.TabIndex = 6;
            this.addbook.Text = "Add";
            this.addbook.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Location = new System.Drawing.Point(1051, 273);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Choose category";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Readers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(527, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Books list";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // loginadmin
            // 
            this.loginadmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.loginadmin.Location = new System.Drawing.Point(1256, 3);
            this.loginadmin.Name = "loginadmin";
            this.tableLayoutPanel1.SetRowSpan(this.loginadmin, 10);
            this.loginadmin.Size = new System.Drawing.Size(53, 446);
            this.loginadmin.TabIndex = 10;
            this.loginadmin.Text = "Admin";
            this.loginadmin.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 452);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClientForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readersdataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksdataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView readersdataGrid;
        private System.Windows.Forms.Button addreader;
        private System.Windows.Forms.Button changereader;
        private System.Windows.Forms.Button Deletereader;
        private System.Windows.Forms.Button adddep;
        private System.Windows.Forms.DataGridView booksdataGrid;
        private System.Windows.Forms.Button addbook;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginadmin;
    }
}

