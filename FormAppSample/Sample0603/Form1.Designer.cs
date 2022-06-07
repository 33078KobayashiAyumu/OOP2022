
namespace Sample0603 {
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
            this.btPush = new System.Windows.Forms.Button();
            this.tbsuu2 = new System.Windows.Forms.TextBox();
            this.ans = new System.Windows.Forms.TextBox();
            this.tbsuu1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.suu1 = new System.Windows.Forms.NumericUpDown();
            this.suu2 = new System.Windows.Forms.NumericUpDown();
            this.n_ans = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_ans)).BeginInit();
            this.SuspendLayout();
            // 
            // btPush
            // 
            this.btPush.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPush.Location = new System.Drawing.Point(214, 205);
            this.btPush.Name = "btPush";
            this.btPush.Size = new System.Drawing.Size(96, 45);
            this.btPush.TabIndex = 0;
            this.btPush.Text = "けいさん";
            this.btPush.UseVisualStyleBackColor = true;
            this.btPush.Click += new System.EventHandler(this.btPush_Click);
            // 
            // tbsuu2
            // 
            this.tbsuu2.BackColor = System.Drawing.SystemColors.Window;
            this.tbsuu2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbsuu2.Location = new System.Drawing.Point(192, 66);
            this.tbsuu2.Name = "tbsuu2";
            this.tbsuu2.Size = new System.Drawing.Size(57, 19);
            this.tbsuu2.TabIndex = 1;
            this.tbsuu2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ans
            // 
            this.ans.BackColor = System.Drawing.SystemColors.Window;
            this.ans.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ans.Location = new System.Drawing.Point(342, 66);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(57, 19);
            this.ans.TabIndex = 1;
            this.ans.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbsuu1
            // 
            this.tbsuu1.BackColor = System.Drawing.SystemColors.Window;
            this.tbsuu1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbsuu1.Location = new System.Drawing.Point(61, 66);
            this.tbsuu1.Name = "tbsuu1";
            this.tbsuu1.Size = new System.Drawing.Size(57, 19);
            this.tbsuu1.TabIndex = 1;
            this.tbsuu1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(146, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(282, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "＝";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // suu1
            // 
            this.suu1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.suu1.Location = new System.Drawing.Point(61, 117);
            this.suu1.Name = "suu1";
            this.suu1.Size = new System.Drawing.Size(57, 26);
            this.suu1.TabIndex = 3;
            // 
            // suu2
            // 
            this.suu2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.suu2.Location = new System.Drawing.Point(192, 117);
            this.suu2.Name = "suu2";
            this.suu2.Size = new System.Drawing.Size(57, 26);
            this.suu2.TabIndex = 3;
            // 
            // n_ans
            // 
            this.n_ans.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.n_ans.Location = new System.Drawing.Point(342, 117);
            this.n_ans.Name = "n_ans";
            this.n_ans.Size = new System.Drawing.Size(57, 26);
            this.n_ans.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(146, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "+";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(282, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "＝";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 340);
            this.Controls.Add(this.n_ans);
            this.Controls.Add(this.suu2);
            this.Controls.Add(this.suu1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.tbsuu1);
            this.Controls.Add(this.tbsuu2);
            this.Controls.Add(this.btPush);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_ans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPush;
        private System.Windows.Forms.TextBox tbsuu2;
        private System.Windows.Forms.TextBox ans;
        private System.Windows.Forms.TextBox tbsuu1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown suu1;
        private System.Windows.Forms.NumericUpDown suu2;
        private System.Windows.Forms.NumericUpDown n_ans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

