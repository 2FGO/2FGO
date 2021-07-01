
namespace _2FGO
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
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.studentt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("배달의민족 도현", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(17, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "돌아가기";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(301, 270);
            this.txt_Message.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(311, 21);
            this.txt_Message.TabIndex = 3;
            this.txt_Message.TextChanged += new System.EventHandler(this.txt_Message_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("배달의민족 도현", 12F);
            this.button4.Location = new System.Drawing.Point(779, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 36);
            this.button4.TabIndex = 5;
            this.button4.Text = "종료";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // studentt
            // 
            this.studentt.BackColor = System.Drawing.Color.Transparent;
            this.studentt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.studentt.FlatAppearance.BorderSize = 0;
            this.studentt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentt.Font = new System.Drawing.Font("배달의민족 도현", 25F);
            this.studentt.Image = global::_2FGO.Properties.Resources.자습신청하기;
            this.studentt.Location = new System.Drawing.Point(313, 298);
            this.studentt.Name = "studentt";
            this.studentt.Size = new System.Drawing.Size(269, 109);
            this.studentt.TabIndex = 6;
            this.studentt.UseVisualStyleBackColor = false;
            this.studentt.Click += new System.EventHandler(this.studentt_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_2FGO.Properties.Resources._11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 522);
            this.Controls.Add(this.studentt);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button studentt;
    }
}