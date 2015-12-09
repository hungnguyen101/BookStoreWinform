using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreWinform
{
    class OrderModel
    {
        public long MaHD { get; set; }
        public string KhachHang { get; set; }
        public string NgayTao { get; set; }
        public bool TinhTrang { get; set; }
    }
}
