
namespace Sample0607 {
    partial class けいさん {
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
            this.btRand = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.randMin = new System.Windows.Forms.NumericUpDown();
            this.randMax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randMax)).BeginInit();
            this.SuspendLayout();
            // 
            // btRand
            // 
            this.btRand.Location = new System.Drawing.Point(272, 105);
            this.btRand.Name = "btRand";
            this.btRand.Size = new System.Drawing.Size(98, 50);
            this.btRand.TabIndex = 0;
            this.btRand.Text = "乱数取得";
            this.btRand.UseVisualStyleBackColor = true;
            this.btRand.Click += new System.EventHandler(this.btRund_Click);
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Number.Location = new System.Drawing.Point(68, 114);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(120, 28);
            this.Number.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(89, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "最小";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(89, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "最大";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // randMin
            // 
            this.randMin.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.randMin.Location = new System.Drawing.Point(172, 227);
            this.randMin.Name = "randMin";
            this.randMin.Size = new System.Drawing.Size(120, 28);
            this.randMin.TabIndex = 1;
            this.randMin.ValueChanged += new System.EventHandler(this.randMin_ValueChanged);
            // 
            // randMax
            // 
            this.randMax.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.randMax.Location = new System.Drawing.Point(172, 270);
            this.randMax.Name = "randMax";
            this.randMax.Size = new System.Drawing.Size(120, 28);
            this.randMax.TabIndex = 1;
            // 
            // けいさん
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randMax);
            this.Controls.Add(this.randMin);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.btRand);
            this.MaximizeBox = false;
            this.Name = "けいさん";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRand;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown randMin;
        private System.Windows.Forms.NumericUpDown randMax;
    }
}

