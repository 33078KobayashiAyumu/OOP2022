
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
            this.components = new System.ComponentModel.Container();
            this.cmbRec = new System.Windows.Forms.ComboBox();
            this.cmbCarName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btImgOpen = new System.Windows.Forms.Button();
            this.btimgDelete = new System.Windows.Forms.Button();
            this.pbBox = new System.Windows.Forms.PictureBox();
            this.btFix = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.cbT = new System.Windows.Forms.RadioButton();
            this.cbN = new System.Windows.Forms.RadioButton();
            this.cbH = new System.Windows.Forms.RadioButton();
            this.cbFC = new System.Windows.Forms.RadioButton();
            this.cbS = new System.Windows.Forms.RadioButton();
            this.cbAther = new System.Windows.Forms.RadioButton();
            this.ofdPic = new System.Windows.Forms.OpenFileDialog();
            this.sfdxml = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修正ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.carReportDBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.carReportDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202229DataSet = new CarReportSystem.infosys202229DataSet();
            this.btConnect = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btRelieve = new System.Windows.Forms.Button();
            this.carReportDBTableAdapter = new CarReportSystem.infosys202229DataSetTableAdapters.CarReportDBTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202229DataSetTableAdapters.TableAdapterManager();
            this.btDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202229DataSet)).BeginInit();
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
            this.label6.Location = new System.Drawing.Point(79, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "記事一覧：";
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
            this.btImgOpen.Click += new System.EventHandler(this.btImgOpen_Click);
            // 
            // btimgDelete
            // 
            this.btimgDelete.Location = new System.Drawing.Point(810, 71);
            this.btimgDelete.Name = "btimgDelete";
            this.btimgDelete.Size = new System.Drawing.Size(75, 23);
            this.btimgDelete.TabIndex = 4;
            this.btimgDelete.Text = "削除";
            this.btimgDelete.UseVisualStyleBackColor = true;
            this.btimgDelete.Click += new System.EventHandler(this.btimgDelete_Click);
            // 
            // pbBox
            // 
            this.pbBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbBox.Location = new System.Drawing.Point(590, 91);
            this.pbBox.Name = "pbBox";
            this.pbBox.Size = new System.Drawing.Size(362, 244);
            this.pbBox.TabIndex = 7;
            this.pbBox.TabStop = false;
            // 
            // btFix
            // 
            this.btFix.Enabled = false;
            this.btFix.Location = new System.Drawing.Point(729, 365);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(75, 23);
            this.btFix.TabIndex = 4;
            this.btFix.Text = "修正";
            this.btFix.UseVisualStyleBackColor = true;
            this.btFix.Click += new System.EventHandler(this.btFix_Click);
            // 
            // btAdd
            // 
            this.btAdd.Enabled = false;
            this.btAdd.Location = new System.Drawing.Point(630, 365);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cbT
            // 
            this.cbT.AutoSize = true;
            this.cbT.Location = new System.Drawing.Point(160, 127);
            this.cbT.Name = "cbT";
            this.cbT.Size = new System.Drawing.Size(47, 16);
            this.cbT.TabIndex = 8;
            this.cbT.TabStop = true;
            this.cbT.Text = "トヨタ";
            this.cbT.UseVisualStyleBackColor = true;
            // 
            // cbN
            // 
            this.cbN.AutoSize = true;
            this.cbN.Location = new System.Drawing.Point(213, 127);
            this.cbN.Name = "cbN";
            this.cbN.Size = new System.Drawing.Size(47, 16);
            this.cbN.TabIndex = 8;
            this.cbN.TabStop = true;
            this.cbN.Text = "日産";
            this.cbN.UseVisualStyleBackColor = true;
            // 
            // cbH
            // 
            this.cbH.AutoSize = true;
            this.cbH.Location = new System.Drawing.Point(266, 127);
            this.cbH.Name = "cbH";
            this.cbH.Size = new System.Drawing.Size(51, 16);
            this.cbH.TabIndex = 8;
            this.cbH.TabStop = true;
            this.cbH.Text = "ホンダ";
            this.cbH.UseVisualStyleBackColor = true;
            // 
            // cbFC
            // 
            this.cbFC.AutoSize = true;
            this.cbFC.Location = new System.Drawing.Point(380, 128);
            this.cbFC.Name = "cbFC";
            this.cbFC.Size = new System.Drawing.Size(59, 16);
            this.cbFC.TabIndex = 8;
            this.cbFC.TabStop = true;
            this.cbFC.Text = "外国車";
            this.cbFC.UseVisualStyleBackColor = true;
            // 
            // cbS
            // 
            this.cbS.AutoSize = true;
            this.cbS.Location = new System.Drawing.Point(323, 127);
            this.cbS.Name = "cbS";
            this.cbS.Size = new System.Drawing.Size(52, 16);
            this.cbS.TabIndex = 8;
            this.cbS.TabStop = true;
            this.cbS.Text = "スバル";
            this.cbS.UseVisualStyleBackColor = true;
            // 
            // cbAther
            // 
            this.cbAther.AutoSize = true;
            this.cbAther.Location = new System.Drawing.Point(445, 127);
            this.cbAther.Name = "cbAther";
            this.cbAther.Size = new System.Drawing.Size(54, 16);
            this.cbAther.TabIndex = 8;
            this.cbAther.TabStop = true;
            this.cbAther.Text = "その他";
            this.cbAther.UseVisualStyleBackColor = true;
            // 
            // ofdPic
            // 
            this.ofdPic.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "FIle(F)";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.追加ToolStripMenuItem,
            this.修正ToolStripMenuItem,
            this.終了ToolStripMenuItem,
            this.終了ToolStripMenuItem1});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fileFToolStripMenuItem.Text = "ファイル(F)";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.開くToolStripMenuItem.Text = "データベース接続...";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 追加ToolStripMenuItem
            // 
            this.追加ToolStripMenuItem.Enabled = false;
            this.追加ToolStripMenuItem.Name = "追加ToolStripMenuItem";
            this.追加ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.追加ToolStripMenuItem.Text = "追加...";
            this.追加ToolStripMenuItem.Click += new System.EventHandler(this.追加ToolStripMenuItem_Click);
            // 
            // 修正ToolStripMenuItem
            // 
            this.修正ToolStripMenuItem.Enabled = false;
            this.修正ToolStripMenuItem.Name = "修正ToolStripMenuItem";
            this.修正ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.修正ToolStripMenuItem.Text = "修正...";
            this.修正ToolStripMenuItem.Click += new System.EventHandler(this.修正ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.終了ToolStripMenuItem.Text = "色設定..";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.色設定ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem1
            // 
            this.終了ToolStripMenuItem1.Name = "終了ToolStripMenuItem1";
            this.終了ToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.終了ToolStripMenuItem1.Text = "終了(X)";
            this.終了ToolStripMenuItem1.Click += new System.EventHandler(this.終了ToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(889, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "☆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.a_Click);
            // 
            // carReportDBDataGridView
            // 
            this.carReportDBDataGridView.AllowUserToAddRows = false;
            this.carReportDBDataGridView.AutoGenerateColumns = false;
            this.carReportDBDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.carReportDBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carReportDBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.carReportDBDataGridView.DataSource = this.carReportDBBindingSource;
            this.carReportDBDataGridView.Location = new System.Drawing.Point(12, 499);
            this.carReportDBDataGridView.MultiSelect = false;
            this.carReportDBDataGridView.Name = "carReportDBDataGridView";
            this.carReportDBDataGridView.RowTemplate.Height = 21;
            this.carReportDBDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carReportDBDataGridView.Size = new System.Drawing.Size(792, 243);
            this.carReportDBDataGridView.TabIndex = 27;
            this.carReportDBDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.carReportDBDataGridView_DataError);
            this.carReportDBDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.carReportDBDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Maker";
            this.dataGridViewTextBoxColumn4.HeaderText = "Maker";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CarName";
            this.dataGridViewTextBoxColumn5.HeaderText = "CarName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Report";
            this.dataGridViewTextBoxColumn6.HeaderText = "Report";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // carReportDBBindingSource
            // 
            this.carReportDBBindingSource.DataMember = "CarReportDB";
            this.carReportDBBindingSource.DataSource = this.infosys202229DataSet;
            // 
            // infosys202229DataSet
            // 
            this.infosys202229DataSet.DataSetName = "infosys202229DataSet";
            this.infosys202229DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btConnect.Location = new System.Drawing.Point(810, 499);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(71, 35);
            this.btConnect.TabIndex = 28;
            this.btConnect.Text = "DB";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btSearch
            // 
            this.btSearch.Enabled = false;
            this.btSearch.Location = new System.Drawing.Point(82, 424);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 27);
            this.btSearch.TabIndex = 29;
            this.btSearch.Text = "名前検索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSearch.Location = new System.Drawing.Point(185, 424);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(225, 26);
            this.tbSearch.TabIndex = 30;
            // 
            // btClear
            // 
            this.btClear.Enabled = false;
            this.btClear.Location = new System.Drawing.Point(630, 424);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 26);
            this.btClear.TabIndex = 31;
            this.btClear.Text = "クリア";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btRelieve
            // 
            this.btRelieve.Enabled = false;
            this.btRelieve.Location = new System.Drawing.Point(445, 424);
            this.btRelieve.Name = "btRelieve";
            this.btRelieve.Size = new System.Drawing.Size(75, 26);
            this.btRelieve.TabIndex = 32;
            this.btRelieve.Text = "検索解除";
            this.btRelieve.UseVisualStyleBackColor = true;
            this.btRelieve.Click += new System.EventHandler(this.btRelieve_Click);
            // 
            // carReportDBTableAdapter
            // 
            this.carReportDBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportDBTableAdapter = this.carReportDBTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202229DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btDel
            // 
            this.btDel.Enabled = false;
            this.btDel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDel.ForeColor = System.Drawing.Color.Red;
            this.btDel.Location = new System.Drawing.Point(874, 595);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(52, 44);
            this.btDel.TabIndex = 33;
            this.btDel.Text = "削除";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(972, 829);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btRelieve);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.carReportDBDataGridView);
            this.Controls.Add(this.cbS);
            this.Controls.Add(this.cbAther);
            this.Controls.Add(this.cbFC);
            this.Controls.Add(this.cbH);
            this.Controls.Add(this.cbN);
            this.Controls.Add(this.cbT);
            this.Controls.Add(this.pbBox);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.btImgOpen);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btFix);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btimgDelete);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCarName);
            this.Controls.Add(this.cmbRec);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202229DataSet)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btImgOpen;
        private System.Windows.Forms.Button btimgDelete;
        private System.Windows.Forms.PictureBox pbBox;
        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.RadioButton cbT;
        private System.Windows.Forms.RadioButton cbN;
        private System.Windows.Forms.RadioButton cbH;
        private System.Windows.Forms.RadioButton cbFC;
        private System.Windows.Forms.RadioButton cbS;
        private System.Windows.Forms.RadioButton cbAther;
        private System.Windows.Forms.OpenFileDialog ofdPic;
        private System.Windows.Forms.SaveFileDialog sfdxml;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private infosys202229DataSet infosys202229DataSet;
        private System.Windows.Forms.BindingSource carReportDBBindingSource;
        private infosys202229DataSetTableAdapters.CarReportDBTableAdapter carReportDBTableAdapter;
        private infosys202229DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView carReportDBDataGridView;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btRelieve;
        private System.Windows.Forms.ToolStripMenuItem 追加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修正ToolStripMenuItem;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}

