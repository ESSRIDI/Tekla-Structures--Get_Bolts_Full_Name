namespace GetBoltLength
{
    partial class Form_bolt
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
            this.bolts_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bolts_btn
            // 
            this.bolts_btn.Location = new System.Drawing.Point(594, 331);
            this.bolts_btn.Name = "bolts_btn";
            this.bolts_btn.Size = new System.Drawing.Size(160, 61);
            this.bolts_btn.TabIndex = 1;
            this.bolts_btn.Text = "show bolts list";
            this.bolts_btn.UseVisualStyleBackColor = true;
            this.bolts_btn.Click += new System.EventHandler(this.bolts_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(358, 233);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form_bolt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bolts_btn);
            this.Name = "Form_bolt";
            this.Text = "List all bolts";
            this.Load += new System.EventHandler(this.Form_bolt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bolts_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

