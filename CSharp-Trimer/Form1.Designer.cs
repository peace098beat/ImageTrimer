namespace CSharp_Trimer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_LoadImage = new System.Windows.Forms.Button();
            this.label_LoadImage = new System.Windows.Forms.Label();
            this.label_Savedir = new System.Windows.Forms.Label();
            this.button_SaveDir = new System.Windows.Forms.Button();
            this.pictureBox_OriginImage = new System.Windows.Forms.PictureBox();
            this.listView_TrimedImages = new System.Windows.Forms.ListView();
            this.button_Triming = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_ListUpdate = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Debug = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OriginImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_LoadImage
            // 
            this.button_LoadImage.Location = new System.Drawing.Point(12, 12);
            this.button_LoadImage.Name = "button_LoadImage";
            this.button_LoadImage.Size = new System.Drawing.Size(75, 23);
            this.button_LoadImage.TabIndex = 0;
            this.button_LoadImage.Text = "button1";
            this.button_LoadImage.UseVisualStyleBackColor = true;
            this.button_LoadImage.Click += new System.EventHandler(this.button_LoadImage_Click);
            // 
            // label_LoadImage
            // 
            this.label_LoadImage.AutoSize = true;
            this.label_LoadImage.Location = new System.Drawing.Point(93, 17);
            this.label_LoadImage.Name = "label_LoadImage";
            this.label_LoadImage.Size = new System.Drawing.Size(35, 12);
            this.label_LoadImage.TabIndex = 1;
            this.label_LoadImage.Text = "label1";
            // 
            // label_Savedir
            // 
            this.label_Savedir.AutoSize = true;
            this.label_Savedir.Location = new System.Drawing.Point(409, 22);
            this.label_Savedir.Name = "label_Savedir";
            this.label_Savedir.Size = new System.Drawing.Size(35, 12);
            this.label_Savedir.TabIndex = 3;
            this.label_Savedir.Text = "label1";
            // 
            // button_SaveDir
            // 
            this.button_SaveDir.Location = new System.Drawing.Point(328, 17);
            this.button_SaveDir.Name = "button_SaveDir";
            this.button_SaveDir.Size = new System.Drawing.Size(75, 23);
            this.button_SaveDir.TabIndex = 2;
            this.button_SaveDir.Text = "button1";
            this.button_SaveDir.UseVisualStyleBackColor = true;
            this.button_SaveDir.Click += new System.EventHandler(this.button_SaveDir_Click);
            // 
            // pictureBox_OriginImage
            // 
            this.pictureBox_OriginImage.Location = new System.Drawing.Point(12, 115);
            this.pictureBox_OriginImage.Name = "pictureBox_OriginImage";
            this.pictureBox_OriginImage.Size = new System.Drawing.Size(291, 267);
            this.pictureBox_OriginImage.TabIndex = 4;
            this.pictureBox_OriginImage.TabStop = false;
            // 
            // listView_TrimedImages
            // 
            this.listView_TrimedImages.Location = new System.Drawing.Point(494, 101);
            this.listView_TrimedImages.Name = "listView_TrimedImages";
            this.listView_TrimedImages.Size = new System.Drawing.Size(294, 328);
            this.listView_TrimedImages.TabIndex = 5;
            this.listView_TrimedImages.UseCompatibleStateImageBehavior = false;
            // 
            // button_Triming
            // 
            this.button_Triming.Location = new System.Drawing.Point(13, 388);
            this.button_Triming.Name = "button_Triming";
            this.button_Triming.Size = new System.Drawing.Size(290, 26);
            this.button_Triming.TabIndex = 6;
            this.button_Triming.Text = "Triming";
            this.button_Triming.UseVisualStyleBackColor = true;
            this.button_Triming.Click += new System.EventHandler(this.button_Triming_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button_ListUpdate
            // 
            this.button_ListUpdate.Location = new System.Drawing.Point(328, 56);
            this.button_ListUpdate.Name = "button_ListUpdate";
            this.button_ListUpdate.Size = new System.Drawing.Size(75, 23);
            this.button_ListUpdate.TabIndex = 7;
            this.button_ListUpdate.Text = "UPDATE";
            this.button_ListUpdate.UseVisualStyleBackColor = true;
            this.button_ListUpdate.Click += new System.EventHandler(this.button_ListUpdate_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(69, 41);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            224,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 19);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            112,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "stride";
            // 
            // textBox_Debug
            // 
            this.textBox_Debug.Location = new System.Drawing.Point(13, 432);
            this.textBox_Debug.Name = "textBox_Debug";
            this.textBox_Debug.Size = new System.Drawing.Size(290, 19);
            this.textBox_Debug.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 513);
            this.Controls.Add(this.textBox_Debug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button_ListUpdate);
            this.Controls.Add(this.button_Triming);
            this.Controls.Add(this.listView_TrimedImages);
            this.Controls.Add(this.pictureBox_OriginImage);
            this.Controls.Add(this.label_Savedir);
            this.Controls.Add(this.button_SaveDir);
            this.Controls.Add(this.label_LoadImage);
            this.Controls.Add(this.button_LoadImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OriginImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LoadImage;
        private System.Windows.Forms.Label label_LoadImage;
        private System.Windows.Forms.Label label_Savedir;
        private System.Windows.Forms.Button button_SaveDir;
        private System.Windows.Forms.PictureBox pictureBox_OriginImage;
        private System.Windows.Forms.ListView listView_TrimedImages;
        private System.Windows.Forms.Button button_Triming;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button_ListUpdate;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Debug;
    }
}

