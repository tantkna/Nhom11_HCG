using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_HCG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public float MIN(float m1, float m2)
        {
            if (m1 < m2)
                return m1;
            else
                return m2;

        }
        private void btnKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(txtNhietDo.Text.Trim())|| String.IsNullOrEmpty(txtDoAm.Text.Trim()))
                {
                    throw new Exception("Bạn vui lòng nhập đầy đủ thông tin!!");
                }
                else
                {
                    float x = float.Parse(txtNhietDo.Text);
                    float y = float.Parse(txtDoAm.Text);
                    NhietDo nhietDo = new NhietDo(x);
                    DoAmDat doAmDat = new DoAmDat(y);
                    GiaiMo[] arrLuat = new GiaiMo[8];
                    for (int i = 0; i < arrLuat.Length; i++)
                    {
                        arrLuat[i] = new GiaiMo();
                    }
                    //B1:Mờ hóa
                    float mNhietDoLanh = nhietDo.tinhNhietDoLanh();
                    float mNhietDoMat = nhietDo.tinhNhietDoMat();
                    float mNhietDoAmAp = nhietDo.tinhNhietDoAmAp();
                    float mNhietDoNong = nhietDo.tinhNhietDoNong();

                    float mDoAmKho = doAmDat.tinhDoAmKho();
                    float mDoAmVuaPhai = doAmDat.tinhDoAmVuaPhai();
                    float mDoAmUot = doAmDat.tinhDoAmUot();

                    //B2:Lập luận mờ

                    arrLuat[0].H = MIN(mNhietDoLanh, mDoAmUot);
                    arrLuat[1].H = MIN(mNhietDoMat, mDoAmUot);
                    arrLuat[2].H = MIN(mNhietDoNong, mDoAmUot);
                    arrLuat[3].H = MIN(mNhietDoAmAp, mDoAmVuaPhai);
                    arrLuat[4].H = MIN(mNhietDoLanh, mDoAmVuaPhai);
                    arrLuat[5].H = MIN(mNhietDoMat, mDoAmVuaPhai);
                    arrLuat[6].H = MIN(mNhietDoNong, mDoAmKho);
                    arrLuat[7].H = MIN(mNhietDoNong, mDoAmUot);

                    //B3:Giải mờ
                    arrLuat[0].thoiGianTuoiNgan();
                    arrLuat[1].thoiGianTuoiNgan();
                    arrLuat[2].thoiGianTuoiNgan();
                    arrLuat[3].thoiGianTuoiNgan();
                    arrLuat[4].thoiGianTuoiNgan();
                    arrLuat[5].thoiGianTuoiNgan();
                    arrLuat[6].thoiGianTuoiLau();
                    arrLuat[7].thoiGianTuoiNgan();

                    float sumTu = 0;
                    float sumMau = 0;
                    for (int i = 0; i < arrLuat.Length; i++)
                    {
                        sumTu += arrLuat[i].tinhTuSo();
                        sumMau += arrLuat[i].tinhMauSo();
                    }
                    txtThoiGianTuoi.Text = (float)(sumTu / sumMau) + "";
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
