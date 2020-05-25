namespace VideoRental_Navjit
{
    partial class Rental
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
            this.radioButtonAllRented = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOutRented = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPlot = new System.Windows.Forms.TextBox();
            this.textBoxRentalCost = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxRentalID = new System.Windows.Forms.TextBox();
            this.textBoxMovieID = new System.Windows.Forms.TextBox();
            this.textCustID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPlot = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dGWMovieList = new System.Windows.Forms.DataGridView();
            this.dGWCustomerList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgWMovieRentalList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWMovieList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWMovieRentalList)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonAllRented
            // 
            this.radioButtonAllRented.AutoSize = true;
            this.radioButtonAllRented.Location = new System.Drawing.Point(7, 45);
            this.radioButtonAllRented.Name = "radioButtonAllRented";
            this.radioButtonAllRented.Size = new System.Drawing.Size(74, 17);
            this.radioButtonAllRented.TabIndex = 0;
            this.radioButtonAllRented.TabStop = true;
            this.radioButtonAllRented.Text = "All Rented";
            this.radioButtonAllRented.UseVisualStyleBackColor = true;
            this.radioButtonAllRented.CheckedChanged += new System.EventHandler(this.radioButtonAllRented_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOutRented);
            this.groupBox1.Controls.Add(this.radioButtonAllRented);
            this.groupBox1.Location = new System.Drawing.Point(523, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 84);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rented Movies";
            // 
            // radioButtonOutRented
            // 
            this.radioButtonOutRented.AutoSize = true;
            this.radioButtonOutRented.Location = new System.Drawing.Point(164, 45);
            this.radioButtonOutRented.Name = "radioButtonOutRented";
            this.radioButtonOutRented.Size = new System.Drawing.Size(80, 17);
            this.radioButtonOutRented.TabIndex = 1;
            this.radioButtonOutRented.TabStop = true;
            this.radioButtonOutRented.Text = "Out Rented";
            this.radioButtonOutRented.UseVisualStyleBackColor = true;
            this.radioButtonOutRented.CheckedChanged += new System.EventHandler(this.radioButtonOutRented_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1155, 246);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 54;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1079, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 72);
            this.button2.TabIndex = 53;
            this.button2.Text = "Return Movie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(907, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 72);
            this.button1.TabIndex = 52;
            this.button1.Text = "Issue Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPlot
            // 
            this.textBoxPlot.Location = new System.Drawing.Point(812, 110);
            this.textBoxPlot.Name = "textBoxPlot";
            this.textBoxPlot.Size = new System.Drawing.Size(185, 20);
            this.textBoxPlot.TabIndex = 51;
            // 
            // textBoxRentalCost
            // 
            this.textBoxRentalCost.Location = new System.Drawing.Point(465, 113);
            this.textBoxRentalCost.Name = "textBoxRentalCost";
            this.textBoxRentalCost.Size = new System.Drawing.Size(185, 20);
            this.textBoxRentalCost.TabIndex = 50;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(1045, 45);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(185, 20);
            this.textBoxTitle.TabIndex = 49;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(116, 116);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(185, 20);
            this.textBoxGenre.TabIndex = 48;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(575, 45);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(185, 20);
            this.textBoxLName.TabIndex = 47;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(284, 45);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(185, 20);
            this.textBoxFName.TabIndex = 46;
            // 
            // textBoxRentalID
            // 
            this.textBoxRentalID.Location = new System.Drawing.Point(1160, 110);
            this.textBoxRentalID.Name = "textBoxRentalID";
            this.textBoxRentalID.Size = new System.Drawing.Size(70, 20);
            this.textBoxRentalID.TabIndex = 45;
            // 
            // textBoxMovieID
            // 
            this.textBoxMovieID.Location = new System.Drawing.Point(878, 48);
            this.textBoxMovieID.Name = "textBoxMovieID";
            this.textBoxMovieID.Size = new System.Drawing.Size(70, 20);
            this.textBoxMovieID.TabIndex = 44;
            // 
            // textCustID
            // 
            this.textCustID.Location = new System.Drawing.Point(117, 48);
            this.textCustID.Name = "textCustID";
            this.textCustID.Size = new System.Drawing.Size(70, 20);
            this.textCustID.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1040, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Rental ID";
            // 
            // lblPlot
            // 
            this.lblPlot.AutoSize = true;
            this.lblPlot.Location = new System.Drawing.Point(674, 113);
            this.lblPlot.Name = "lblPlot";
            this.lblPlot.Size = new System.Drawing.Size(25, 13);
            this.lblPlot.TabIndex = 41;
            this.lblPlot.Text = "Plot";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(369, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Rental Cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Genre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(970, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(802, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Movie ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "L Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "F Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Cust ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Movies List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Customer List";
            // 
            // dGWMovieList
            // 
            this.dGWMovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWMovieList.Location = new System.Drawing.Point(656, 457);
            this.dGWMovieList.Name = "dGWMovieList";
            this.dGWMovieList.Size = new System.Drawing.Size(574, 150);
            this.dGWMovieList.TabIndex = 31;
            this.dGWMovieList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWMovieList_CellContentClick);
            // 
            // dGWCustomerList
            // 
            this.dGWCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWCustomerList.Location = new System.Drawing.Point(41, 457);
            this.dGWCustomerList.Name = "dGWCustomerList";
            this.dGWCustomerList.Size = new System.Drawing.Size(600, 150);
            this.dGWCustomerList.TabIndex = 30;
            this.dGWCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWCustomerList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Rental List";
            // 
            // dgWMovieRentalList
            // 
            this.dgWMovieRentalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWMovieRentalList.Location = new System.Drawing.Point(41, 272);
            this.dgWMovieRentalList.Name = "dgWMovieRentalList";
            this.dgWMovieRentalList.Size = new System.Drawing.Size(1189, 150);
            this.dgWMovieRentalList.TabIndex = 28;
            this.dgWMovieRentalList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgWMovieRentalList_CellContentClick);
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPlot);
            this.Controls.Add(this.textBoxRentalCost);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.textBoxRentalID);
            this.Controls.Add(this.textBoxMovieID);
            this.Controls.Add(this.textCustID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblPlot);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGWMovieList);
            this.Controls.Add(this.dGWCustomerList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgWMovieRentalList);
            this.Name = "Rental";
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWMovieList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWMovieRentalList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAllRented;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonOutRented;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPlot;
        private System.Windows.Forms.TextBox textBoxRentalCost;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxRentalID;
        private System.Windows.Forms.TextBox textBoxMovieID;
        private System.Windows.Forms.TextBox textCustID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPlot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGWMovieList;
        private System.Windows.Forms.DataGridView dGWCustomerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgWMovieRentalList;
    }
}