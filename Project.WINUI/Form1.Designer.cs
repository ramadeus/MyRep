namespace Project.WINUI
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
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdateds = new System.Windows.Forms.Button();
            this.btnPassives = new System.Windows.Forms.Button();
            this.dgvSonuc = new System.Windows.Forms.DataGridView();
            this.btnActives = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(189, 270);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(100, 20);
            this.txtBox2.TabIndex = 29;
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(189, 243);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(100, 20);
            this.txtBox1.TabIndex = 28;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(12, 241);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(96, 23);
            this.btnList.TabIndex = 27;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(337, 328);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 24);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDestroy
            // 
            this.btnDestroy.Location = new System.Drawing.Point(337, 299);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(75, 24);
            this.btnDestroy.TabIndex = 24;
            this.btnDestroy.Text = "Kaldır";
            this.btnDestroy.UseVisualStyleBackColor = true;
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(337, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(337, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdateds
            // 
            this.btnUpdateds.Location = new System.Drawing.Point(12, 328);
            this.btnUpdateds.Name = "btnUpdateds";
            this.btnUpdateds.Size = new System.Drawing.Size(96, 23);
            this.btnUpdateds.TabIndex = 22;
            this.btnUpdateds.Text = "Güncellenenler";
            this.btnUpdateds.UseVisualStyleBackColor = true;
            this.btnUpdateds.Click += new System.EventHandler(this.btnUpdateds_Click);
            // 
            // btnPassives
            // 
            this.btnPassives.Location = new System.Drawing.Point(12, 299);
            this.btnPassives.Name = "btnPassives";
            this.btnPassives.Size = new System.Drawing.Size(96, 23);
            this.btnPassives.TabIndex = 21;
            this.btnPassives.Text = "Silinenler";
            this.btnPassives.UseVisualStyleBackColor = true;
            this.btnPassives.Click += new System.EventHandler(this.btnPassives_Click);
            // 
            // dgvSonuc
            // 
            this.dgvSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonuc.Location = new System.Drawing.Point(12, 12);
            this.dgvSonuc.MultiSelect = false;
            this.dgvSonuc.Name = "dgvSonuc";
            this.dgvSonuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSonuc.Size = new System.Drawing.Size(853, 203);
            this.dgvSonuc.TabIndex = 20;
            this.dgvSonuc.Click += new System.EventHandler(this.dgvSonuc_Click);
            // 
            // btnActives
            // 
            this.btnActives.Location = new System.Drawing.Point(12, 270);
            this.btnActives.Name = "btnActives";
            this.btnActives.Size = new System.Drawing.Size(96, 23);
            this.btnActives.TabIndex = 19;
            this.btnActives.Text = "Aktifler";
            this.btnActives.UseVisualStyleBackColor = true;
            this.btnActives.Click += new System.EventHandler(this.btnActives_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 413);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDestroy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdateds);
            this.Controls.Add(this.btnPassives);
            this.Controls.Add(this.dgvSonuc);
            this.Controls.Add(this.btnActives);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdateds;
        private System.Windows.Forms.Button btnPassives;
        private System.Windows.Forms.DataGridView dgvSonuc;
        private System.Windows.Forms.Button btnActives;
    }
}

