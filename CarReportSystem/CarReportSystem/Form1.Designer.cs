﻿
namespace CarReportSystem {
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
            this.cmbRec = new System.Windows.Forms.ComboBox();
            this.cmbCarName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbT = new System.Windows.Forms.CheckBox();
            this.cbN = new System.Windows.Forms.CheckBox();
            this.cbH = new System.Windows.Forms.CheckBox();
            this.cbS = new System.Windows.Forms.CheckBox();
            this.cbFC = new System.Windows.Forms.CheckBox();
            this.cbAther = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btArOpen = new System.Windows.Forms.Button();
            this.btArSave = new System.Windows.Forms.Button();
            this.dgvCarReportSys = new System.Windows.Forms.DataGridView();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btImgOpen = new System.Windows.Forms.Button();
            this.btimgDelete = new System.Windows.Forms.Button();
            this.pbBox = new System.Windows.Forms.PictureBox();
            this.btFix = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReportSys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRec
            // 
            this.cmbRec.FormattingEnabled = true;
            this.cmbRec.Location = new System.Drawing.Point(160, 73);
            this.cmbRec.Name = "cmbRec";
            this.cmbRec.Size = new System.Drawing.Size(200, 20);
            this.cmbRec.TabIndex = 0;
            // 
            // cmbCarName
            // 
            this.cmbCarName.FormattingEnabled = true;
            this.cmbCarName.Location = new System.Drawing.Point(160, 171);
            this.cmbCarName.Name = "cmbCarName";
            this.cmbCarName.Size = new System.Drawing.Size(200, 20);
            this.cmbCarName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(79, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "記録者：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(79, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "車名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(78, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "日付：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(79, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "メーカー：";
            // 
            // cbT
            // 
            this.cbT.AutoSize = true;
            this.cbT.Location = new System.Drawing.Point(160, 129);
            this.cbT.Name = "cbT";
            this.cbT.Size = new System.Drawing.Size(48, 16);
            this.cbT.TabIndex = 2;
            this.cbT.Text = "トヨタ";
            this.cbT.UseVisualStyleBackColor = true;
            // 
            // cbN
            // 
            this.cbN.AutoSize = true;
            this.cbN.Location = new System.Drawing.Point(214, 129);
            this.cbN.Name = "cbN";
            this.cbN.Size = new System.Drawing.Size(48, 16);
            this.cbN.TabIndex = 2;
            this.cbN.Text = "日産";
            this.cbN.UseVisualStyleBackColor = true;
            // 
            // cbH
            // 
            this.cbH.AutoSize = true;
            this.cbH.Location = new System.Drawing.Point(268, 129);
            this.cbH.Name = "cbH";
            this.cbH.Size = new System.Drawing.Size(52, 16);
            this.cbH.TabIndex = 2;
            this.cbH.Text = "ホンダ";
            this.cbH.UseVisualStyleBackColor = true;
            // 
            // cbS
            // 
            this.cbS.AutoSize = true;
            this.cbS.Location = new System.Drawing.Point(326, 129);
            this.cbS.Name = "cbS";
            this.cbS.Size = new System.Drawing.Size(53, 16);
            this.cbS.TabIndex = 2;
            this.cbS.Text = "スバル";
            this.cbS.UseVisualStyleBackColor = true;
            // 
            // cbFC
            // 
            this.cbFC.AutoSize = true;
            this.cbFC.Location = new System.Drawing.Point(385, 129);
            this.cbFC.Name = "cbFC";
            this.cbFC.Size = new System.Drawing.Size(60, 16);
            this.cbFC.TabIndex = 2;
            this.cbFC.Text = "外国車";
            this.cbFC.UseVisualStyleBackColor = true;
            // 
            // cbAther
            // 
            this.cbAther.AutoSize = true;
            this.cbAther.Location = new System.Drawing.Point(451, 129);
            this.cbAther.Name = "cbAther";
            this.cbAther.Size = new System.Drawing.Size(55, 16);
            this.cbAther.TabIndex = 2;
            this.cbAther.Text = "その他";
            this.cbAther.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(78, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "レポート：";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(160, 29);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 19);
            this.dtp.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(78, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "記事一覧：";
            // 
            // btArOpen
            // 
            this.btArOpen.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btArOpen.Location = new System.Drawing.Point(80, 448);
            this.btArOpen.Name = "btArOpen";
            this.btArOpen.Size = new System.Drawing.Size(75, 23);
            this.btArOpen.TabIndex = 4;
            this.btArOpen.Text = "開く";
            this.btArOpen.UseVisualStyleBackColor = true;
            // 
            // btArSave
            // 
            this.btArSave.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btArSave.Location = new System.Drawing.Point(79, 477);
            this.btArSave.Name = "btArSave";
            this.btArSave.Size = new System.Drawing.Size(75, 23);
            this.btArSave.TabIndex = 4;
            this.btArSave.Text = "保存";
            this.btArSave.UseVisualStyleBackColor = true;
            // 
            // dgvCarReportSys
            // 
            this.dgvCarReportSys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarReportSys.Location = new System.Drawing.Point(160, 403);
            this.dgvCarReportSys.Name = "dgvCarReportSys";
            this.dgvCarReportSys.RowTemplate.Height = 21;
            this.dgvCarReportSys.Size = new System.Drawing.Size(789, 255);
            this.dgvCarReportSys.TabIndex = 5;
            this.dgvCarReportSys.Click += new System.EventHandler(this.dgv_Click);
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(160, 220);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(405, 144);
            this.txtReport.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(660, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "画像：";
            // 
            // btImgOpen
            // 
            this.btImgOpen.Location = new System.Drawing.Point(729, 71);
            this.btImgOpen.Name = "btImgOpen";
            this.btImgOpen.Size = new System.Drawing.Size(75, 23);
            this.btImgOpen.TabIndex = 4;
            this.btImgOpen.Text = "開く";
            this.btImgOpen.UseVisualStyleBackColor = true;
            // 
            // btimgDelete
            // 
            this.btimgDelete.Location = new System.Drawing.Point(826, 71);
            this.btimgDelete.Name = "btimgDelete";
            this.btimgDelete.Size = new System.Drawing.Size(75, 23);
            this.btimgDelete.TabIndex = 4;
            this.btimgDelete.Text = "削除";
            this.btimgDelete.UseVisualStyleBackColor = true;
            // 
            // pbBox
            // 
            this.pbBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbBox.Location = new System.Drawing.Point(587, 100);
            this.pbBox.Name = "pbBox";
            this.pbBox.Size = new System.Drawing.Size(362, 244);
            this.pbBox.TabIndex = 7;
            this.pbBox.TabStop = false;
            // 
            // btFix
            // 
            this.btFix.Location = new System.Drawing.Point(729, 365);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(75, 23);
            this.btFix.TabIndex = 4;
            this.btFix.Text = "修正";
            this.btFix.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(826, 365);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(630, 365);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEnd
            // 
            this.btEnd.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btEnd.Location = new System.Drawing.Point(79, 635);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(75, 23);
            this.btEnd.TabIndex = 4;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 672);
            this.Controls.Add(this.pbBox);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.dgvCarReportSys);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btArSave);
            this.Controls.Add(this.btImgOpen);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btFix);
            this.Controls.Add(this.btimgDelete);
            this.Controls.Add(this.btArOpen);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cbAther);
            this.Controls.Add(this.cbFC);
            this.Controls.Add(this.cbS);
            this.Controls.Add(this.cbH);
            this.Controls.Add(this.cbN);
            this.Controls.Add(this.cbT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCarName);
            this.Controls.Add(this.cmbRec);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReportSys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRec;
        private System.Windows.Forms.ComboBox cmbCarName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbT;
        private System.Windows.Forms.CheckBox cbN;
        private System.Windows.Forms.CheckBox cbH;
        private System.Windows.Forms.CheckBox cbS;
        private System.Windows.Forms.CheckBox cbFC;
        private System.Windows.Forms.CheckBox cbAther;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btArOpen;
        private System.Windows.Forms.Button btArSave;
        private System.Windows.Forms.DataGridView dgvCarReportSys;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btImgOpen;
        private System.Windows.Forms.Button btimgDelete;
        private System.Windows.Forms.PictureBox pbBox;
        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEnd;
    }
}

