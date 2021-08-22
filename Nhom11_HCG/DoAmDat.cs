using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11_HCG
{
    class DoAmDat
    {
        public float y;
        public DoAmDat(float y)
        {   if (y < 0 || y > 10)
                throw new Exception("Độ ẩm phải nằm trong khoảng [0;10].Vui lòng nhập lại!!!");
            else
                this.y = y;
        }
        public float tinhDoAmKho()
        {
            if (y >= 0 && y <= 3.5)
            {
                if (y >= 0 && y <= 2)
                    return 1;
                else
                    return (7 - 2 * y) / 3;
            }
            else return 0;  
        }
        public float tinhDoAmVuaPhai()
        {
            if (y > 3.5 && y <= 7.5)
            {
                if (y > 3.5 && y <= 5.5)
                    return (2 * y - 7) / 4;
                else
                    return (15 - 2 * y) / 4;
            }
            else return 0;
        }
        public float tinhDoAmUot()
        {
            if (y > 7.5 && y <= 10)
                return (2 * y - 15) / 5;
            else return 0;
        }
    }
}
