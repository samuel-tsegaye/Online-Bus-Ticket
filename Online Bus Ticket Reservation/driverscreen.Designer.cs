namespace Online_Bus_Ticket_Reservation
{
    partial class driverscreen
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sCHESCH1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busDataSet18 = new Online_Bus_Ticket_Reservation.busDataSet18();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sCHE_SCH1TableAdapter = new Online_Bus_Ticket_Reservation.busDataSet18TableAdapters.SCHE_SCH1TableAdapter();
            this.busDataSet23 = new Online_Bus_Ticket_Reservation.busDataSet23();
            this.sCHESCH1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sCHE_SCH1TableAdapter1 = new Online_Bus_Ticket_Reservation.busDataSet23TableAdapters.SCHE_SCH1TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCHESCH1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCHESCH1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(-5, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 418);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Online_Bus_Ticket_Reservation.Properties.Resources._1085688_simple_backgrounds_1920x1200_macbook;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.comboBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(865, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Driver View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sCHESCH1BindingSource
            // 
            this.sCHESCH1BindingSource.DataMember = "SCHE_SCH1";
            this.sCHESCH1BindingSource.DataSource = this.busDataSet18;
            // 
            // busDataSet18
            // 
            this.busDataSet18.DataSetName = "busDataSet18";
            this.busDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(382, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 25);
            this.button5.TabIndex = 81;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(259, 21);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(117, 24);
            this.comboBox4.TabIndex = 76;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sCHE_SCH1TableAdapter
            // 
            this.sCHE_SCH1TableAdapter.ClearBeforeFill = true;
            // 
            // busDataSet23
            // 
            this.busDataSet23.DataSetName = "busDataSet23";
            this.busDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCHESCH1BindingSource1
            // 
            this.sCHESCH1BindingSource1.DataMember = "SCHE_SCH1";
            this.sCHESCH1BindingSource1.DataSource = this.busDataSet23;
            // 
            // sCHE_SCH1TableAdapter1
            // 
            this.sCHE_SCH1TableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(827, 310);
            this.dataGridView1.TabIndex = 82;
            // 
            // driverscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Bus_Ticket_Reservation.Properties.Resources.art_1651577298119_8398;
            this.ClientSize = new System.Drawing.Size(851, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "driverscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "driverscreen";
            this.Load += new System.EventHandler(this.driverscreen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sCHESCH1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCHESCH1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button5;
        private busDataSet18 busDataSet18;
        private System.Windows.Forms.BindingSource sCHESCH1BindingSource;
        private busDataSet18TableAdapters.SCHE_SCH1TableAdapter sCHE_SCH1TableAdapter;
        private busDataSet23 busDataSet23;
        private System.Windows.Forms.BindingSource sCHESCH1BindingSource1;
        private busDataSet23TableAdapters.SCHE_SCH1TableAdapter sCHE_SCH1TableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}