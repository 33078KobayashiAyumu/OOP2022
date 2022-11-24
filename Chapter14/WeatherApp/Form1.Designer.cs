
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherInfo.Location = new System.Drawing.Point(537, 324);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(503, 318);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // cmbArea
            // 
            this.cmbArea.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(49, 369);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(237, 27);
            this.cmbArea.TabIndex = 2;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(46, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "場所";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "日時";
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.tbTime.Location = new System.Drawing.Point(49, 482);
            this.tbTime.Multiline = true;
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(138, 45);
            this.tbTime.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(491, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "概要";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(645, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = " ";
            // 
            // tbToday
            // 
            this.tbToday.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.tbToday.Location = new System.Drawing.Point(589, 59);
            this.tbToday.Multiline = true;
            this.tbToday.Name = "tbToday";
            this.tbToday.Size = new System.Drawing.Size(381, 45);
            this.tbToday.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(645, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = " ";
            // 
            // tbTom
            // 
            this.tbTom.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.tbTom.Location = new System.Drawing.Point(589, 166);
            this.tbTom.Multiline = true;
            this.tbTom.Name = "tbTom";
            this.tbTom.Size = new System.Drawing.Size(381, 45);
            this.tbTom.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(645, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = " ";
            // 
            // tbAfter
            // 
            this.tbAfter.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.tbAfter.Location = new System.Drawing.Point(589, 271);
            this.tbAfter.Multiline = true;
            this.tbAfter.Name = "tbAfter";
            this.tbAfter.Size = new System.Drawing.Size(381, 45);
            this.tbAfter.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.label7.Location = new System.Drawing.Point(224, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "最高気温";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.label8.Location = new System.Drawing.Point(224, 557);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "最低気温";
            // 
            // tbH
            // 
            this.tbH.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.tbH.Location = new System.Drawing.Point(297, 461);
            this.tbH.Multiline = true;
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(91, 41);
            this.tbH.TabIndex = 0;
            // 
            // tbL
            // 
            this.tbL.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.tbL.Location = new System.Drawing.Point(297, 549);
            this.tbL.Multiline = true;
            this.tbL.Name = "tbL";
            this.tbL.Size = new System.Drawing.Size(91, 34);
            this.tbL.TabIndex = 0;
            // 
            // bt北海道
            // 
            this.bt北海道.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt北海道.Location = new System.Drawing.Point(432, 27);
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
            this.bt東北.Location = new System.Drawing.Point(356, 104);
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
            this.bt関東.Location = new System.Drawing.Point(356, 188);
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
            this.bt中部.Location = new System.Drawing.Point(257, 167);
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
            this.bt近畿.Location = new System.Drawing.Point(219, 218);
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
            this.bt四国.Location = new System.Drawing.Point(121, 247);
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
            this.bt中国.Location = new System.Drawing.Point(101, 188);
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
            this.bt沖縄.Location = new System.Drawing.Point(342, 258);
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
            this.bt九州.Location = new System.Drawing.Point(11, 231);
            this.bt九州.Name = "bt九州";
            this.bt九州.Size = new System.Drawing.Size(75, 45);
            this.bt九州.TabIndex = 6;
            this.bt九州.Text = "九州";
            this.bt九州.UseVisualStyleBackColor = false;
            this.bt九州.Click += new System.EventHandler(this.bt九州_Click);
            // 
            // pbAfter
            // 
            this.pbAfter.Location = new System.Drawing.Point(827, 220);
            this.pbAfter.Name = "pbAfter";
            this.pbAfter.Size = new System.Drawing.Size(100, 50);
            this.pbAfter.TabIndex = 7;
            this.pbAfter.TabStop = false;
            // 
            // pbTom
            // 
            this.pbTom.Location = new System.Drawing.Point(827, 110);
            this.pbTom.Name = "pbTom";
            this.pbTom.Size = new System.Drawing.Size(100, 50);
            this.pbTom.TabIndex = 7;
            this.pbTom.TabStop = false;
            // 
            // pbToday
            // 
            this.pbToday.Location = new System.Drawing.Point(827, 3);
            this.pbToday.Name = "pbToday";
            this.pbToday.Size = new System.Drawing.Size(100, 50);
            this.pbToday.TabIndex = 7;
            this.pbToday.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeatherApp.Properties.Resources.aa;
            this.pictureBox1.Location = new System.Drawing.Point(49, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(1127, 280);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(100, 50);
            this.pb4.TabIndex = 7;
            this.pb4.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(1127, 346);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(100, 50);
            this.pb5.TabIndex = 7;
            this.pb5.TabStop = false;
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(1127, 413);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(100, 50);
            this.pb6.TabIndex = 7;
            this.pb6.TabStop = false;
            // 
            // pb7
            // 
            this.pb7.Location = new System.Drawing.Point(1127, 477);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(100, 50);
            this.pb7.TabIndex = 7;
            this.pb7.TabStop = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(1107, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 35);
            this.label9.TabIndex = 3;
            this.label9.Text = "週間天気";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(1127, 77);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 50);
            this.pb1.TabIndex = 7;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(1127, 143);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(100, 50);
            this.pb2.TabIndex = 7;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(1127, 213);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(100, 50);
            this.pb3.TabIndex = 7;
            this.pb3.TabStop = false;
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.tb1.Location = new System.Drawing.Point(111, 554);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(65, 29);
            this.tb1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(8, 557);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "降水確率";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(128, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "1:地方の選択";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(46, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "2:場所の選択";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb1.Location = new System.Drawing.Point(1069, 77);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 15);
            this.lb1.TabIndex = 8;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb2.Location = new System.Drawing.Point(1069, 143);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(0, 15);
            this.lb2.TabIndex = 8;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb3.Location = new System.Drawing.Point(1069, 220);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(0, 15);
            this.lb3.TabIndex = 8;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb4.Location = new System.Drawing.Point(1069, 280);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(0, 15);
            this.lb4.TabIndex = 8;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb5.Location = new System.Drawing.Point(1069, 346);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(0, 15);
            this.lb5.TabIndex = 8;
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb6.Location = new System.Drawing.Point(1069, 413);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(0, 15);
            this.lb6.TabIndex = 8;
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb7.Location = new System.Drawing.Point(1069, 477);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(0, 15);
            this.lb7.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 651);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb7);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pbAfter);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pbTom);
            this.Controls.Add(this.pb1);
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbL);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.tbAfter);
            this.Controls.Add(this.tbTom);
            this.Controls.Add(this.tbToday);
            this.Controls.Add(this.tb1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherInfo;
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
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb7;
    }
}

