using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11_HCG
{
    class NhietDo
    {
        public float x;

        public NhietDo(float x)
        {
            if (x < 0 || x > 50)
                throw new Exception("Nhiệt độ phải nằm trong khoảng [0;50].Vui lòng nhập lại!!!");
            else
                this.x = x;
        } 
        public float tinhNhietDoLanh()
        {
            if (x >= 0 && x <= 10)
            {
                if (x >= 0 && x <= 5)
                    return 1;
                else
                    return (10 - x) / 5;
            }
            else return 0;   
        }
        public float tinhNhietDoMat()
        {
            if (x > 10 && x <= 20)
            {
                if (x > 10 && x <= 15)
                    return (10 - x) / 5;
                else
                    return (20 - x) / 5;
            }
            else return 0;     
        }
        public float tinhNhietDoAmAp()
        {
            if (x > 20 && x <= 30)
            {
                if (x > 20 && x <= 25)
                    return (x - 20) / 5;
                else
                    return (30 - x) / 5;
            }
            else return 0;
            
        }
        public float tinhNhietDoNong()
        {
            if (x > 30)
            {
                if (x > 30 && x < 35)
                    return (x - 30)/ 5;
                else
                    return 1;
            }
            else return 0; 
        }
    }
}
