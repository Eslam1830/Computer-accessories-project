namespace مشروع_الكاشير
{
    partial class الكاشير
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(الكاشير));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxfato_num = new System.Windows.Forms.TextBox();
            this.textBoxdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxitem = new System.Windows.Forms.ComboBox();
            this.textBoxprice = new System.Windows.Forms.TextBox();
            this.textBoxquantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxtotal = new System.Windows.Forms.TextBox();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonprint = new System.Windows.Forms.Button();
            this.dataGridViewfatora = new System.Windows.Forms.DataGridView();
            this.Columnitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnqantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columntotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProviderForName = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipName = new System.Windows.Forms.ToolTip(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfatora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(394, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(336, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "شاشه الفاتورة ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::مشروع_الكاشير.Properties.Resources.ttt;
            this.pictureBox1.Location = new System.Drawing.Point(978, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(394, 50);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel1.Size = new System.Drawing.Size(340, 36);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http:\\\\www.eslamemara.com";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "رقم الفاتورة :";
            // 
            // textBoxfato_num
            // 
            this.textBoxfato_num.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfato_num.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxfato_num.Location = new System.Drawing.Point(141, 100);
            this.textBoxfato_num.Name = "textBoxfato_num";
            this.textBoxfato_num.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxfato_num.Size = new System.Drawing.Size(253, 33);
            this.textBoxfato_num.TabIndex = 4;
            this.textBoxfato_num.Text = "000";
            this.textBoxfato_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxfato_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxfato_num_KeyPress);
            this.textBoxfato_num.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxfato_num_MouseDown);
            // 
            // textBoxdate
            // 
            this.textBoxdate.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdate.ForeColor = System.Drawing.Color.ForestGreen;
            this.textBoxdate.Location = new System.Drawing.Point(503, 100);
            this.textBoxdate.Name = "textBoxdate";
            this.textBoxdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxdate.Size = new System.Drawing.Size(253, 33);
            this.textBoxdate.TabIndex = 6;
            this.textBoxdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxdate_KeyPress);
            this.textBoxdate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxdate_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "التاريخ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "اسم الزبون :";
            // 
            // textBoxname
            // 
            this.textBoxname.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxname.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxname.Location = new System.Drawing.Point(142, 146);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(614, 33);
            this.textBoxname.TabIndex = 8;
            this.textBoxname.Text = "الاسم";
            this.textBoxname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipName.SetToolTip(this.textBoxname, "قم بادخال الاسم ثلاثي من فضلك ");
            this.textBoxname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxname_KeyDown);
            this.textBoxname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxname_KeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1212, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "_________________________________________________________________________________" +
    "_____________________________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "الصنف :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "السعر :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "الكميه :";
            // 
            // comboBoxitem
            // 
            this.comboBoxitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxitem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxitem.FormattingEnabled = true;
            this.comboBoxitem.Location = new System.Drawing.Point(99, 215);
            this.comboBoxitem.Name = "comboBoxitem";
            this.comboBoxitem.Size = new System.Drawing.Size(657, 31);
            this.comboBoxitem.TabIndex = 13;
            this.comboBoxitem.SelectedIndexChanged += new System.EventHandler(this.comboBoxitem_SelectedIndexChanged);
            this.comboBoxitem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxitem_KeyDown);
            // 
            // textBoxprice
            // 
            this.textBoxprice.BackColor = System.Drawing.Color.DarkViolet;
            this.textBoxprice.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxprice.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxprice.Location = new System.Drawing.Point(99, 254);
            this.textBoxprice.Name = "textBoxprice";
            this.textBoxprice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxprice.Size = new System.Drawing.Size(295, 33);
            this.textBoxprice.TabIndex = 14;
            this.textBoxprice.Text = "0";
            this.textBoxprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxprice_KeyPress);
            this.textBoxprice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxprice_MouseDown);
            // 
            // textBoxquantity
            // 
            this.textBoxquantity.ForeColor = System.Drawing.Color.Navy;
            this.textBoxquantity.Location = new System.Drawing.Point(503, 257);
            this.textBoxquantity.Name = "textBoxquantity";
            this.textBoxquantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxquantity.Size = new System.Drawing.Size(253, 30);
            this.textBoxquantity.TabIndex = 15;
            this.textBoxquantity.Text = "1";
            this.textBoxquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxquantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxquantity_KeyDown);
            this.textBoxquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxquantity_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(803, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "** الاجمالي  **";
            // 
            // textBoxtotal
            // 
            this.textBoxtotal.BackColor = System.Drawing.Color.DarkGreen;
            this.textBoxtotal.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtotal.ForeColor = System.Drawing.Color.Turquoise;
            this.textBoxtotal.Location = new System.Drawing.Point(762, 249);
            this.textBoxtotal.Name = "textBoxtotal";
            this.textBoxtotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxtotal.Size = new System.Drawing.Size(232, 40);
            this.textBoxtotal.TabIndex = 17;
            this.textBoxtotal.Text = "0";
            this.textBoxtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxtotal_KeyPress);
            this.textBoxtotal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxtotal_MouseDown);
            // 
            // buttonadd
            // 
            this.buttonadd.AllowDrop = true;
            this.buttonadd.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonadd.ForeColor = System.Drawing.Color.White;
            this.buttonadd.Location = new System.Drawing.Point(1000, 223);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(100, 66);
            this.buttonadd.TabIndex = 18;
            this.buttonadd.Text = "اضافه";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            this.buttonadd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonadd_MouseDown);
            this.buttonadd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonadd_MouseUp);
            // 
            // buttonprint
            // 
            this.buttonprint.AllowDrop = true;
            this.buttonprint.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonprint.ForeColor = System.Drawing.Color.White;
            this.buttonprint.Location = new System.Drawing.Point(1112, 223);
            this.buttonprint.Name = "buttonprint";
            this.buttonprint.Size = new System.Drawing.Size(100, 66);
            this.buttonprint.TabIndex = 19;
            this.buttonprint.Text = "طباعه";
            this.buttonprint.UseVisualStyleBackColor = false;
            this.buttonprint.Click += new System.EventHandler(this.buttonprint_Click);
            this.buttonprint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonprint_MouseDown);
            this.buttonprint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonprint_MouseUp);
            // 
            // dataGridViewfatora
            // 
            this.dataGridViewfatora.AllowUserToAddRows = false;
            this.dataGridViewfatora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewfatora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewfatora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfatora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnitem,
            this.Columnqantity,
            this.Columnprice,
            this.Columntotal});
            this.dataGridViewfatora.Location = new System.Drawing.Point(16, 309);
            this.dataGridViewfatora.Name = "dataGridViewfatora";
            this.dataGridViewfatora.Size = new System.Drawing.Size(1196, 263);
            this.dataGridViewfatora.TabIndex = 20;
            this.dataGridViewfatora.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewfatora_CellBeginEdit);
            this.dataGridViewfatora.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewfatora_CellEndEdit);
            // 
            // Columnitem
            // 
            this.Columnitem.HeaderText = "الصنف";
            this.Columnitem.Name = "Columnitem";
            this.Columnitem.ReadOnly = true;
            // 
            // Columnqantity
            // 
            this.Columnqantity.HeaderText = "الكميه";
            this.Columnqantity.Name = "Columnqantity";
            // 
            // Columnprice
            // 
            this.Columnprice.HeaderText = "سعرالوحده";
            this.Columnprice.Name = "Columnprice";
            this.Columnprice.ReadOnly = true;
            // 
            // Columntotal
            // 
            this.Columntotal.HeaderText = "الاجمالي الفرعي";
            this.Columntotal.Name = "Columntotal";
            this.Columntotal.ReadOnly = true;
            // 
            // errorProviderForName
            // 
            this.errorProviderForName.ContainerControl = this;
            // 
            // toolTipName
            // 
            this.toolTipName.AutomaticDelay = 100;
            this.toolTipName.AutoPopDelay = 5000;
            this.toolTipName.BackColor = System.Drawing.Color.DarkViolet;
            this.toolTipName.ForeColor = System.Drawing.Color.White;
            this.toolTipName.InitialDelay = 100;
            this.toolTipName.IsBalloon = true;
            this.toolTipName.ReshowDelay = 20;
            this.toolTipName.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipName.ToolTipTitle = "انتبه!!";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // الكاشير
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 584);
            this.Controls.Add(this.dataGridViewfatora);
            this.Controls.Add(this.buttonprint);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.textBoxtotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxquantity);
            this.Controls.Add(this.textBoxprice);
            this.Controls.Add(this.comboBoxitem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxfato_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "الكاشير";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الكاشير";
            this.Load += new System.EventHandler(this.الكاشير_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfatora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxfato_num;
        private System.Windows.Forms.TextBox textBoxdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxitem;
        private System.Windows.Forms.TextBox textBoxprice;
        private System.Windows.Forms.TextBox textBoxquantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxtotal;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonprint;
        private System.Windows.Forms.DataGridView dataGridViewfatora;
        private System.Windows.Forms.ToolTip toolTipName;
        private System.Windows.Forms.ErrorProvider errorProviderForName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnqantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columntotal;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

