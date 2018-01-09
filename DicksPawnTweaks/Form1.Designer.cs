namespace DicksPawnTweaks
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxBackdrop = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxCPU = new System.Windows.Forms.TextBox();
            this.textBoxMemory = new System.Windows.Forms.TextBox();
            this.textBoxHDD = new System.Windows.Forms.TextBox();
            this.checkBoxTouchscreen = new System.Windows.Forms.CheckBox();
            this.checkBoxWebcam = new System.Windows.Forms.CheckBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonGatherInfo = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.priceGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxVideo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackdrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Memory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "HDD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Touchscreen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Webcam";
            // 
            // pictureBoxBackdrop
            // 
            this.pictureBoxBackdrop.BackgroundImage = global::DicksPawnTweaks.Properties.Resources.testbackground;
            this.pictureBoxBackdrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBackdrop.Location = new System.Drawing.Point(333, 7);
            this.pictureBoxBackdrop.Name = "pictureBoxBackdrop";
            this.pictureBoxBackdrop.Size = new System.Drawing.Size(750, 544);
            this.pictureBoxBackdrop.TabIndex = 7;
            this.pictureBoxBackdrop.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Suggested Price";
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(82, 12);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(239, 22);
            this.textBoxMake.TabIndex = 9;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(82, 40);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(239, 22);
            this.textBoxModel.TabIndex = 10;
            // 
            // textBoxCPU
            // 
            this.textBoxCPU.Location = new System.Drawing.Point(81, 68);
            this.textBoxCPU.Name = "textBoxCPU";
            this.textBoxCPU.Size = new System.Drawing.Size(240, 22);
            this.textBoxCPU.TabIndex = 11;
            // 
            // textBoxMemory
            // 
            this.textBoxMemory.Location = new System.Drawing.Point(82, 96);
            this.textBoxMemory.Name = "textBoxMemory";
            this.textBoxMemory.Size = new System.Drawing.Size(239, 22);
            this.textBoxMemory.TabIndex = 12;
            // 
            // textBoxHDD
            // 
            this.textBoxHDD.Location = new System.Drawing.Point(81, 124);
            this.textBoxHDD.Name = "textBoxHDD";
            this.textBoxHDD.Size = new System.Drawing.Size(240, 22);
            this.textBoxHDD.TabIndex = 13;
            // 
            // checkBoxTouchscreen
            // 
            this.checkBoxTouchscreen.AutoSize = true;
            this.checkBoxTouchscreen.Location = new System.Drawing.Point(176, 192);
            this.checkBoxTouchscreen.Name = "checkBoxTouchscreen";
            this.checkBoxTouchscreen.Size = new System.Drawing.Size(18, 17);
            this.checkBoxTouchscreen.TabIndex = 14;
            this.checkBoxTouchscreen.UseVisualStyleBackColor = true;
            // 
            // checkBoxWebcam
            // 
            this.checkBoxWebcam.AutoSize = true;
            this.checkBoxWebcam.Checked = true;
            this.checkBoxWebcam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWebcam.Location = new System.Drawing.Point(294, 191);
            this.checkBoxWebcam.Name = "checkBoxWebcam";
            this.checkBoxWebcam.Size = new System.Drawing.Size(18, 17);
            this.checkBoxWebcam.TabIndex = 15;
            this.checkBoxWebcam.UseVisualStyleBackColor = true;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(219, 269);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 16;
            // 
            // buttonGatherInfo
            // 
            this.buttonGatherInfo.Location = new System.Drawing.Point(19, 305);
            this.buttonGatherInfo.Name = "buttonGatherInfo";
            this.buttonGatherInfo.Size = new System.Drawing.Size(139, 23);
            this.buttonGatherInfo.TabIndex = 17;
            this.buttonGatherInfo.Text = "Gather Info";
            this.buttonGatherInfo.UseVisualStyleBackColor = true;
            this.buttonGatherInfo.Click += new System.EventHandler(this.buttonGatherInfo_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(169, 305);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(150, 23);
            this.buttonPreview.TabIndex = 18;
            this.buttonPreview.Text = "Generate Preview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(19, 334);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(300, 29);
            this.buttonExecute.TabIndex = 19;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // priceGridView
            // 
            this.priceGridView.AllowDrop = true;
            this.priceGridView.AllowUserToAddRows = false;
            this.priceGridView.AllowUserToDeleteRows = false;
            this.priceGridView.AllowUserToResizeColumns = false;
            this.priceGridView.AllowUserToResizeRows = false;
            this.priceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.priceGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.priceGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.priceGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.priceGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.priceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceGridView.EnableHeadersVisualStyles = false;
            this.priceGridView.Location = new System.Drawing.Point(12, 378);
            this.priceGridView.Name = "priceGridView";
            this.priceGridView.ReadOnly = true;
            this.priceGridView.RowHeadersVisible = false;
            this.priceGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.priceGridView.RowTemplate.Height = 24;
            this.priceGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.priceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.priceGridView.Size = new System.Drawing.Size(312, 173);
            this.priceGridView.TabIndex = 20;
            this.priceGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Graphics";
            // 
            // textBoxVideo
            // 
            this.textBoxVideo.Location = new System.Drawing.Point(81, 152);
            this.textBoxVideo.Name = "textBoxVideo";
            this.textBoxVideo.Size = new System.Drawing.Size(243, 22);
            this.textBoxVideo.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 568);
            this.Controls.Add(this.textBoxVideo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.priceGridView);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.buttonGatherInfo);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.checkBoxWebcam);
            this.Controls.Add(this.checkBoxTouchscreen);
            this.Controls.Add(this.textBoxHDD);
            this.Controls.Add(this.textBoxMemory);
            this.Controls.Add(this.textBoxCPU);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMake);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBoxBackdrop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dicks Pawn UI Tweaks";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackdrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxBackdrop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxCPU;
        private System.Windows.Forms.TextBox textBoxMemory;
        private System.Windows.Forms.TextBox textBoxHDD;
        private System.Windows.Forms.CheckBox checkBoxTouchscreen;
        private System.Windows.Forms.CheckBox checkBoxWebcam;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonGatherInfo;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.DataGridView priceGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxVideo;
    }
}

