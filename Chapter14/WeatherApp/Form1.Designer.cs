
namespace WeatherApp {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent () {
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbToday = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAfter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbH = new System.Windows.Forms.TextBox();
            this.tbL = new System.Windows.Forms.TextBox();
            this.bt北海道 = new System.Windows.Forms.Button();
            this.bt東北 = new System.Windows.Forms.Button();
            this.bt関東 = new System.Windows.Forms.Button();
            this.bt中部 = new System.Windows.Forms.Button();
            this.bt近畿 = new System.Windows.Forms.Button();
            this.bt四国 = new System.Windows.Forms.Button();
            this.bt中国 = new System.Windows.Forms.Button();
            this.bt沖縄 = new System.Windows.Forms.Button();
            this.bt九州 = new System.Windows.Forms.Button();
            this.pbAfter = new System.Windows.Forms.PictureBox();
            this.pbTom = new System.Windows.Forms.PictureBox();
            this.pbToday = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.tbWeatherInfo.Location = new System.Drawing.Point(12, 173);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(400, 329);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(260, 14);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(134, 39);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // cmbArea
            // 
            this.cmbArea.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(108, 21);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(121, 23);
            this.cmbArea.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "場所";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "日時";
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.tbTime.Location = new System.Drawing.Point(108, 64);
            this.tbTime.Multiline = true;
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(138, 45);
            this.tbTime.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "概要";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(490, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "今日の天気";
            // 
            // tbToday
            // 
            this.tbToday.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.tbToday.Location = new System.Drawing.Point(418, 57);
            this.tbToday.Multiline = true;
            this.tbToday.Name = "tbToday";
            this.tbToday.Size = new System.Drawing.Size(346, 45);
            this.tbToday.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(490, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "明日の天気";
            // 
            // tbTom
            // 
            this.tbTom.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.tbTom.Location = new System.Drawing.Point(418, 156);
            this.tbTom.Multiline = true;
            this.tbTom.Name = "tbTom";
            this.tbTom.Size = new System.Drawing.Size(346, 45);
            this.tbTom.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(490, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "明後日の天気";
            // 
            // tbAfter
            // 
            this.tbAfter.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.tbAfter.Location = new System.Drawing.Point(418, 250);
            this.tbAfter.Multiline = true;
            this.tbAfter.Name = "tbAfter";
            this.tbAfter.Size = new System.Drawing.Size(346, 45);
            this.tbAfter.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.label7.Location = new System.Drawing.Point(828, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "最高気温";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.label8.Location = new System.Drawing.Point(828, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "最低気温";
            // 
            // tbH
            // 
            this.tbH.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.tbH.Location = new System.Drawing.Point(901, 21);
            this.tbH.Multiline = true;
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(91, 45);
            this.tbH.TabIndex = 0;
            // 
            // tbL
            // 
            this.tbL.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.tbL.Location = new System.Drawing.Point(901, 108);
            this.tbL.Multiline = true;
            this.tbL.Name = "tbL";
            this.tbL.Size = new System.Drawing.Size(91, 45);
            this.tbL.TabIndex = 0;
            // 
            // bt北海道
            // 
            this.bt北海道.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt北海道.Location = new System.Drawing.Point(831, 363);
            this.bt北海道.Name = "bt北海道";
            this.bt北海道.Size = new System.Drawing.Size(75, 45);
            this.bt北海道.TabIndex = 6;
            this.bt北海道.Text = "北海道";
            this.bt北海道.UseVisualStyleBackColor = false;
            this.bt北海道.Click += new System.EventHandler(this.bt北海道_Click);
            // 
            // bt東北
            // 
            this.bt東北.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt東北.Location = new System.Drawing.Point(775, 440);
            this.bt東北.Name = "bt東北";
            this.bt東北.Size = new System.Drawing.Size(75, 45);
            this.bt東北.TabIndex = 6;
            this.bt東北.Text = "東北";
            this.bt東北.UseVisualStyleBackColor = false;
            this.bt東北.Click += new System.EventHandler(this.bt東北_Click);
            // 
            // bt関東
            // 
            this.bt関東.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt関東.Location = new System.Drawing.Point(755, 524);
            this.bt関東.Name = "bt関東";
            this.bt関東.Size = new System.Drawing.Size(75, 45);
            this.bt関東.TabIndex = 6;
            this.bt関東.Text = "関東";
            this.bt関東.UseVisualStyleBackColor = false;
            this.bt関東.Click += new System.EventHandler(this.bt関東_Click);
            // 
            // bt中部
            // 
            this.bt中部.BackColor = System.Drawing.Color.LimeGreen;
            this.bt中部.Location = new System.Drawing.Point(638, 481);
            this.bt中部.Name = "bt中部";
            this.bt中部.Size = new System.Drawing.Size(75, 45);
            this.bt中部.TabIndex = 6;
            this.bt中部.Text = "中部";
            this.bt中部.UseVisualStyleBackColor = false;
            this.bt中部.Click += new System.EventHandler(this.bt中部_Click);
            // 
            // bt近畿
            // 
            this.bt近畿.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bt近畿.Location = new System.Drawing.Point(618, 554);
            this.bt近畿.Name = "bt近畿";
            this.bt近畿.Size = new System.Drawing.Size(75, 45);
            this.bt近畿.TabIndex = 6;
            this.bt近畿.Text = "近畿";
            this.bt近畿.UseVisualStyleBackColor = false;
            this.bt近畿.Click += new System.EventHandler(this.bt近畿_Click);
            // 
            // bt四国
            // 
            this.bt四国.BackColor = System.Drawing.Color.Orange;
            this.bt四国.Location = new System.Drawing.Point(520, 583);
            this.bt四国.Name = "bt四国";
            this.bt四国.Size = new System.Drawing.Size(75, 45);
            this.bt四国.TabIndex = 6;
            this.bt四国.Text = "四国";
            this.bt四国.UseVisualStyleBackColor = false;
            this.bt四国.Click += new System.EventHandler(this.bt四国_Click);
            // 
            // bt中国
            // 
            this.bt中国.BackColor = System.Drawing.Color.Yellow;
            this.bt中国.Location = new System.Drawing.Point(500, 501);
            this.bt中国.Name = "bt中国";
            this.bt中国.Size = new System.Drawing.Size(75, 45);
            this.bt中国.TabIndex = 6;
            this.bt中国.Text = "中国";
            this.bt中国.UseVisualStyleBackColor = false;
            this.bt中国.Click += new System.EventHandler(this.bt中国_Click);
            // 
            // bt沖縄
            // 
            this.bt沖縄.BackColor = System.Drawing.Color.HotPink;
            this.bt沖縄.Location = new System.Drawing.Point(741, 594);
            this.bt沖縄.Name = "bt沖縄";
            this.bt沖縄.Size = new System.Drawing.Size(75, 45);
            this.bt沖縄.TabIndex = 6;
            this.bt沖縄.Text = "沖縄";
            this.bt沖縄.UseVisualStyleBackColor = false;
            this.bt沖縄.Click += new System.EventHandler(this.bt沖縄_Click);
            // 
            // bt九州
            // 
            this.bt九州.BackColor = System.Drawing.Color.HotPink;
            this.bt九州.Location = new System.Drawing.Point(410, 567);
            this.bt九州.Name = "bt九州";
            this.bt九州.Size = new System.Drawing.Size(75, 45);
            this.bt九州.TabIndex = 6;
            this.bt九州.Text = "九州";
            this.bt九州.UseVisualStyleBackColor = false;
            this.bt九州.Click += new System.EventHandler(this.bt九州_Click);
            // 
            // pbAfter
            // 
            this.pbAfter.Location = new System.Drawing.Point(1167, 188);
            this.pbAfter.Name = "pbAfter";
            this.pbAfter.Size = new System.Drawing.Size(100, 50);
            this.pbAfter.TabIndex = 7;
            this.pbAfter.TabStop = false;
            // 
            // pbTom
            // 
            this.pbTom.Location = new System.Drawing.Point(1167, 103);
            this.pbTom.Name = "pbTom";
            this.pbTom.Size = new System.Drawing.Size(100, 50);
            this.pbTom.TabIndex = 7;
            this.pbTom.TabStop = false;
            // 
            // pbToday
            // 
            this.pbToday.Location = new System.Drawing.Point(1167, 28);
            this.pbToday.Name = "pbToday";
            this.pbToday.Size = new System.Drawing.Size(100, 50);
            this.pbToday.TabIndex = 7;
            this.pbToday.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeatherApp.Properties.Resources.aa;
            this.pictureBox1.Location = new System.Drawing.Point(442, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(1167, 264);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(100, 50);
            this.pb4.TabIndex = 7;
            this.pb4.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(1167, 341);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(100, 50);
            this.pb5.TabIndex = 7;
            this.pb5.TabStop = false;
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(1167, 435);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(100, 50);
            this.pb6.TabIndex = 7;
            this.pb6.TabStop = false;
            // 
            // pb7
            // 
            this.pb7.Location = new System.Drawing.Point(1167, 524);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(100, 50);
            this.pb7.TabIndex = 7;
            this.pb7.TabStop = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(1067, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 164);
            this.label9.TabIndex = 3;
            this.label9.Text = "週間天気";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 651);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pbAfter);
            this.Controls.Add(this.pbTom);
            this.Controls.Add(this.pbToday);
            this.Controls.Add(this.bt九州);
            this.Controls.Add(this.bt沖縄);
            this.Controls.Add(this.bt中国);
            this.Controls.Add(this.bt四国);
            this.Controls.Add(this.bt近畿);
            this.Controls.Add(this.bt中部);
            this.Controls.Add(this.bt関東);
            this.Controls.Add(this.bt東北);
            this.Controls.Add(this.bt北海道);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.tbL);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.tbAfter);
            this.Controls.Add(this.tbTom);
            this.Controls.Add(this.tbToday);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbWeatherInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "天気予報";
            ((System.ComponentModel.ISupportInitialize)(this.pbAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbToday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAfter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.TextBox tbL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt北海道;
        private System.Windows.Forms.Button bt東北;
        private System.Windows.Forms.Button bt関東;
        private System.Windows.Forms.Button bt中部;
        private System.Windows.Forms.Button bt近畿;
        private System.Windows.Forms.Button bt四国;
        private System.Windows.Forms.Button bt中国;
        private System.Windows.Forms.Button bt沖縄;
        private System.Windows.Forms.Button bt九州;
        private System.Windows.Forms.PictureBox pbToday;
        private System.Windows.Forms.PictureBox pbTom;
        private System.Windows.Forms.PictureBox pbAfter;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.Label label9;
    }
}

