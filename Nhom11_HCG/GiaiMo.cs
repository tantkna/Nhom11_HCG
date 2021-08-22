using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11_HCG
{
    class GiaiMo
    {
        private float h;
        private float a;
        private float b;
        private float m2;
        private float m1;
        public float H { get => h; set => h = value; }
        public float A { get => a; set => a = value; }
        public float B { get => b; set => b = value; }
        public float M2 { get => m2; set => m2 = value; }
        public float M1 { get => m1; set => m1 = value; }
        public GiaiMo()
        {
        }
        public  float tinhTuSo()
        {
            return H / 6 * (3 * M2 * M2 - 3 * M1 * M1 + B * B - A * A + 3 * M2 * B + 3 * M1 * A);
        }
        public float tinhMauSo()
        {
            return H / 2 * (2 * M2 - 2 * M1 + A + B);
        }
        public void thoiGianTuoiNgan()
        {
            A = 0;
            M1 = 0;
            B = H * 10;
            M2 = 20 - B;
        }
        public void thoiGianTuoiTrungBinh()
        {
            A = 10 * H;
            M1 = 20 + A;
            B = 10 * H;
            M2 = 40 - B;   
        }
        public void thoiGianTuoiLau()
        {
            A = H * 10;
            M1 = 40 + A;
            B = 0;
            M2 = 60;
        }
    }
}
