namespace OtoGaleriProjem;

partial class AracForm
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
        if (disposing && (components != null))
        {
            components.Dispose();
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
        label1 = new Label();
        txtMarka = new TextBox();
        txtModel = new TextBox();
        label2 = new Label();
        numYil = new NumericUpDown();
        label3 = new Label();
        numFiyat = new NumericUpDown();
        label4 = new Label();
        txtRenk = new TextBox();
        label5 = new Label();
        numKm = new NumericUpDown();
        label6 = new Label();
        txtAciklama = new TextBox();
        label7 = new Label();
        txtResim = new TextBox();
        label8 = new Label();
        btnResimSec = new Button();
        btnKaydet = new Button();
        btnIptal = new Button();
        ((System.ComponentModel.ISupportInitialize)numYil).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numFiyat).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numKm).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(26, 25);
        label1.Name = "label1";
        label1.Size = new Size(52, 20);
        label1.TabIndex = 0;
        label1.Text = "Marka";
        // 
        // txtMarka
        // 
        txtMarka.Location = new Point(120, 22);
        txtMarka.Name = "txtMarka";
        txtMarka.PlaceholderText = "Örn: Ford";
        txtMarka.Size = new Size(250, 27);
        txtMarka.TabIndex = 1;
        // 
        // txtModel
        // 
        txtModel.Location = new Point(120, 62);
        txtModel.Name = "txtModel";
        txtModel.PlaceholderText = "Örn: Focus";
        txtModel.Size = new Size(250, 27);
        txtModel.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(26, 65);
        label2.Name = "label2";
        label2.Size = new Size(49, 20);
        label2.TabIndex = 2;
        label2.Text = "Model";
        // 
        // numYil
        // 
        numYil.Location = new Point(120, 102);
        numYil.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
        numYil.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
        numYil.Name = "numYil";
        numYil.Size = new Size(120, 27);
        numYil.TabIndex = 5;
        numYil.Value = new decimal(new int[] { 2015, 0, 0, 0 });
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(26, 104);
        label3.Name = "label3";
        label3.Size = new Size(24, 20);
        label3.TabIndex = 4;
        label3.Text = "Yıl";
        // 
        // numFiyat
        // 
        numFiyat.DecimalPlaces = 2;
        numFiyat.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
        numFiyat.Location = new Point(120, 142);
        numFiyat.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        numFiyat.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
        numFiyat.Name = "numFiyat";
        numFiyat.Size = new Size(200, 27);
        numFiyat.TabIndex = 7;
        numFiyat.ThousandsSeparator = true;
        numFiyat.Value = new decimal(new int[] { 1000, 0, 0, 0 });
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(26, 144);
        label4.Name = "label4";
        label4.Size = new Size(38, 20);
        label4.TabIndex = 6;
        label4.Text = "Fiyat";
        // 
        // txtRenk
        // 
        txtRenk.Location = new Point(120, 182);
        txtRenk.Name = "txtRenk";
        txtRenk.PlaceholderText = "Örn: Kırmızı";
        txtRenk.Size = new Size(200, 27);
        txtRenk.TabIndex = 9;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(26, 185);
        label5.Name = "label5";
        label5.Size = new Size(41, 20);
        label5.TabIndex = 8;
        label5.Text = "Renk";
        // 
        // numKm
        // 
        numKm.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
        numKm.Location = new Point(120, 222);
        numKm.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        numKm.Name = "numKm";
        numKm.Size = new Size(200, 27);
        numKm.TabIndex = 11;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(26, 224);
        label6.Name = "label6";
        label6.Size = new Size(30, 20);
        label6.TabIndex = 10;
        label6.Text = "KM";
        // 
        // txtAciklama
        // 
        txtAciklama.Location = new Point(120, 262);
        txtAciklama.Multiline = true;
        txtAciklama.Name = "txtAciklama";
        txtAciklama.PlaceholderText = "Araç hakkında kısa not ekleyin";
        txtAciklama.ScrollBars = ScrollBars.Vertical;
        txtAciklama.Size = new Size(360, 96);
        txtAciklama.TabIndex = 13;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(26, 265);
        label7.Name = "label7";
        label7.Size = new Size(66, 20);
        label7.TabIndex = 12;
        label7.Text = "Açıklama";
        // 
        // txtResim
        // 
        txtResim.Location = new Point(120, 374);
        txtResim.Name = "txtResim";
        txtResim.PlaceholderText = "Resim dosyası seçin";
        txtResim.Size = new Size(299, 27);
        txtResim.TabIndex = 14;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(26, 377);
        label8.Name = "label8";
        label8.Size = new Size(80, 20);
        label8.TabIndex = 15;
        label8.Text = "Resim yolu";
        // 
        // btnResimSec
        // 
        btnResimSec.Location = new Point(425, 373);
        btnResimSec.Name = "btnResimSec";
        btnResimSec.Size = new Size(55, 29);
        btnResimSec.TabIndex = 16;
        btnResimSec.Text = "...";
        btnResimSec.UseVisualStyleBackColor = true;
        btnResimSec.Click += btnResimSec_Click;
        // 
        // btnKaydet
        // 
        btnKaydet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnKaydet.BackColor = Color.FromArgb(230, 242, 255);
        btnKaydet.FlatAppearance.BorderColor = Color.LightSteelBlue;
        btnKaydet.FlatStyle = FlatStyle.Flat;
        btnKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnKaydet.Location = new Point(296, 425);
        btnKaydet.Name = "btnKaydet";
        btnKaydet.Size = new Size(94, 34);
        btnKaydet.TabIndex = 17;
        btnKaydet.Text = "Kaydet";
        btnKaydet.UseVisualStyleBackColor = false;
        btnKaydet.Click += btnKaydet_Click;
        // 
        // btnIptal
        // 
        btnIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnIptal.Location = new Point(396, 425);
        btnIptal.Name = "btnIptal";
        btnIptal.Size = new Size(94, 34);
        btnIptal.TabIndex = 18;
        btnIptal.Text = "İptal";
        btnIptal.UseVisualStyleBackColor = true;
        btnIptal.Click += btnIptal_Click;
        // 
        // AracForm
        // 
        AcceptButton = btnKaydet;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnIptal;
        ClientSize = new Size(519, 471);
        Controls.Add(btnIptal);
        Controls.Add(btnKaydet);
        Controls.Add(btnResimSec);
        Controls.Add(label8);
        Controls.Add(txtResim);
        Controls.Add(txtAciklama);
        Controls.Add(label7);
        Controls.Add(numKm);
        Controls.Add(label6);
        Controls.Add(txtRenk);
        Controls.Add(label5);
        Controls.Add(numFiyat);
        Controls.Add(label4);
        Controls.Add(numYil);
        Controls.Add(label3);
        Controls.Add(txtModel);
        Controls.Add(label2);
        Controls.Add(txtMarka);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AracForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Araç";
        ((System.ComponentModel.ISupportInitialize)numYil).EndInit();
        ((System.ComponentModel.ISupportInitialize)numFiyat).EndInit();
        ((System.ComponentModel.ISupportInitialize)numKm).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtMarka;
    private TextBox txtModel;
    private Label label2;
    private NumericUpDown numYil;
    private Label label3;
    private NumericUpDown numFiyat;
    private Label label4;
    private TextBox txtRenk;
    private Label label5;
    private NumericUpDown numKm;
    private Label label6;
    private TextBox txtAciklama;
    private Label label7;
    private TextBox txtResim;
    private Label label8;
    private Button btnResimSec;
    private Button btnKaydet;
    private Button btnIptal;
}
