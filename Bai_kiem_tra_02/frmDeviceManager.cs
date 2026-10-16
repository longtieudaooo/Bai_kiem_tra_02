using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bai_kiem_tra_02
{
    public partial class frmDeviceManager : Form
    {
        private BindingList<Device> listDevices = new BindingList<Device>();
        private BindingSource deviceBindingSource = new BindingSource();
        private int autoIncrementId = 1;

        public frmDeviceManager()
        {
            InitializeComponent();

            // Gắn sự kiện thủ công cho các Button
            this.btnAdd.Click += btnAdd_Click;
            this.btnUpdate.Click += btnUpdate_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.btnClear.Click += btnClear_Click;
        }

        private void frmDeviceManager_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            InitSampleData();

            deviceBindingSource.DataSource = listDevices;
            dgvDevices.DataSource = deviceBindingSource;

            BindControls();

            if (cboCategory.Items.Count > 0)
                cboCategory.SelectedIndex = 0;
        }

        private void SetupDataGridView()
        {
            dgvDevices.AutoGenerateColumns = false;
            dgvDevices.Columns.Clear();

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DeviceId",
                HeaderText = "Mã TB",
                Width = 80
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DeviceName",
                HeaderText = "Tên thiết bị",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Loại thiết bị",
                Width = 120
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Đơn giá (VNĐ)",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "#,##0" }
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Số lượng tồn",
                Width = 100
            });
        }

        private void InitSampleData()
        {
            listDevices.Add(new Device($"TB{autoIncrementId++:D3}", "iPhone 15 Pro Max", "Điện thoại", 30000000m, 15));
            listDevices.Add(new Device($"TB{autoIncrementId++:D3}", "MacBook Pro M3", "Laptop", 45000000m, 8));
            listDevices.Add(new Device($"TB{autoIncrementId++:D3}", "iPad Air 5", "Máy tính bảng", 16000000m, 20));
        }

        private void BindControls()
        {
            txtDeviceId.DataBindings.Clear();
            txtDeviceName.DataBindings.Clear();
            cboCategory.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            numQuantity.DataBindings.Clear();

            txtDeviceId.DataBindings.Add("Text", deviceBindingSource, "DeviceId", true, DataSourceUpdateMode.Never);
            txtDeviceName.DataBindings.Add("Text", deviceBindingSource, "DeviceName", true, DataSourceUpdateMode.OnPropertyChanged);
            cboCategory.DataBindings.Add("Text", deviceBindingSource, "Category", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPrice.DataBindings.Add("Text", deviceBindingSource, "Price", true, DataSourceUpdateMode.OnPropertyChanged, 0, "#,##0");
            numQuantity.DataBindings.Add("Value", deviceBindingSource, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private bool ValidateInput()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtDeviceName.Text))
            {
                errorProvider1.SetError(txtDeviceName, "Tên thiết bị không được để trống!");
                isValid = false;
            }

            if (cboCategory.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboCategory, "Vui lòng chọn loại thiết bị!");
                isValid = false;
            }

            if (!decimal.TryParse(txtPrice.Text.Replace(",", "").Replace(".", ""), out decimal price) || price < 0)
            {
                errorProvider1.SetError(txtPrice, "Đơn giá phải là số hợp lệ và không âm!");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string newId = $"TB{autoIncrementId++:D3}";
            decimal price = decimal.Parse(txtPrice.Text.Replace(",", "").Replace(".", ""));
            string category = cboCategory.SelectedItem?.ToString() ?? "";

            Device newDevice = new Device(newId, txtDeviceName.Text.Trim(), category, price, (int)numQuantity.Value);
            listDevices.Add(newDevice);

            MessageBox.Show("Thêm mới thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear_Click(sender, e);
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (deviceBindingSource.Current == null) return;
            if (!ValidateInput()) return;

            Device currentDevice = (Device)deviceBindingSource.Current;
            currentDevice.DeviceName = txtDeviceName.Text.Trim();
            currentDevice.Category = cboCategory.SelectedItem?.ToString() ?? "";
            currentDevice.Price = decimal.Parse(txtPrice.Text.Replace(",", "").Replace(".", ""));
            currentDevice.Quantity = (int)numQuantity.Value;

            deviceBindingSource.ResetCurrentItem();
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (deviceBindingSource.Current == null) return;

            Device currentDevice = (Device)deviceBindingSource.Current;
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thiết bị [{currentDevice.DeviceName}]?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                listDevices.Remove(currentDevice);
                MessageBox.Show("Đã xóa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtDeviceId.Text = $"TB{autoIncrementId:D3}";
            txtDeviceName.Clear();
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            txtPrice.Clear();
            numQuantity.Value = 0;
            txtDeviceName.Focus();
        }
    }
}