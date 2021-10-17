﻿
namespace VideoClubManagement.UI.Genre
{
    partial class genreForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.genreDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.idLabel = new System.Windows.Forms.Label();
            this.statusCheckbox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lastUpdateDateLabel = new System.Windows.Forms.Label();
            this.createdDateLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.searchTxt);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 82);
            this.panel1.TabIndex = 0;
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(21, 27);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(271, 20);
            this.searchTxt.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(320, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(52, 50);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.genreDataGridView);
            this.panel2.Location = new System.Drawing.Point(12, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 211);
            this.panel2.TabIndex = 1;
            // 
            // genreDataGridView
            // 
            this.genreDataGridView.AllowUserToAddRows = false;
            this.genreDataGridView.AllowUserToDeleteRows = false;
            this.genreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreDataGridView.Location = new System.Drawing.Point(4, 4);
            this.genreDataGridView.Name = "genreDataGridView";
            this.genreDataGridView.ReadOnly = true;
            this.genreDataGridView.Size = new System.Drawing.Size(393, 200);
            this.genreDataGridView.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.idLabel);
            this.panel3.Controls.Add(this.statusCheckbox);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lastUpdateDateLabel);
            this.panel3.Controls.Add(this.createdDateLabel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.descriptionTxt);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.nameTxt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(13, 345);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 347);
            this.panel3.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(158, 160);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(41, 13);
            this.idLabel.TabIndex = 15;
            this.idLabel.Text = "label10";
            // 
            // statusCheckbox
            // 
            this.statusCheckbox.AutoSize = true;
            this.statusCheckbox.Location = new System.Drawing.Point(158, 201);
            this.statusCheckbox.Name = "statusCheckbox";
            this.statusCheckbox.Size = new System.Drawing.Size(80, 17);
            this.statusCheckbox.TabIndex = 14;
            this.statusCheckbox.Text = "Esta Activo";
            this.statusCheckbox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Estado";
            // 
            // lastUpdateDateLabel
            // 
            this.lastUpdateDateLabel.AutoSize = true;
            this.lastUpdateDateLabel.Location = new System.Drawing.Point(158, 298);
            this.lastUpdateDateLabel.Name = "lastUpdateDateLabel";
            this.lastUpdateDateLabel.Size = new System.Drawing.Size(35, 13);
            this.lastUpdateDateLabel.TabIndex = 11;
            this.lastUpdateDateLabel.Text = "label8";
            // 
            // createdDateLabel
            // 
            this.createdDateLabel.AutoSize = true;
            this.createdDateLabel.Location = new System.Drawing.Point(158, 250);
            this.createdDateLabel.Name = "createdDateLabel";
            this.createdDateLabel.Size = new System.Drawing.Size(35, 13);
            this.createdDateLabel.TabIndex = 10;
            this.createdDateLabel.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ultima modificación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de creación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Id";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(161, 106);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(219, 20);
            this.descriptionTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(158, 55);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(133, 20);
            this.nameTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de géneros";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.backButton);
            this.panel4.Controls.Add(this.deleteButton);
            this.panel4.Controls.Add(this.updateButton);
            this.panel4.Controls.Add(this.addButton);
            this.panel4.Location = new System.Drawing.Point(46, 716);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(430, 82);
            this.panel4.TabIndex = 2;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(350, 14);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(63, 50);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Retornar";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Location = new System.Drawing.Point(247, 14);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(66, 50);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Elimar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton.Location = new System.Drawing.Point(137, 14);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(66, 50);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Actualizar";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Location = new System.Drawing.Point(21, 14);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(66, 50);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // genreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 820);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "genreForm";
            this.Text = "genreForm";
            this.Load += new System.EventHandler(this.genreForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView genreDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lastUpdateDateLabel;
        private System.Windows.Forms.Label createdDateLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.CheckBox statusCheckbox;
        private System.Windows.Forms.Button backButton;
    }
}