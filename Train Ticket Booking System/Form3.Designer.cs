namespace Train_Ticket_Booking_System
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetAllTrains = new System.Windows.Forms.Button();
            this.dgvTrainData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1240, 78);
            this.label3.TabIndex = 9;
            this.label3.Text = "Train Ticket Booking System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 616);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1240, 47);
            this.label4.TabIndex = 11;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGetAllTrains
            // 
            this.btnGetAllTrains.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAllTrains.Location = new System.Drawing.Point(13, 136);
            this.btnGetAllTrains.Name = "btnGetAllTrains";
            this.btnGetAllTrains.Size = new System.Drawing.Size(226, 43);
            this.btnGetAllTrains.TabIndex = 20;
            this.btnGetAllTrains.Text = "View Train Schedule";
            this.btnGetAllTrains.UseVisualStyleBackColor = true;
            this.btnGetAllTrains.Click += new System.EventHandler(this.btnGetAllTrains_Click);
            // 
            // dgvTrainData
            // 
            this.dgvTrainData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvTrainData.Location = new System.Drawing.Point(453, 136);
            this.dgvTrainData.Name = "dgvTrainData";
            this.dgvTrainData.Size = new System.Drawing.Size(800, 435);
            this.dgvTrainData.TabIndex = 21;
            //this.dgvTrainData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainData_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Book Train";
            this.Column1.ToolTipText = "Book Train";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 70;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(12, 225);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(409, 346);
            this.textBox1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Search Train";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "Date";
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.Location = new System.Drawing.Point(181, 366);
            this.txtStart.Multiline = true;
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(217, 35);
            this.txtStart.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "Destination Station";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Start Station";
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Location = new System.Drawing.Point(235, 422);
            this.txtEnd.Multiline = true;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(163, 35);
            this.txtEnd.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(290, 488);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 36);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Train_Ticket_Booking_System.Properties.Resources._3458951;
            this.pictureBox1.Location = new System.Drawing.Point(281, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(181, 321);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 33;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 672);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvTrainData);
            this.Controls.Add(this.btnGetAllTrains);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetAllTrains;
        private System.Windows.Forms.DataGridView dgvTrainData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}