using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_kiem_tra_02
{
    public partial class frmMainMdi : Form
    {
        public frmMainMdi()
        {
            InitializeComponent();

            // Đăng ký sự kiện Menu Mở Form con
            this.menuDeviceMgr.Click += (s, e) => OpenChildForm<frmDeviceManager>();
            this.menuInventoryMgr.Click += (s, e) => OpenChildForm<frmInventoryManager>();

            // Đăng ký sự kiện Sắp xếp Cửa sổ
            this.menuCascade.Click += (s, e) => LayoutMdi(MdiLayout.Cascade);
            this.menuTileHorizontal.Click += (s, e) => LayoutMdi(MdiLayout.TileHorizontal);
            this.menuTileVertical.Click += (s, e) => LayoutMdi(MdiLayout.TileVertical);

            // Đăng ký sự kiện Hệ thống
            this.menuSyncData.Click += menuSyncData_Click;
            this.menuExit.Click += (s, e) => Application.Exit();
        }

        // Hàm sự kiện Load nằm chuẩn bên trong class
        private void frmMainMdi_Load(object sender, EventArgs e)
        {
            // Tự động khởi tạo nếu cần
        }

        // Hàm hỗ trợ mở Form con MDI (Tránh mở trùng lặp Form đã mở)
        private void OpenChildForm<T>() where T : Form, new()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                    child.Activate(); // Nếu form đã mở thì focus vào form đó
                    return;
                }
            }

            T newChild = new T
            {
                MdiParent = this
            };
            newChild.Show();
        }

        // XỬ LÝ BẤT ĐỒNG BỘ (ASYNC / AWAIT) - GIẢ LẬP ĐỒNG BỘ DỮ LIỆU CƠ SỞ DỮ LIỆU
        private async void menuSyncData_Click(object? sender, EventArgs e)
        {
            menuSyncData.Enabled = false;
            tsProgressBar.Visible = true;
            tsProgressBar.Value = 0;
            lblStatus.Text = "Đang kết nối server và đồng bộ dữ liệu...";

            try
            {
                for (int i = 10; i <= 100; i += 10)
                {
                    await Task.Delay(250); // Tác vụ chạy ngầm bất đồng bộ không gây treo UI
                    tsProgressBar.Value = i;
                    lblStatus.Text = $"Đang đồng bộ dữ liệu... ({i}%)";
                }

                MessageBox.Show("Đồng bộ dữ liệu hệ thống thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblStatus.Text = "Sẵn sàng";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình đồng bộ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Đồng bộ thất bại!";
            }
            finally
            {
                tsProgressBar.Visible = false;
                menuSyncData.Enabled = true;
            }
        }
    }
}