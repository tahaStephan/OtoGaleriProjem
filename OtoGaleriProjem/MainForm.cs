using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OtoGaleriProjem.Data;
using OtoGaleriProjem.Models;

namespace OtoGaleriProjem;

public partial class MainForm : Form
{
    private OtoGaleriContext _context = null!;

    public MainForm()
    {
        ResetContext();
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        YukleAgac();
    }

    private void YukleAgac()
    {
        treeAraclar.Nodes.Clear();
        var araclar = _context.Araclar
            .AsNoTracking()
            .OrderBy(x => x.Marka)
            .ThenBy(x => x.Model)
            .ToList();

        foreach (var group in araclar.GroupBy(a => a.Marka))
        {
            var markaNode = new TreeNode(group.Key);

            foreach (var arac in group)
            {
                var node = new TreeNode($"{arac.Model} ({arac.Yil})") { Tag = arac.Id };
                markaNode.Nodes.Add(node);
            }

            treeAraclar.Nodes.Add(markaNode);
        }

        treeAraclar.ExpandAll();
        treeAraclar.SelectedNode = treeAraclar.Nodes.Cast<TreeNode>()
            .SelectMany(n => n.Nodes.Cast<TreeNode>())
            .FirstOrDefault();
    }

    private void treeAraclar_AfterSelect(object sender, TreeViewEventArgs e)
    {
        if (e.Node?.Tag is int id)
        {
            var arac = _context.Araclar.AsNoTracking().FirstOrDefault(x => x.Id == id);
            if (arac != null)
            {
                GosterDetay(arac);
                return;
            }
        }

        TemizleDetay();
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
        using var form = new AracForm();
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            ResetContext();
            YukleAgac();
        }
    }

    private void btnDuzenle_Click(object sender, EventArgs e)
    {
        var seciliId = SeciliAracId();
        if (seciliId == null)
        {
            MessageBox.Show("Lütfen bir araç seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var aracVarMi = _context.Araclar.AsNoTracking().Any(x => x.Id == seciliId);
        if (!aracVarMi)
        {
            MessageBox.Show("Araç bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        using var form = new AracForm(seciliId);
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            ResetContext();
            YukleAgac();
            SeciliNodeyuBulVeSec(seciliId.Value);
        }
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
        var seciliId = SeciliAracId();
        if (seciliId == null)
        {
            MessageBox.Show("Silmek için bir araç seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var onay = MessageBox.Show("Seçili aracı silmek istediğinize emin misiniz?", "Silme Onayı",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (onay != DialogResult.Yes)
        {
            return;
        }

        using (var context = new OtoGaleriContext())
        {
            var arac = context.Araclar.FirstOrDefault(x => x.Id == seciliId);
            if (arac != null)
            {
                context.Araclar.Remove(arac);
                context.SaveChanges();
            }
        }

        ResetContext();
        YukleAgac();
        TemizleDetay();
    }

    private void btnYenile_Click(object sender, EventArgs e)
    {
        ResetContext();
        YukleAgac();
    }

    private void GosterDetay(Arac arac)
    {
        lblMarka.Text = arac.Marka;
        lblModel.Text = arac.Model;
        lblYil.Text = arac.Yil.ToString();
        lblFiyat.Text = $"{arac.Fiyat:C0}";
        lblRenk.Text = arac.Renk;
        lblKm.Text = $"{arac.Kilometre:n0} km";
        txtAciklama.Text = arac.Aciklama ?? string.Empty;
        lblResimYolu.Text = string.IsNullOrWhiteSpace(arac.ResimYolu) ? "Seçilmedi" : arac.ResimYolu;

        if (GuvenliResimYolu(arac.ResimYolu))
        {
            try
            {
                pictureArac.Image?.Dispose();
                pictureArac.Image = Image.FromFile(arac.ResimYolu!);
            }
            catch
            {
                pictureArac.Image = null;
            }
        }
        else
        {
            pictureArac.Image?.Dispose();
            pictureArac.Image = null;
        }
    }

    private void TemizleDetay()
    {
        lblMarka.Text = "-";
        lblModel.Text = "-";
        lblYil.Text = "-";
        lblFiyat.Text = "-";
        lblRenk.Text = "-";
        lblKm.Text = "-";
        lblResimYolu.Text = "-";
        txtAciklama.Text = string.Empty;
        pictureArac.Image?.Dispose();
        pictureArac.Image = null;
    }

    private void ResetContext()
    {
        _context?.Dispose();
        _context = new OtoGaleriContext();
    }

    private static bool GuvenliResimYolu(string? yol)
    {
        if (string.IsNullOrWhiteSpace(yol))
        {
            return false;
        }

        try
        {
            var fullPath = Path.GetFullPath(yol);
            return Path.IsPathFullyQualified(fullPath) && File.Exists(fullPath);
        }
        catch
        {
            return false;
        }
    }

    private int? SeciliAracId()
    {
        return treeAraclar.SelectedNode?.Tag as int?;
    }

    private void SeciliNodeyuBulVeSec(int id)
    {
        foreach (TreeNode markaNode in treeAraclar.Nodes)
        {
            foreach (TreeNode modelNode in markaNode.Nodes)
            {
                if (modelNode.Tag is int nodeId && nodeId == id)
                {
                    treeAraclar.SelectedNode = modelNode;
                    modelNode.EnsureVisible();
                    return;
                }
            }
        }
    }
}
