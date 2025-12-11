using OtoGaleriProjem.Data;
using OtoGaleriProjem.Models;

namespace OtoGaleriProjem;

public partial class AracForm : Form
{
    private readonly OtoGaleriContext _context;
    private readonly Arac _arac;

    public AracForm(OtoGaleriContext context, Arac? arac = null)
    {
        _context = context;
        _arac = arac ?? new Arac();
        InitializeComponent();
        Text = arac == null ? "Araç Ekle" : "Araç Düzenle";
        VeriyiFormaTasiyin();
    }

    private void VeriyiFormaTasiyin()
    {
        txtMarka.Text = _arac.Marka;
        txtModel.Text = _arac.Model;
        txtRenk.Text = _arac.Renk;
        txtAciklama.Text = _arac.Aciklama ?? string.Empty;
        txtResim.Text = _arac.ResimYolu ?? string.Empty;
        numYil.Value = _arac.Yil == 0 ? numYil.Minimum : Math.Min(numYil.Maximum, _arac.Yil);
        numKm.Value = _arac.Kilometre == 0 ? numKm.Minimum : Math.Min(numKm.Maximum, _arac.Kilometre);
        numFiyat.Value = _arac.Fiyat == 0 ? numFiyat.Minimum : Math.Min(numFiyat.Maximum, _arac.Fiyat);
    }

    private bool FormuOku()
    {
        if (string.IsNullOrWhiteSpace(txtMarka.Text) || string.IsNullOrWhiteSpace(txtModel.Text))
        {
            MessageBox.Show("Marka ve model boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        _arac.Marka = txtMarka.Text.Trim();
        _arac.Model = txtModel.Text.Trim();
        _arac.Yil = (int)numYil.Value;
        _arac.Fiyat = numFiyat.Value;
        _arac.Renk = txtRenk.Text.Trim();
        _arac.Kilometre = (int)numKm.Value;
        _arac.Aciklama = string.IsNullOrWhiteSpace(txtAciklama.Text) ? null : txtAciklama.Text.Trim();
        _arac.ResimYolu = string.IsNullOrWhiteSpace(txtResim.Text) ? null : txtResim.Text.Trim();
        return true;
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
        if (!FormuOku())
        {
            return;
        }

        if (_arac.Id == 0)
        {
            _context.Araclar.Add(_arac);
        }

        _context.SaveChanges();
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnIptal_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void btnResimSec_Click(object sender, EventArgs e)
    {
        using var dialog = new OpenFileDialog
        {
            Title = "Araç resmi seçin",
            Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Tüm Dosyalar|*.*"
        };

        if (dialog.ShowDialog(this) == DialogResult.OK)
        {
            txtResim.Text = dialog.FileName;
        }
    }
}
