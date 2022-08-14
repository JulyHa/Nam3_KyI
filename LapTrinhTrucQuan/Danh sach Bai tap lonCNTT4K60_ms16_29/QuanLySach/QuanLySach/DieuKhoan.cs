using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class DieuKhoan : Form
    {
        public DieuKhoan()
        {
            InitializeComponent();
        }

        private void DieuKhoan_Load(object sender, EventArgs e)
        {
            dk.MaximumSize = panel1.Size;
            dk.Text = "1. Đối tượng được phục vụ:\n" +
                "\nCán bộ, giảng viên, NCS và sinh viên đang công tác và học tập tại Học viện Tài chính." +
                "\n2.Tài liệu và điều kiện mượn tài liệu:" +
                "\n           a.Tài liệu mượn: sách giáo trình và sách tham khảo." +
                "\n           b.Điều kiện mượn tài liệu: Xuất trình thẻ thư viện và làm thủ tục mượn-trả tài liệu theo quy định thông qua Thủ thư." +
                "\n3. Số lượng và thời gian mượn -trả tài liệu:" +
                "\n   +Cán bộ và giảng viên : Được mượn tối đa 5 quyển trong thời hạn 30 ngày,\n sách mượn phải trả đúng hạn đã quy định, nếu quá thời hạn không được mượn sách tiếp." +
                "\nTrường hợp tài liệu mượn bị mất hoặc hư hỏng, phải bồi thường theo nội quy Thư viện." +
                "\n   + Đối với sinh viên:" +
                "\n      -Mỗi môn đang học, sinh viên được mượn từ 1 đến 3 quyển sách tham khảo trong thời gian 30 ngày và sách giáo trình theo chương trình học trong thời gian 90 ngày." +
                "\nNếu môn học được bố trí học suốt học kỳ theo kế hoạch đào tạo, sinh viên phải đến thư viện làm thủ tục xin gia hạn thời gian mượn - trả." +
                "\nSinh viên học lại, thi lại có nhu cầu mượn tài liệu phải làm thủ tục mượn - trả như lần đầu và thời hạn mượn theo lịch học lại, thi lại đã thông báo." +
                "\nSinh viên mượn tài liệu phải trả đúng hạn đã quy định, nếu quá thời hạn không được mượn sách tiếp và phải nộp phí quá hạn 1000 đ / 1 quyển / 1 ngày." +
                "\n      - Tài liệu mượn phải được hoàn trả trước khi sinh viên tốt nghiệp. Nếu không hoàn trả đủ tài liệu, sinh viên không được nhận bằng tốt nghiệp." +
                "\n    -Trường hợp tài liệu mượn bị mất hoặc hư hỏng, phải bồi thường theo nội quy Thư viện.";
         

 
 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
