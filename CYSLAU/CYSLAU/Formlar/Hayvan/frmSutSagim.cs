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
using CYSLAU.Genel;
using CYSLAU.DB;

namespace CYSLAU.Formlar.Hayvan
{
    public partial class frmSutSagim : DevExpress.XtraEditors.XtraForm
    {
        DB.HAYVAN hayvan;
        SUT sut;
        public frmSutSagim(DB.HAYVAN hayvan=null)
        {
            InitializeComponent();
            this.hayvan = hayvan;
            txtHayvan.Text = "Devlet No:" + hayvan.DEVLET_NO + ", Boyun No:" + hayvan.BOYUN_NO;
            SutSagimBilgileriniGetir();
            FormuTemizle();
        }

        private void FormuTemizle()
        {
            deSagimTarihi.EditValue = DateTime.Now;
            seSutMiktar.Value = 0;
            sut = null;
        }

        private void SutSagimBilgileriniGetir()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = CYS.model.SUT.Where(x => x.HAYVAN_KAYITNO == hayvan.KAYITNO).ToList();
        }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormuTemizle();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;
            try
            {
                if (sut==null)
                {
                    sut = new SUT();
                    sut.SAGIM_TARIHI = (DateTime)deSagimTarihi.EditValue;
                    sut.ALINAN_SUT = seSutMiktar.Value;
                    sut.HAYVAN_KAYITNO = hayvan.KAYITNO;
                    CYS.model.SUT.Add(sut);
                    CYS.model.SaveChanges();
                    XtraMessageBox.Show("Sağım kaydı yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    sut.SAGIM_TARIHI = (DateTime)deSagimTarihi.EditValue;
                    sut.ALINAN_SUT = seSutMiktar.Value;
                    CYS.model.SaveChanges();
                    XtraMessageBox.Show("Sağım kaydı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                SutSagimBilgileriniGetir();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sut = gridView1.GetFocusedRow() as SUT;
            if (sut == null) return;
            if (XtraMessageBox.Show("Sağım kaydını silmek istediğinizden emin misiniz?","Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                CYS.model.SUT.Remove(sut);
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Sağım kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SutSagimBilgileriniGetir();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}