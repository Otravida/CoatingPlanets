namespace CoatingPlanets
{
    partial class DataForm
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
            this.updateItem_Button = new System.Windows.Forms.Button();
            this.partsTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.addItem_Button = new System.Windows.Forms.Button();
            this.deleteItem_Button = new System.Windows.Forms.Button();
            this.shape_Box = new System.Windows.Forms.ComboBox();
            this.coating_Box = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.majorDimension_Text = new System.Windows.Forms.TextBox();
            this.minorDimension_Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.partNumber_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.partsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // updateItem_Button
            // 
            this.updateItem_Button.Enabled = false;
            this.updateItem_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItem_Button.Location = new System.Drawing.Point(613, 455);
            this.updateItem_Button.Name = "updateItem_Button";
            this.updateItem_Button.Size = new System.Drawing.Size(140, 44);
            this.updateItem_Button.TabIndex = 11;
            this.updateItem_Button.Text = "Update Item";
            this.updateItem_Button.UseVisualStyleBackColor = true;
            // 
            // partsTab
            // 
            this.partsTab.Controls.Add(this.tabPage1);
            this.partsTab.Controls.Add(this.tabPage2);
            this.partsTab.Location = new System.Drawing.Point(16, 11);
            this.partsTab.Name = "partsTab";
            this.partsTab.SelectedIndex = 0;
            this.partsTab.Size = new System.Drawing.Size(438, 492);
            this.partsTab.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(430, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Record";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 454);
            this.dataGridView1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(430, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Record";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(419, 454);
            this.dataGridView2.TabIndex = 12;
            // 
            // addItem_Button
            // 
            this.addItem_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem_Button.Location = new System.Drawing.Point(613, 408);
            this.addItem_Button.Name = "addItem_Button";
            this.addItem_Button.Size = new System.Drawing.Size(140, 41);
            this.addItem_Button.TabIndex = 0;
            this.addItem_Button.Text = "Add Item";
            this.addItem_Button.UseVisualStyleBackColor = true;
            this.addItem_Button.Click += new System.EventHandler(this.addItem_Button_Click);
            // 
            // deleteItem_Button
            // 
            this.deleteItem_Button.Enabled = false;
            this.deleteItem_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItem_Button.Location = new System.Drawing.Point(464, 455);
            this.deleteItem_Button.Name = "deleteItem_Button";
            this.deleteItem_Button.Size = new System.Drawing.Size(143, 44);
            this.deleteItem_Button.TabIndex = 12;
            this.deleteItem_Button.Text = "Delete Item";
            this.deleteItem_Button.UseVisualStyleBackColor = true;
            // 
            // shape_Box
            // 
            this.shape_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shape_Box.FormattingEnabled = true;
            this.shape_Box.Location = new System.Drawing.Point(618, 69);
            this.shape_Box.Name = "shape_Box";
            this.shape_Box.Size = new System.Drawing.Size(132, 32);
            this.shape_Box.TabIndex = 27;
            // 
            // coating_Box
            // 
            this.coating_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coating_Box.FormattingEnabled = true;
            this.coating_Box.Location = new System.Drawing.Point(618, 177);
            this.coating_Box.Name = "coating_Box";
            this.coating_Box.Size = new System.Drawing.Size(132, 32);
            this.coating_Box.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(460, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 24);
            this.label11.TabIndex = 25;
            this.label11.Text = "Shape";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Part Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(460, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Minor Dimension";
            // 
            // majorDimension_Text
            // 
            this.majorDimension_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorDimension_Text.Location = new System.Drawing.Point(618, 107);
            this.majorDimension_Text.Name = "majorDimension_Text";
            this.majorDimension_Text.Size = new System.Drawing.Size(132, 29);
            this.majorDimension_Text.TabIndex = 23;
            // 
            // minorDimension_Text
            // 
            this.minorDimension_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minorDimension_Text.Location = new System.Drawing.Point(618, 142);
            this.minorDimension_Text.Name = "minorDimension_Text";
            this.minorDimension_Text.Size = new System.Drawing.Size(132, 29);
            this.minorDimension_Text.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(460, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Coating Type";
            // 
            // partNumber_Text
            // 
            this.partNumber_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNumber_Text.Location = new System.Drawing.Point(618, 34);
            this.partNumber_Text.Name = "partNumber_Text";
            this.partNumber_Text.Size = new System.Drawing.Size(132, 29);
            this.partNumber_Text.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Major Dimension";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 520);
            this.Controls.Add(this.shape_Box);
            this.Controls.Add(this.coating_Box);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.majorDimension_Text);
            this.Controls.Add(this.minorDimension_Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.partNumber_Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteItem_Button);
            this.Controls.Add(this.partsTab);
            this.Controls.Add(this.updateItem_Button);
            this.Controls.Add(this.addItem_Button);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.partsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button updateItem_Button;
        private System.Windows.Forms.TabControl partsTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addItem_Button;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button deleteItem_Button;
        private System.Windows.Forms.ComboBox shape_Box;
        private System.Windows.Forms.ComboBox coating_Box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox majorDimension_Text;
        private System.Windows.Forms.TextBox minorDimension_Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox partNumber_Text;
        private System.Windows.Forms.Label label3;
    }
}