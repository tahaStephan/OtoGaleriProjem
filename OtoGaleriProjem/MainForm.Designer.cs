namespace OtoGaleriProjem;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
            _context?.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        treeAraclar = new TreeView();
        flowLayoutPanel1 = new FlowLayoutPanel();
        btnEkle = new Button();
        btnDuzenle = new Button();
        btnSil = new Button();
        btnYenile = new Button();
        grpDetay = new GroupBox();
        lblResimYolu = new Label();
        label9 = new Label();
        pictureArac = new PictureBox();
        txtAciklama = new TextBox();
        label8 = new Label();
        lblKm = new Label();
        label6 = new Label();
        lblRenk = new Label();
        label5 = new Label();
        lblFiyat = new Label();
        label4 = new Label();
        lblYil = new Label();
        label3 = new Label();
        lblModel = new Label();
        label2 = new Label();
        lblMarka = new Label();
        label1 = new Label();
        flowLayoutPanel1.SuspendLayout();
        grpDetay.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureArac).BeginInit();
        SuspendLayout();
        // 
        // treeAraclar
        // 
        treeAraclar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        treeAraclar.Location = new Point(12, 12);
        treeAraclar.Name = "treeAraclar";
        treeAraclar.Size = new Size(240, 610);
        treeAraclar.TabIndex = 0;
        treeAraclar.AfterSelect += treeAraclar_AfterSelect;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        flowLayoutPanel1.Controls.Add(btnEkle);
        flowLayoutPanel1.Controls.Add(btnDuzenle);
        flowLayoutPanel1.Controls.Add(btnSil);
        flowLayoutPanel1.Controls.Add(btnYenile);
        flowLayoutPanel1.Location = new Point(258, 12);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(830, 44);
        flowLayoutPanel1.TabIndex = 1;
        // 
        // btnEkle
        // 
        btnEkle.BackColor = Color.FromArgb(230, 242, 255);
        btnEkle.FlatAppearance.BorderColor = Color.LightSteelBlue;
        btnEkle.FlatStyle = FlatStyle.Flat;
        btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnEkle.Location = new Point(3, 3);
        btnEkle.Name = "btnEkle";
        btnEkle.Size = new Size(94, 34);
        btnEkle.TabIndex = 0;
        btnEkle.Text = "Ekle";
        btnEkle.UseVisualStyleBackColor = false;
        btnEkle.Click += btnEkle_Click;
        // 
        // btnDuzenle
        // 
        btnDuzenle.BackColor = Color.FromArgb(230, 242, 255);
        btnDuzenle.FlatAppearance.BorderColor = Color.LightSteelBlue;
        btnDuzenle.FlatStyle = FlatStyle.Flat;
        btnDuzenle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnDuzenle.Location = new Point(103, 3);
        btnDuzenle.Name = "btnDuzenle";
        btnDuzenle.Size = new Size(104, 34);
        btnDuzenle.TabIndex = 1;
        btnDuzenle.Text = "Düzenle";
        btnDuzenle.UseVisualStyleBackColor = false;
        btnDuzenle.Click += btnDuzenle_Click;
        // 
        // btnSil
        // 
        btnSil.BackColor = Color.FromArgb(255, 235, 238);
        btnSil.FlatAppearance.BorderColor = Color.LightCoral;
        btnSil.FlatStyle = FlatStyle.Flat;
        btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnSil.Location = new Point(213, 3);
        btnSil.Name = "btnSil";
        btnSil.Size = new Size(94, 34);
        btnSil.TabIndex = 2;
        btnSil.Text = "Sil";
        btnSil.UseVisualStyleBackColor = false;
        btnSil.Click += btnSil_Click;
        // 
        // btnYenile
        // 
        btnYenile.BackColor = Color.FromArgb(230, 242, 255);
        btnYenile.FlatAppearance.BorderColor = Color.LightSteelBlue;
        btnYenile.FlatStyle = FlatStyle.Flat;
        btnYenile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        btnYenile.Location = new Point(313, 3);
        btnYenile.Name = "btnYenile";
        btnYenile.Size = new Size(94, 34);
        btnYenile.TabIndex = 3;
        btnYenile.Text = "Yenile";
        btnYenile.UseVisualStyleBackColor = false;
        btnYenile.Click += btnYenile_Click;
        // 
        // grpDetay
        // 
        grpDetay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        grpDetay.Controls.Add(lblResimYolu);
        grpDetay.Controls.Add(label9);
        grpDetay.Controls.Add(pictureArac);
        grpDetay.Controls.Add(txtAciklama);
        grpDetay.Controls.Add(label8);
        grpDetay.Controls.Add(lblKm);
        grpDetay.Controls.Add(label6);
        grpDetay.Controls.Add(lblRenk);
        grpDetay.Controls.Add(label5);
        grpDetay.Controls.Add(lblFiyat);
        grpDetay.Controls.Add(label4);
        grpDetay.Controls.Add(lblYil);
        grpDetay.Controls.Add(label3);
        grpDetay.Controls.Add(lblModel);
        grpDetay.Controls.Add(label2);
        grpDetay.Controls.Add(lblMarka);
        grpDetay.Controls.Add(label1);
        grpDetay.Location = new Point(258, 62);
        grpDetay.Name = "grpDetay";
        grpDetay.Size = new Size(830, 560);
        grpDetay.TabIndex = 2;
        grpDetay.TabStop = false;
        grpDetay.Text = "Araç Detayı";
        // 
        // lblResimYolu
        // 
        lblResimYolu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblResimYolu.AutoEllipsis = true;
        lblResimYolu.Location = new Point(104, 227);
        lblResimYolu.Name = "lblResimYolu";
        lblResimYolu.Size = new Size(420, 20);
        lblResimYolu.TabIndex = 16;
        lblResimYolu.Text = "-";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(24, 227);
        label9.Name = "label9";
        label9.Size = new Size(76, 20);
        label9.TabIndex = 15;
        label9.Text = "Resim yolu";
        // 
        // pictureArac
        // 
        pictureArac.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        pictureArac.BorderStyle = BorderStyle.FixedSingle;
        pictureArac.Location = new Point(548, 32);
        pictureArac.Name = "pictureArac";
        pictureArac.Size = new Size(256, 215);
        pictureArac.SizeMode = PictureBoxSizeMode.Zoom;
        pictureArac.TabIndex = 14;
        pictureArac.TabStop = false;
        // 
        // txtAciklama
        // 
        txtAciklama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtAciklama.BackColor = Color.White;
        txtAciklama.Location = new Point(104, 264);
        txtAciklama.Multiline = true;
        txtAciklama.Name = "txtAciklama";
        txtAciklama.ReadOnly = true;
        txtAciklama.ScrollBars = ScrollBars.Vertical;
        txtAciklama.Size = new Size(700, 98);
        txtAciklama.TabIndex = 13;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(24, 267);
        label8.Name = "label8";
        label8.Size = new Size(66, 20);
        label8.TabIndex = 12;
        label8.Text = "Açıklama";
        // 
        // lblKm
        // 
        lblKm.AutoSize = true;
        lblKm.Location = new Point(104, 197);
        lblKm.Name = "lblKm";
        lblKm.Size = new Size(16, 20);
        lblKm.TabIndex = 11;
        lblKm.Text = "-";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(24, 197);
        label6.Name = "label6";
        label6.Size = new Size(30, 20);
        label6.TabIndex = 10;
        label6.Text = "KM";
        // 
        // lblRenk
        // 
        lblRenk.AutoSize = true;
        lblRenk.Location = new Point(104, 167);
        lblRenk.Name = "lblRenk";
        lblRenk.Size = new Size(16, 20);
        lblRenk.TabIndex = 9;
        lblRenk.Text = "-";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(24, 167);
        label5.Name = "label5";
        label5.Size = new Size(41, 20);
        label5.TabIndex = 8;
        label5.Text = "Renk";
        // 
        // lblFiyat
        // 
        lblFiyat.AutoSize = true;
        lblFiyat.Location = new Point(104, 137);
        lblFiyat.Name = "lblFiyat";
        lblFiyat.Size = new Size(16, 20);
        lblFiyat.TabIndex = 7;
        lblFiyat.Text = "-";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(24, 137);
        label4.Name = "label4";
        label4.Size = new Size(38, 20);
        label4.TabIndex = 6;
        label4.Text = "Fiyat";
        // 
        // lblYil
        // 
        lblYil.AutoSize = true;
        lblYil.Location = new Point(104, 107);
        lblYil.Name = "lblYil";
        lblYil.Size = new Size(16, 20);
        lblYil.TabIndex = 5;
        lblYil.Text = "-";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(24, 107);
        label3.Name = "label3";
        label3.Size = new Size(24, 20);
        label3.TabIndex = 4;
        label3.Text = "Yıl";
        // 
        // lblModel
        // 
        lblModel.AutoSize = true;
        lblModel.Location = new Point(104, 77);
        lblModel.Name = "lblModel";
        lblModel.Size = new Size(16, 20);
        lblModel.TabIndex = 3;
        lblModel.Text = "-";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(24, 77);
        label2.Name = "label2";
        label2.Size = new Size(49, 20);
        label2.TabIndex = 2;
        label2.Text = "Model";
        // 
        // lblMarka
        // 
        lblMarka.AutoSize = true;
        lblMarka.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        lblMarka.Location = new Point(101, 38);
        lblMarka.Name = "lblMarka";
        lblMarka.Size = new Size(17, 25);
        lblMarka.TabIndex = 1;
        lblMarka.Text = "-";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(24, 38);
        label1.Name = "label1";
        label1.Size = new Size(66, 25);
        label1.TabIndex = 0;
        label1.Text = "Marka";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1100, 634);
        Controls.Add(grpDetay);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(treeAraclar);
        MinimumSize = new Size(900, 550);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Oto Galeri - Basit CRUD";
        Load += MainForm_Load;
        flowLayoutPanel1.ResumeLayout(false);
        grpDetay.ResumeLayout(false);
        grpDetay.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureArac).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TreeView treeAraclar;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button btnEkle;
    private Button btnDuzenle;
    private Button btnSil;
    private Button btnYenile;
    private GroupBox grpDetay;
    private Label lblKm;
    private Label label6;
    private Label lblRenk;
    private Label label5;
    private Label lblFiyat;
    private Label label4;
    private Label lblYil;
    private Label label3;
    private Label lblModel;
    private Label label2;
    private Label lblMarka;
    private Label label1;
    private TextBox txtAciklama;
    private Label label8;
    private PictureBox pictureArac;
    private Label lblResimYolu;
    private Label label9;
}
