
namespace LogInForm1
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_gtype = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_sopnoid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_uemail = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "gType";
            // 
            // label_gtype
            // 
            this.label_gtype.AutoSize = true;
            this.label_gtype.Location = new System.Drawing.Point(154, 17);
            this.label_gtype.Name = "label_gtype";
            this.label_gtype.Size = new System.Drawing.Size(35, 13);
            this.label_gtype.TabIndex = 1;
            this.label_gtype.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "sopnoid";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_sopnoid
            // 
            this.label_sopnoid.AutoSize = true;
            this.label_sopnoid.Location = new System.Drawing.Point(154, 63);
            this.label_sopnoid.Name = "label_sopnoid";
            this.label_sopnoid.Size = new System.Drawing.Size(35, 13);
            this.label_sopnoid.TabIndex = 3;
            this.label_sopnoid.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "uemail";
            // 
            // label_uemail
            // 
            this.label_uemail.AutoSize = true;
            this.label_uemail.Location = new System.Drawing.Point(154, 114);
            this.label_uemail.Name = "label_uemail";
            this.label_uemail.Size = new System.Drawing.Size(35, 13);
            this.label_uemail.TabIndex = 5;
            this.label_uemail.Text = "label4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 289);
            this.dataGridView1.TabIndex = 6;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_uemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_sopnoid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_gtype);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_gtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_sopnoid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_uemail;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}