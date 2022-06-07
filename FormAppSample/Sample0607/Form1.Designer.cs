
namespace Sample0607 {
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nm1 = new System.Windows.Forms.NumericUpDown();
            this.nm2 = new System.Windows.Forms.NumericUpDown();
            this.nma = new System.Windows.Forms.NumericUpDown();
            this.nmm = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmm)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(184, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "÷";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(360, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "＝";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(226, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(545, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "あまり";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // nm1
            // 
            this.nm1.Location = new System.Drawing.Point(32, 320);
            this.nm1.Name = "nm1";
            this.nm1.Size = new System.Drawing.Size(120, 19);
            this.nm1.TabIndex = 3;
            // 
            // nm2
            // 
            this.nm2.Location = new System.Drawing.Point(244, 320);
            this.nm2.Name = "nm2";
            this.nm2.Size = new System.Drawing.Size(120, 19);
            this.nm2.TabIndex = 3;
            // 
            // nma
            // 
            this.nma.Location = new System.Drawing.Point(410, 320);
            this.nma.Name = "nma";
            this.nma.Size = new System.Drawing.Size(120, 19);
            this.nma.TabIndex = 3;
            // 
            // nmm
            // 
            this.nmm.Location = new System.Drawing.Point(649, 320);
            this.nmm.Name = "nmm";
            this.nmm.Size = new System.Drawing.Size(120, 19);
            this.nmm.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nmm);
            this.Controls.Add(this.nma);
            this.Controls.Add(this.nm2);
            this.Controls.Add(this.nm1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nm1;
        private System.Windows.Forms.NumericUpDown nm2;
        private System.Windows.Forms.NumericUpDown nma;
        private System.Windows.Forms.NumericUpDown nmm;
    }
}

