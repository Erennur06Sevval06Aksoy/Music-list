namespace Music_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAddBeginning = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonAddEnd = new System.Windows.Forms.Button();
            this.buttonAddMiddle = new System.Windows.Forms.Button();
            this.buttonDeleteBeginning = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDeleteEnd = new System.Windows.Forms.Button();
            this.buttonDeleteMiddle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddBeginning
            // 
            this.buttonAddBeginning.BackColor = System.Drawing.Color.IndianRed;
            this.buttonAddBeginning.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddBeginning.Location = new System.Drawing.Point(15, 12);
            this.buttonAddBeginning.Name = "buttonAddBeginning";
            this.buttonAddBeginning.Size = new System.Drawing.Size(243, 64);
            this.buttonAddBeginning.TabIndex = 0;
            this.buttonAddBeginning.Text = "ADD SONGS TO THE BEGİNNİNG";
            this.buttonAddBeginning.UseVisualStyleBackColor = false;
            this.buttonAddBeginning.Click += new System.EventHandler(this.buttonAddBeginning_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENTER SONG NAME:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Salmon;
            this.textBox1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(233, 432);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Salmon;
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(292, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(227, 305);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // buttonAddEnd
            // 
            this.buttonAddEnd.BackColor = System.Drawing.Color.IndianRed;
            this.buttonAddEnd.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddEnd.Location = new System.Drawing.Point(15, 82);
            this.buttonAddEnd.Name = "buttonAddEnd";
            this.buttonAddEnd.Size = new System.Drawing.Size(243, 64);
            this.buttonAddEnd.TabIndex = 4;
            this.buttonAddEnd.Text = "ADD SONGS TO THE END";
            this.buttonAddEnd.UseVisualStyleBackColor = false;
            this.buttonAddEnd.Click += new System.EventHandler(this.buttonAddEnd_Click);
            // 
            // buttonAddMiddle
            // 
            this.buttonAddMiddle.BackColor = System.Drawing.Color.IndianRed;
            this.buttonAddMiddle.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddMiddle.Location = new System.Drawing.Point(15, 152);
            this.buttonAddMiddle.Name = "buttonAddMiddle";
            this.buttonAddMiddle.Size = new System.Drawing.Size(243, 64);
            this.buttonAddMiddle.TabIndex = 5;
            this.buttonAddMiddle.Text = "ADD SONGS TO THE MİDDLE";
            this.buttonAddMiddle.UseVisualStyleBackColor = false;
            this.buttonAddMiddle.Click += new System.EventHandler(this.buttonAddMiddle_Click);
            // 
            // buttonDeleteBeginning
            // 
            this.buttonDeleteBeginning.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDeleteBeginning.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDeleteBeginning.Location = new System.Drawing.Point(15, 222);
            this.buttonDeleteBeginning.Name = "buttonDeleteBeginning";
            this.buttonDeleteBeginning.Size = new System.Drawing.Size(243, 64);
            this.buttonDeleteBeginning.TabIndex = 6;
            this.buttonDeleteBeginning.Text = "DELETE SONGS TO THE BEGİNNİNG";
            this.buttonDeleteBeginning.UseVisualStyleBackColor = false;
            this.buttonDeleteBeginning.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Salmon;
            this.textBox2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(233, 469);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 30);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "ENTER SONG TİME:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(364, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 64);
            this.button1.TabIndex = 9;
            this.button1.Text = "PRİNT LİST";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDeleteEnd
            // 
            this.buttonDeleteEnd.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDeleteEnd.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDeleteEnd.Location = new System.Drawing.Point(15, 292);
            this.buttonDeleteEnd.Name = "buttonDeleteEnd";
            this.buttonDeleteEnd.Size = new System.Drawing.Size(243, 64);
            this.buttonDeleteEnd.TabIndex = 10;
            this.buttonDeleteEnd.Text = "DELETE SONGS TO THE END";
            this.buttonDeleteEnd.UseVisualStyleBackColor = false;
            this.buttonDeleteEnd.Click += new System.EventHandler(this.buttonDeleteEnd_Click);
            // 
            // buttonDeleteMiddle
            // 
            this.buttonDeleteMiddle.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDeleteMiddle.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDeleteMiddle.Location = new System.Drawing.Point(15, 362);
            this.buttonDeleteMiddle.Name = "buttonDeleteMiddle";
            this.buttonDeleteMiddle.Size = new System.Drawing.Size(243, 64);
            this.buttonDeleteMiddle.TabIndex = 11;
            this.buttonDeleteMiddle.Text = "DELETE SONGS TO THE MİDDLE";
            this.buttonDeleteMiddle.UseVisualStyleBackColor = false;
            this.buttonDeleteMiddle.Click += new System.EventHandler(this.buttonDeleteMiddle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(302, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(406, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(540, 507);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDeleteMiddle);
            this.Controls.Add(this.buttonDeleteEnd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDeleteBeginning);
            this.Controls.Add(this.buttonAddMiddle);
            this.Controls.Add(this.buttonAddEnd);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddBeginning);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddBeginning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonAddEnd;
        private System.Windows.Forms.Button buttonAddMiddle;
        private System.Windows.Forms.Button buttonDeleteBeginning;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDeleteEnd;
        private System.Windows.Forms.Button buttonDeleteMiddle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

