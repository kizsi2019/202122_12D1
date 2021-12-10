namespace adatbazis
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Azonosító = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mozinév = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filmkód = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 63);
            this.button2.TabIndex = 0;
            this.button2.Text = "Beolvasás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Azonosító,
            this.Mozinév,
            this.Filmkód});
            this.dataGridView2.Location = new System.Drawing.Point(46, 198);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(604, 198);
            this.dataGridView2.TabIndex = 1;
            // 
            // Azonosító
            // 
            this.Azonosító.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Azonosító.HeaderText = "Azonsító";
            this.Azonosító.Name = "Azonosító";
            // 
            // Mozinév
            // 
            this.Mozinév.HeaderText = "Mozinév";
            this.Mozinév.Name = "Mozinév";
            // 
            // Filmkód
            // 
            this.Filmkód.HeaderText = "Filmkód";
            this.Filmkód.Name = "Filmkód";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(654, 413);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Mozi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Azonosító;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mozinév;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filmkód;
    }
}

