
namespace Tenk
{
    partial class Tenk1
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
            this.panGamePlay = new System.Windows.Forms.Panel();
            this.pbTenk = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.TenkTimer = new System.Windows.Forms.Timer(this.components);
            this.meniRezim = new System.Windows.Forms.ToolStripMenuItem();
            this.meniRezimIzmena = new System.Windows.Forms.ToolStripMenuItem();
            this.meniRezimIgranje = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.lblPodloge = new System.Windows.Forms.Label();
            this.panPodloge = new System.Windows.Forms.Panel();
            this.rbTrava = new System.Windows.Forms.RadioButton();
            this.rbZid = new System.Windows.Forms.RadioButton();
            this.tbBrojPoena = new System.Windows.Forms.TextBox();
            this.btnPocni = new System.Windows.Forms.Button();
            this.panGamePlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTenk)).BeginInit();
            this.menuTop.SuspendLayout();
            this.panPodloge.SuspendLayout();
            this.SuspendLayout();
            // 
            // panGamePlay
            // 
            this.panGamePlay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panGamePlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panGamePlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panGamePlay.Controls.Add(this.pbTenk);
            this.panGamePlay.Location = new System.Drawing.Point(12, 31);
            this.panGamePlay.Name = "panGamePlay";
            this.panGamePlay.Size = new System.Drawing.Size(512, 512);
            this.panGamePlay.TabIndex = 0;
            // 
            // pbTenk
            // 
            this.pbTenk.BackgroundImage = global::Tenk.Properties.Resources.plus;
            this.pbTenk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTenk.Location = new System.Drawing.Point(226, 203);
            this.pbTenk.Name = "pbTenk";
            this.pbTenk.Size = new System.Drawing.Size(30, 30);
            this.pbTenk.TabIndex = 0;
            this.pbTenk.TabStop = false;
            this.pbTenk.Tag = "Tenk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 5;
            this.label1.Tag = "opcije";
            this.label1.Text = "Novčića:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 6;
            this.label2.Tag = "opcije";
            this.label2.Text = "Poena:";
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoeni.Location = new System.Drawing.Point(436, 548);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(16, 16);
            this.lblPoeni.TabIndex = 7;
            this.lblPoeni.Tag = "opcije";
            this.lblPoeni.Text = "0";
            // 
            // TenkTimer
            // 
            this.TenkTimer.Interval = 20;
            this.TenkTimer.Tick += new System.EventHandler(this.TenkTimer_Event);
            // 
            // meniRezim
            // 
            this.meniRezim.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.meniRezim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniRezimIzmena,
            this.meniRezimIgranje});
            this.meniRezim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meniRezim.Name = "meniRezim";
            this.meniRezim.Size = new System.Drawing.Size(57, 21);
            this.meniRezim.Text = "Režim";
            // 
            // meniRezimIzmena
            // 
            this.meniRezimIzmena.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meniRezimIzmena.Name = "meniRezimIzmena";
            this.meniRezimIzmena.Size = new System.Drawing.Size(168, 22);
            this.meniRezimIzmena.Text = "Režim IZMENA";
            this.meniRezimIzmena.Click += new System.EventHandler(this.RezimIzmena_Click);
            // 
            // meniRezimIgranje
            // 
            this.meniRezimIgranje.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meniRezimIgranje.Name = "meniRezimIgranje";
            this.meniRezimIgranje.Size = new System.Drawing.Size(168, 22);
            this.meniRezimIgranje.Text = "Režim IGRANJE";
            this.meniRezimIgranje.Click += new System.EventHandler(this.RezimIgranje_Click);
            // 
            // menuTop
            // 
            this.menuTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniRezim});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(800, 25);
            this.menuTop.TabIndex = 2;
            this.menuTop.Text = "menuStrip1";
            // 
            // lblPodloge
            // 
            this.lblPodloge.AutoSize = true;
            this.lblPodloge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodloge.Location = new System.Drawing.Point(11, 189);
            this.lblPodloge.Name = "lblPodloge";
            this.lblPodloge.Size = new System.Drawing.Size(94, 24);
            this.lblPodloge.TabIndex = 2;
            this.lblPodloge.Text = "Podloge:";
            // 
            // panPodloge
            // 
            this.panPodloge.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panPodloge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPodloge.Controls.Add(this.rbZid);
            this.panPodloge.Controls.Add(this.rbTrava);
            this.panPodloge.Controls.Add(this.lblPodloge);
            this.panPodloge.Location = new System.Drawing.Point(525, 31);
            this.panPodloge.Name = "panPodloge";
            this.panPodloge.Size = new System.Drawing.Size(252, 512);
            this.panPodloge.TabIndex = 1;
            // 
            // rbTrava
            // 
            this.rbTrava.AutoSize = true;
            this.rbTrava.BackColor = System.Drawing.Color.DarkGreen;
            this.rbTrava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTrava.Location = new System.Drawing.Point(171, -1);
            this.rbTrava.Name = "rbTrava";
            this.rbTrava.Padding = new System.Windows.Forms.Padding(5, 116, 52, 118);
            this.rbTrava.Size = new System.Drawing.Size(124, 254);
            this.rbTrava.TabIndex = 3;
            this.rbTrava.TabStop = true;
            this.rbTrava.Text = "Trava";
            this.rbTrava.UseVisualStyleBackColor = false;
            // 
            // rbZid
            // 
            this.rbZid.AutoSize = true;
            this.rbZid.BackColor = System.Drawing.Color.DarkGray;
            this.rbZid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbZid.Location = new System.Drawing.Point(171, 251);
            this.rbZid.Name = "rbZid";
            this.rbZid.Padding = new System.Windows.Forms.Padding(5, 118, 71, 118);
            this.rbZid.Size = new System.Drawing.Size(124, 256);
            this.rbZid.TabIndex = 4;
            this.rbZid.TabStop = true;
            this.rbZid.Text = "Zid";
            this.rbZid.UseVisualStyleBackColor = false;
            // 
            // tbBrojPoena
            // 
            this.tbBrojPoena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBrojPoena.Location = new System.Drawing.Point(275, 545);
            this.tbBrojPoena.Name = "tbBrojPoena";
            this.tbBrojPoena.Size = new System.Drawing.Size(34, 22);
            this.tbBrojPoena.TabIndex = 8;
            this.tbBrojPoena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPocni
            // 
            this.btnPocni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPocni.Location = new System.Drawing.Point(556, 540);
            this.btnPocni.Name = "btnPocni";
            this.btnPocni.Size = new System.Drawing.Size(75, 32);
            this.btnPocni.TabIndex = 1;
            this.btnPocni.Text = "Počni";
            this.btnPocni.UseVisualStyleBackColor = true;
            this.btnPocni.Click += new System.EventHandler(this.btnPocni_Click);
            // 
            // Tenk1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.btnPocni);
            this.Controls.Add(this.tbBrojPoena);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panPodloge);
            this.Controls.Add(this.panGamePlay);
            this.Controls.Add(this.menuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tenk1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tenk";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tenk1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tenk1_KeyUp);
            this.panGamePlay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTenk)).EndInit();
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.panPodloge.ResumeLayout(false);
            this.panPodloge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panGamePlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.Timer TenkTimer;
        private System.Windows.Forms.PictureBox pbTenk;
        private System.Windows.Forms.ToolStripMenuItem meniRezim;
        private System.Windows.Forms.ToolStripMenuItem meniRezimIzmena;
        private System.Windows.Forms.ToolStripMenuItem meniRezimIgranje;
        private System.Windows.Forms.MenuStrip menuTop;
        private System.Windows.Forms.Label lblPodloge;
        private System.Windows.Forms.Panel panPodloge;
        private System.Windows.Forms.RadioButton rbZid;
        private System.Windows.Forms.RadioButton rbTrava;
        private System.Windows.Forms.TextBox tbBrojPoena;
        private System.Windows.Forms.Button btnPocni;
    }
}