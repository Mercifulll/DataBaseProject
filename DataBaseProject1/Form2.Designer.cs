namespace DataBaseProject1
{
    partial class Form2
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxID2 = new System.Windows.Forms.TextBox();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.labelAdding = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(169, 321);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 39);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxID2
            // 
            this.textBoxID2.Location = new System.Drawing.Point(169, 148);
            this.textBoxID2.Name = "textBoxID2";
            this.textBoxID2.Size = new System.Drawing.Size(100, 20);
            this.textBoxID2.TabIndex = 1;
            // 
            // textBoxName2
            // 
            this.textBoxName2.Location = new System.Drawing.Point(169, 193);
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(100, 20);
            this.textBoxName2.TabIndex = 2;
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(169, 236);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress2.TabIndex = 3;
            // 
            // labelAdding
            // 
            this.labelAdding.AutoSize = true;
            this.labelAdding.Location = new System.Drawing.Point(189, 74);
            this.labelAdding.Name = "labelAdding";
            this.labelAdding.Size = new System.Drawing.Size(60, 13);
            this.labelAdding.TabIndex = 4;
            this.labelAdding.Text = "Adding row";
            this.labelAdding.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAdding);
            this.Controls.Add(this.textBoxAddress2);
            this.Controls.Add(this.textBoxName2);
            this.Controls.Add(this.textBoxID2);
            this.Controls.Add(this.buttonSave);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxID2;
        private System.Windows.Forms.TextBox textBoxName2;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.Label labelAdding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}