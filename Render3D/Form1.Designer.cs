namespace Render3D
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.templateChoice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fontChoice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exportChoice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textRender = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sizeRender = new System.Windows.Forms.TextBox();
            this.pictureRender = new System.Windows.Forms.PictureBox();
            this.reload = new System.Windows.Forms.Button();
            this.textcolorDialog = new System.Windows.Forms.ColorDialog();
            this.bgcolorDialog = new System.Windows.Forms.ColorDialog();
            this.textcolor = new System.Windows.Forms.Button();
            this.bgcolor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRender)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 111);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(431, 27);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Template:";
            // 
            // templateChoice
            // 
            this.templateChoice.FormattingEnabled = true;
            this.templateChoice.Location = new System.Drawing.Point(15, 25);
            this.templateChoice.Name = "templateChoice";
            this.templateChoice.Size = new System.Drawing.Size(121, 21);
            this.templateChoice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Police:";
            // 
            // fontChoice
            // 
            this.fontChoice.FormattingEnabled = true;
            this.fontChoice.Location = new System.Drawing.Point(142, 25);
            this.fontChoice.Name = "fontChoice";
            this.fontChoice.Size = new System.Drawing.Size(121, 21);
            this.fontChoice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Format image:";
            // 
            // exportChoice
            // 
            this.exportChoice.FormattingEnabled = true;
            this.exportChoice.Location = new System.Drawing.Point(269, 25);
            this.exportChoice.Name = "exportChoice";
            this.exportChoice.Size = new System.Drawing.Size(121, 21);
            this.exportChoice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Texte:";
            // 
            // textRender
            // 
            this.textRender.Location = new System.Drawing.Point(55, 52);
            this.textRender.Name = "textRender";
            this.textRender.Size = new System.Drawing.Size(115, 20);
            this.textRender.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Render!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Taille:";
            // 
            // sizeRender
            // 
            this.sizeRender.Location = new System.Drawing.Point(55, 85);
            this.sizeRender.Name = "sizeRender";
            this.sizeRender.Size = new System.Drawing.Size(34, 20);
            this.sizeRender.TabIndex = 11;
            // 
            // pictureRender
            // 
            this.pictureRender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureRender.Location = new System.Drawing.Point(12, 144);
            this.pictureRender.Name = "pictureRender";
            this.pictureRender.Size = new System.Drawing.Size(431, 402);
            this.pictureRender.TabIndex = 12;
            this.pictureRender.TabStop = false;
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(269, 52);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(133, 23);
            this.reload.TabIndex = 13;
            this.reload.Text = "Actualiser ComboBoxes";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // textcolor
            // 
            this.textcolor.Location = new System.Drawing.Point(239, 52);
            this.textcolor.Name = "textcolor";
            this.textcolor.Size = new System.Drawing.Size(24, 23);
            this.textcolor.TabIndex = 14;
            this.textcolor.UseVisualStyleBackColor = true;
            this.textcolor.Click += new System.EventHandler(this.textcolor_Click);
            // 
            // bgcolor
            // 
            this.bgcolor.Location = new System.Drawing.Point(239, 81);
            this.bgcolor.Name = "bgcolor";
            this.bgcolor.Size = new System.Drawing.Size(24, 23);
            this.bgcolor.TabIndex = 15;
            this.bgcolor.UseVisualStyleBackColor = true;
            this.bgcolor.Click += new System.EventHandler(this.bgcolor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Couleur:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fond:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 558);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bgcolor);
            this.Controls.Add(this.textcolor);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.pictureRender);
            this.Controls.Add(this.sizeRender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textRender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exportChoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fontChoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.templateChoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Render3D Text Xara";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox templateChoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fontChoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox exportChoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textRender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sizeRender;
        private System.Windows.Forms.PictureBox pictureRender;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.ColorDialog textcolorDialog;
        private System.Windows.Forms.ColorDialog bgcolorDialog;
        private System.Windows.Forms.Button textcolor;
        private System.Windows.Forms.Button bgcolor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

    }
}

