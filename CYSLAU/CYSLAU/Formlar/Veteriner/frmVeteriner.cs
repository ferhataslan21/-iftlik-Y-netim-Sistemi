using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CYSLAU.DB;
using CYSLAU.Genel;

namespace CYSLAU.Formlar.Veteriner
{
    public partial class frmVeteriner : DevExpress.XtraEditors.XtraForm
    {
        VETERINER veteriner;
        object caller;
        public frmVeteriner(VETERINER veteriner=null,object caller=null)
        {
            InitializeComponent();
            this.veteriner = veteriner;
            this.caller = caller;
            if (veteriner == null) FormuTemizle();
            else BilgileriGoster();
        }

        private void FormuTemizle()
        {
            txtVeterinerAdi.Text = string.Empty;
            txtEPosta.Text = string.Empty;
            txtNotlar.Text = string.Empty;
            txtTelefon1.Text = string.Empty;
            txtTelefon2.Text = string.Empty;
            txtAdres.Text = string.Empty;
            txtVeterinerAdi.Focus();
        }

        private void BilgileriGoster()
        {
            txtVeterinerAdi.Text = veteriner.VETERINER_ADI;
            txtEPosta.Text = veteriner.EPOSTA;
            txtNotlar.Text = veteriner.NOTLAR;
            txtTelefon1.Text = veteriner.TELEFON1;
            txtTelefon2.Text = veteriner.TELEFON2;
            txtAdres.Text = veteriner.ADRES;
        }

        private void BilgileriDoldur()
        {
            veteriner.VETERINER_ADI = txtVeterinerAdi.Text;
            veteriner.EPOSTA = txtEPosta.Text;
            veteriner.NOTLAR = txtNotlar.Text;
            veteriner.TELEFON1 = txtTelefon1.Text;
            veteriner.TELEFON2 = txtTelefon2.Text;
            veteriner.ADRES = txtAdres.Text;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormuTemizle();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            try
            {
                if (veteriner==null)
                {
                    veteriner = new VETERINER();
                    BilgileriDoldur();
                    CYS.model.VETERINER.Add(veteriner);
                    CYS.model.SaveChanges();
                    XtraMessageBox.Show("Veteriner kaydı yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    BilgileriDoldur();
                    CYS.model.SaveChanges();
                    XtraMessageBox.Show("Veteriner kaydı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                Guncelle();
                FormuTemizle();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Guncelle()
        {
            if (caller == null) return;

            frmVeterinerList frm = caller as frmVeterinerList;
            if (frm != null) frm.VeterinerleriGetir();
        }
    }
}