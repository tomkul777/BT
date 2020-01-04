namespace BT
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
            this.btComboBox = new System.Windows.Forms.ComboBox();
            this.btScan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btSendFile = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUnpair = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btComboBox
            // 
            this.btComboBox.FormattingEnabled = true;
            this.btComboBox.Location = new System.Drawing.Point(148, 30);
            this.btComboBox.Name = "btComboBox";
            this.btComboBox.Size = new System.Drawing.Size(239, 28);
            this.btComboBox.TabIndex = 0;
            // 
            // btScan
            // 
            this.btScan.Location = new System.Drawing.Point(456, 21);
            this.btScan.Name = "btScan";
            this.btScan.Size = new System.Drawing.Size(176, 44);
            this.btScan.TabIndex = 1;
            this.btScan.Text = "Skanuj urzadzenia";
            this.btScan.UseVisualStyleBackColor = true;
            this.btScan.Click += new System.EventHandler(this.btScan_onClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(66, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(482, 282);
            this.dataGridView1.TabIndex = 2;
            // 
            // btSendFile
            // 
            this.btSendFile.Location = new System.Drawing.Point(613, 240);
            this.btSendFile.Name = "btSendFile";
            this.btSendFile.Size = new System.Drawing.Size(122, 35);
            this.btSendFile.TabIndex = 3;
            this.btSendFile.Text = "Wyslij plik";
            this.btSendFile.UseVisualStyleBackColor = true;
            this.btSendFile.Click += new System.EventHandler(this.SendFile);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(613, 121);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(122, 35);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Polacz";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.Connect);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nazwa";
            this.Column1.Name = "Column1";
            this.Column1.Width = 135;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Adres MAC";
            this.Column2.Name = "Column2";
            this.Column2.Width = 135;
            // 
            // btnUnpair
            // 
            this.btnUnpair.Location = new System.Drawing.Point(613, 324);
            this.btnUnpair.Name = "btnUnpair";
            this.btnUnpair.Size = new System.Drawing.Size(122, 79);
            this.btnUnpair.TabIndex = 5;
            this.btnUnpair.Text = "Odparuj wszystkie urzadzenia";
            this.btnUnpair.UseVisualStyleBackColor = true;
            this.btnUnpair.Click += new System.EventHandler(this.Unpair);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(613, 162);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(122, 35);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Rozlacz";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.Disconnect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnUnpair);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btSendFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btScan);
            this.Controls.Add(this.btComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox btComboBox;
        private System.Windows.Forms.Button btScan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btSendFile;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnUnpair;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

