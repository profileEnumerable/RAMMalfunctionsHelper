using System;
using System.Windows.Forms;

namespace DBWorker
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.crudControl = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.removeButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ramCrud = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.removeMulfinction = new System.Windows.Forms.Button();
            this.mufunctionCrud = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.romoveLink = new System.Windows.Forms.Button();
            this.serviceLinkCrud = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.romoveFixIssue = new System.Windows.Forms.Button();
            this.fixIssueCrud = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ramMalfunctionsContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.crudControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramCrud)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mufunctionCrud)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceLinkCrud)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fixIssueCrud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramMalfunctionsContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(904, 545);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.crudControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CRUD";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // crudControl
            // 
            this.crudControl.Controls.Add(this.tabPage3);
            this.crudControl.Controls.Add(this.tabPage4);
            this.crudControl.Controls.Add(this.tabPage5);
            this.crudControl.Controls.Add(this.tabPage6);
            this.crudControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudControl.Location = new System.Drawing.Point(3, 3);
            this.crudControl.Name = "crudControl";
            this.crudControl.SelectedIndex = 0;
            this.crudControl.Size = new System.Drawing.Size(890, 513);
            this.crudControl.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.removeButton);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.monthCalendar1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.ramCrud);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(882, 487);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "RAM";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(500, 357);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(560, 279);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Memory  \r\nFruquency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prod Date";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(560, 104);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(560, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(560, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description 📝";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 320);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(479, 161);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // ramCrud
            // 
            this.ramCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ramCrud.Location = new System.Drawing.Point(6, 6);
            this.ramCrud.Name = "ramCrud";
            this.ramCrud.Size = new System.Drawing.Size(479, 293);
            this.ramCrud.TabIndex = 0;
            this.ramCrud.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.common_RowEnter);
            this.ramCrud.RowEnter += new DataGridViewCellEventHandler(ramCrud_RowEnter);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.removeMulfinction);
            this.tabPage4.Controls.Add(this.mufunctionCrud);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(882, 487);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Mulfunction";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // removeMulfinction
            // 
            this.removeMulfinction.Location = new System.Drawing.Point(621, 223);
            this.removeMulfinction.Name = "removeMulfinction";
            this.removeMulfinction.Size = new System.Drawing.Size(75, 23);
            this.removeMulfinction.TabIndex = 9;
            this.removeMulfinction.Text = "Remove";
            this.removeMulfinction.UseVisualStyleBackColor = true;
            this.removeMulfinction.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // mufunctionCrud
            // 
            this.mufunctionCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mufunctionCrud.Dock = System.Windows.Forms.DockStyle.Left;
            this.mufunctionCrud.Location = new System.Drawing.Point(3, 3);
            this.mufunctionCrud.Name = "mufunctionCrud";
            this.mufunctionCrud.Size = new System.Drawing.Size(486, 481);
            this.mufunctionCrud.TabIndex = 0;
            this.mufunctionCrud.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.common_RowEnter);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.romoveLink);
            this.tabPage5.Controls.Add(this.serviceLinkCrud);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(882, 487);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "UserServiceLink";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // romoveLink
            // 
            this.romoveLink.Location = new System.Drawing.Point(663, 229);
            this.romoveLink.Name = "romoveLink";
            this.romoveLink.Size = new System.Drawing.Size(75, 23);
            this.romoveLink.TabIndex = 9;
            this.romoveLink.Text = "Remove";
            this.romoveLink.UseVisualStyleBackColor = true;
            this.romoveLink.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // serviceLinkCrud
            // 
            this.serviceLinkCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceLinkCrud.Dock = System.Windows.Forms.DockStyle.Left;
            this.serviceLinkCrud.Location = new System.Drawing.Point(3, 3);
            this.serviceLinkCrud.Name = "serviceLinkCrud";
            this.serviceLinkCrud.Size = new System.Drawing.Size(545, 481);
            this.serviceLinkCrud.TabIndex = 0;
            this.serviceLinkCrud.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.common_RowEnter);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.romoveFixIssue);
            this.tabPage6.Controls.Add(this.fixIssueCrud);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(882, 487);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "FixIssue ⚙";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // romoveFixIssue
            // 
            this.romoveFixIssue.Location = new System.Drawing.Point(669, 241);
            this.romoveFixIssue.Name = "romoveFixIssue";
            this.romoveFixIssue.Size = new System.Drawing.Size(75, 23);
            this.romoveFixIssue.TabIndex = 10;
            this.romoveFixIssue.Text = "Remove";
            this.romoveFixIssue.UseVisualStyleBackColor = true;
            this.romoveFixIssue.Click += new EventHandler(removeButton_Click);
            // 
            // fixIssueCrud
            // 
            this.fixIssueCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fixIssueCrud.Dock = System.Windows.Forms.DockStyle.Left;
            this.fixIssueCrud.Location = new System.Drawing.Point(3, 3);
            this.fixIssueCrud.Name = "fixIssueCrud";
            this.fixIssueCrud.Size = new System.Drawing.Size(483, 481);
            this.fixIssueCrud.TabIndex = 0;
            this.fixIssueCrud.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.common_RowEnter);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ramMalfunctionsContextBindingSource
            // 
            this.ramMalfunctionsContextBindingSource.DataSource = typeof(DBWorker.DAL.EntityFramework.RamMalfunctionsContext);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 545);
            this.Controls.Add(this.tabControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.crudControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramCrud)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mufunctionCrud)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviceLinkCrud)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fixIssueCrud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramMalfunctionsContextBindingSource)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl crudControl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView ramCrud;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView mufunctionCrud;
        private System.Windows.Forms.DataGridView serviceLinkCrud;
        private System.Windows.Forms.DataGridView fixIssueCrud;
        private System.Windows.Forms.BindingSource ramMalfunctionsContextBindingSource;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button removeMulfinction;
        private System.Windows.Forms.Button romoveLink;
        private System.Windows.Forms.Button romoveFixIssue;
    }
}

