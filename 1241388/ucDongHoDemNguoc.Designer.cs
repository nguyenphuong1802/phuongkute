namespace _1241388
{
    partial class ucDongHoDemNguoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelGiay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPhut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelGiay
            // 
            this.labelGiay.AutoSize = true;
            this.labelGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiay.ForeColor = System.Drawing.Color.Red;
            this.labelGiay.Location = new System.Drawing.Point(100, 13);
            this.labelGiay.Margin = new System.Windows.Forms.Padding(0);
            this.labelGiay.Name = "labelGiay";
            this.labelGiay.Size = new System.Drawing.Size(36, 25);
            this.labelGiay.TabIndex = 12;
            this.labelGiay.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(86, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = ":";
            // 
            // labelPhut
            // 
            this.labelPhut.AutoSize = true;
            this.labelPhut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhut.ForeColor = System.Drawing.Color.Red;
            this.labelPhut.Location = new System.Drawing.Point(56, 13);
            this.labelPhut.Margin = new System.Windows.Forms.Padding(0);
            this.labelPhut.Name = "labelPhut";
            this.labelPhut.Size = new System.Drawing.Size(36, 25);
            this.labelPhut.TabIndex = 10;
            this.labelPhut.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(42, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = ":";
            // 
            // labelGio
            // 
            this.labelGio.AutoSize = true;
            this.labelGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGio.ForeColor = System.Drawing.Color.Red;
            this.labelGio.Location = new System.Drawing.Point(13, 13);
            this.labelGio.Margin = new System.Windows.Forms.Padding(0);
            this.labelGio.Name = "labelGio";
            this.labelGio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGio.Size = new System.Drawing.Size(36, 25);
            this.labelGio.TabIndex = 8;
            this.labelGio.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucDongHoDemNguoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelGiay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPhut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGio);
            this.Name = "ucDongHoDemNguoc";
            this.Size = new System.Drawing.Size(149, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label labelGiay;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label labelPhut;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label labelGio;
        private System.Windows.Forms.Timer timer1;
    }
}
