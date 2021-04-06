
namespace Kakkulator_1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.IpTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaskTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NetworkAddressTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BroadcastTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstUsefullTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LastUsefullTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Ip0octet1 = new System.Windows.Forms.NumericUpDown();
            this.Ip0octet2 = new System.Windows.Forms.NumericUpDown();
            this.Ip0octet3 = new System.Windows.Forms.NumericUpDown();
            this.Ip0octet4 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.CidrTextBox = new System.Windows.Forms.NumericUpDown();
            this.Button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ip0octet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ip0octet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ip0octet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ip0octet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CidrTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IpTextBox
            // 
            this.IpTextBox.Location = new System.Drawing.Point(145, 136);
            this.IpTextBox.Mask = "###\\.###\\.###\\.###";
            this.IpTextBox.Name = "IpTextBox";
            this.IpTextBox.Size = new System.Drawing.Size(100, 20);
            this.IpTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adres IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maska";
            // 
            // MaskTextBox
            // 
            this.MaskTextBox.Location = new System.Drawing.Point(145, 174);
            this.MaskTextBox.Mask = "###\\.###\\.###\\.###";
            this.MaskTextBox.Name = "MaskTextBox";
            this.MaskTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaskTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 21;
            // 
            // NetworkAddressTextBox
            // 
            this.NetworkAddressTextBox.Location = new System.Drawing.Point(145, 211);
            this.NetworkAddressTextBox.Mask = "###\\.###\\.###\\.###";
            this.NetworkAddressTextBox.Name = "NetworkAddressTextBox";
            this.NetworkAddressTextBox.ReadOnly = true;
            this.NetworkAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.NetworkAddressTextBox.TabIndex = 4;
            this.NetworkAddressTextBox.Text = "000000000000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 209);
            this.button1.TabIndex = 6;
            this.button1.Text = "Policz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CalculateIP);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adres Rozgłoszeniowy";
            // 
            // BroadcastTextBox
            // 
            this.BroadcastTextBox.Location = new System.Drawing.Point(145, 249);
            this.BroadcastTextBox.Mask = "###\\.###\\.###\\.###";
            this.BroadcastTextBox.Name = "BroadcastTextBox";
            this.BroadcastTextBox.ReadOnly = true;
            this.BroadcastTextBox.Size = new System.Drawing.Size(100, 20);
            this.BroadcastTextBox.TabIndex = 7;
            this.BroadcastTextBox.Text = "000000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "pierwszy użyteczny adres";
            // 
            // FirstUsefullTextBox
            // 
            this.FirstUsefullTextBox.Location = new System.Drawing.Point(145, 287);
            this.FirstUsefullTextBox.Mask = "###\\.###\\.###\\.###";
            this.FirstUsefullTextBox.Name = "FirstUsefullTextBox";
            this.FirstUsefullTextBox.ReadOnly = true;
            this.FirstUsefullTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstUsefullTextBox.TabIndex = 9;
            this.FirstUsefullTextBox.Text = "000000000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ostatni użyteczny adres";
            // 
            // LastUsefullTextBox
            // 
            this.LastUsefullTextBox.Location = new System.Drawing.Point(145, 325);
            this.LastUsefullTextBox.Mask = "###\\.###\\.###\\.###";
            this.LastUsefullTextBox.Name = "LastUsefullTextBox";
            this.LastUsefullTextBox.ReadOnly = true;
            this.LastUsefullTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastUsefullTextBox.TabIndex = 11;
            this.LastUsefullTextBox.Text = "000000000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Adres IP";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Ip0octet1
            // 
            this.Ip0octet1.Location = new System.Drawing.Point(75, 84);
            this.Ip0octet1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Ip0octet1.Name = "Ip0octet1";
            this.Ip0octet1.Size = new System.Drawing.Size(38, 20);
            this.Ip0octet1.TabIndex = 14;
            this.Ip0octet1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // Ip0octet2
            // 
            this.Ip0octet2.Location = new System.Drawing.Point(119, 84);
            this.Ip0octet2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Ip0octet2.Name = "Ip0octet2";
            this.Ip0octet2.Size = new System.Drawing.Size(38, 20);
            this.Ip0octet2.TabIndex = 15;
            this.Ip0octet2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // Ip0octet3
            // 
            this.Ip0octet3.Location = new System.Drawing.Point(163, 84);
            this.Ip0octet3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Ip0octet3.Name = "Ip0octet3";
            this.Ip0octet3.Size = new System.Drawing.Size(38, 20);
            this.Ip0octet3.TabIndex = 16;
            this.Ip0octet3.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // Ip0octet4
            // 
            this.Ip0octet4.Location = new System.Drawing.Point(207, 84);
            this.Ip0octet4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Ip0octet4.Name = "Ip0octet4";
            this.Ip0octet4.Size = new System.Drawing.Size(38, 20);
            this.Ip0octet4.TabIndex = 17;
            this.Ip0octet4.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Maska";
            // 
            // CidrTextBox
            // 
            this.CidrTextBox.Location = new System.Drawing.Point(312, 84);
            this.CidrTextBox.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.CidrTextBox.Name = "CidrTextBox";
            this.CidrTextBox.Size = new System.Drawing.Size(38, 20);
            this.CidrTextBox.TabIndex = 19;
            this.CidrTextBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(362, 83);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(71, 19);
            this.Button.TabIndex = 20;
            this.Button.Text = "Button";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Buttonix);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Adres Sieci";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 370);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.CidrTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Ip0octet4);
            this.Controls.Add(this.Ip0octet3);
            this.Controls.Add(this.Ip0octet2);
            this.Controls.Add(this.Ip0octet1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LastUsefullTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FirstUsefullTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BroadcastTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NetworkAddressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaskTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Ip0octet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ip0octet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ip0octet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ip0octet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CidrTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox IpTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MaskTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox NetworkAddressTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox BroadcastTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox FirstUsefullTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox LastUsefullTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Ip0octet1;
        private System.Windows.Forms.NumericUpDown Ip0octet2;
        private System.Windows.Forms.NumericUpDown Ip0octet3;
        private System.Windows.Forms.NumericUpDown Ip0octet4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CidrTextBox;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label label9;
    }
}

