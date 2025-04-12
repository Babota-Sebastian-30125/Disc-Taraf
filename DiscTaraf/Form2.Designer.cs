namespace DiscTaraf
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listaPiese = new System.Windows.Forms.ListBox();
            this.pozaCover = new System.Windows.Forms.PictureBox();
            this.numePiesasiArtist = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.back_btn = new System.Windows.Forms.Button();
            this.play_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.volume_Control = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pozaCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_Control)).BeginInit();
            this.SuspendLayout();
            // 
            // listaPiese
            // 
            this.listaPiese.BackColor = System.Drawing.Color.Gold;
            this.listaPiese.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaPiese.Dock = System.Windows.Forms.DockStyle.Left;
            this.listaPiese.FormattingEnabled = true;
            this.listaPiese.ItemHeight = 16;
            this.listaPiese.Location = new System.Drawing.Point(0, 0);
            this.listaPiese.Name = "listaPiese";
            this.listaPiese.Size = new System.Drawing.Size(240, 916);
            this.listaPiese.TabIndex = 0;
            this.listaPiese.SelectedIndexChanged += new System.EventHandler(this.listaPiese_SelectedIndexChanged);
            // 
            // pozaCover
            // 
            this.pozaCover.BackColor = System.Drawing.Color.Transparent;
            this.pozaCover.Location = new System.Drawing.Point(767, 159);
            this.pozaCover.Name = "pozaCover";
            this.pozaCover.Size = new System.Drawing.Size(364, 313);
            this.pozaCover.TabIndex = 1;
            this.pozaCover.TabStop = false;
            this.pozaCover.Click += new System.EventHandler(this.pozaCover_Click);
            // 
            // numePiesasiArtist
            // 
            this.numePiesasiArtist.BackColor = System.Drawing.Color.Gold;
            this.numePiesasiArtist.Dock = System.Windows.Forms.DockStyle.Top;
            this.numePiesasiArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numePiesasiArtist.Location = new System.Drawing.Point(240, 0);
            this.numePiesasiArtist.Name = "numePiesasiArtist";
            this.numePiesasiArtist.ReadOnly = true;
            this.numePiesasiArtist.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numePiesasiArtist.Size = new System.Drawing.Size(1415, 39);
            this.numePiesasiArtist.TabIndex = 2;
            this.numePiesasiArtist.Text = "MUZICA SI VOIE BUNA";
            this.numePiesasiArtist.TextChanged += new System.EventHandler(this.numePiesasiArtist_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(475, 712);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(941, 10);
            this.progressBar.TabIndex = 3;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            this.progressBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseClick);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(623, 645);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(210, 61);
            this.back_btn.TabIndex = 4;
            this.back_btn.Text = "<<";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // play_btn
            // 
            this.play_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_btn.Location = new System.Drawing.Point(848, 644);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(210, 61);
            this.play_btn.TabIndex = 5;
            this.play_btn.UseVisualStyleBackColor = true;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(1083, 645);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(210, 61);
            this.next_btn.TabIndex = 6;
            this.next_btn.Text = ">>";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // volume_Control
            // 
            this.volume_Control.Location = new System.Drawing.Point(1447, 666);
            this.volume_Control.Maximum = 100;
            this.volume_Control.Name = "volume_Control";
            this.volume_Control.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.volume_Control.Size = new System.Drawing.Size(196, 56);
            this.volume_Control.TabIndex = 8;
            this.volume_Control.TickFrequency = 10;
            this.volume_Control.Value = 50;
            this.volume_Control.Scroll += new System.EventHandler(this.volume_Control_Scroll);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1655, 916);
            this.Controls.Add(this.volume_Control);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.numePiesasiArtist);
            this.Controls.Add(this.pozaCover);
            this.Controls.Add(this.listaPiese);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pozaCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_Control)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaPiese;
        private System.Windows.Forms.PictureBox pozaCover;
        private System.Windows.Forms.RichTextBox numePiesasiArtist;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.TrackBar volume_Control;
        private System.Windows.Forms.Timer timer1;
    }
}