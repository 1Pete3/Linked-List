namespace nodes
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNode1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNode2 = new System.Windows.Forms.Label();
            this.labelNode3 = new System.Windows.Forms.Label();
            this.labelNode4 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Linked Lists";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNode1
            // 
            this.labelNode1.AutoSize = true;
            this.labelNode1.Location = new System.Drawing.Point(12, 63);
            this.labelNode1.Name = "labelNode1";
            this.labelNode1.Size = new System.Drawing.Size(45, 13);
            this.labelNode1.TabIndex = 1;
            this.labelNode1.Text = "Node 1:";
            this.labelNode1.Click += new System.EventHandler(this.labelNode1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelNode2
            // 
            this.labelNode2.AutoSize = true;
            this.labelNode2.Location = new System.Drawing.Point(12, 102);
            this.labelNode2.Name = "labelNode2";
            this.labelNode2.Size = new System.Drawing.Size(45, 13);
            this.labelNode2.TabIndex = 3;
            this.labelNode2.Text = "Node 2:";
            // 
            // labelNode3
            // 
            this.labelNode3.AutoSize = true;
            this.labelNode3.Location = new System.Drawing.Point(12, 141);
            this.labelNode3.Name = "labelNode3";
            this.labelNode3.Size = new System.Drawing.Size(45, 13);
            this.labelNode3.TabIndex = 4;
            this.labelNode3.Text = "Node 3:";
            // 
            // labelNode4
            // 
            this.labelNode4.AutoSize = true;
            this.labelNode4.Location = new System.Drawing.Point(12, 180);
            this.labelNode4.Name = "labelNode4";
            this.labelNode4.Size = new System.Drawing.Size(45, 13);
            this.labelNode4.TabIndex = 5;
            this.labelNode4.Text = "Node 4:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(56, 218);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(129, 23);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(88, 176);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 20);
            this.textBox4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 278);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelNode4);
            this.Controls.Add(this.labelNode3);
            this.Controls.Add(this.labelNode2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNode1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linked List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNode1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNode2;
        private System.Windows.Forms.Label labelNode3;
        private System.Windows.Forms.Label labelNode4;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

