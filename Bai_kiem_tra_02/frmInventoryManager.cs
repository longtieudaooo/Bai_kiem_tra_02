using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai_kiem_tra_02
{
    public partial class frmInventoryManager : Form
    {
        private BindingList<Product> listProducts = new BindingList<Product>();
        private BindingSource productBindingSource = new BindingSource();
        private int autoIncrementId = 1;

        public frmInventoryManager()
        {
            InitializeComponent();

            this.btnAdd.Click += btnAdd_Click;
            this.btnUpdate.Click += btnUpdate_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.btnClear.Click += btnClear_Click;
            this.btnBrowseImage.Click += btnBrowseImage_Click;
            this.btnImportCsv.Click += btnImportCsv_Click;
            this.btnExportCsv.Click += btnExportCsv_Click;

            this.menuExit.Click += (s, e) => this.Close();
            this.menuImportCsv.Click += btnImportCsv_Click;
            this.menuExportCsv.Click += btnExportCsv_Click;

            this.timer1.Tick += Timer1_Tick;
            this.dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;
        }

        private void frmInventoryManager_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            InitSampleData();

            productBindingSource.DataSource = listProducts;
            dgvProducts.DataSource = productBindingSource;

            BindControls();
            UpdateTotalInventoryValue();

            if (cboCategory.Items.Count > 0)
                cboCategory.SelectedIndex = 0;
        }

        private void SetupDataGridView()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductId", HeaderText = "Mã SP", Width = 70 });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Tên sản phẩm", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Category", HeaderText = "Loại hàng", Width = 110 });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Price", HeaderText = "Đơn giá", Width = 110, DefaultCellStyle = new DataGridViewCellStyle { Format = "#,##0" } });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Số lượng", Width = 80 });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TotalValue", HeaderText = "Thành tiền", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "#,##0" } });
        }

        private void InitSampleData()
        {
            listProducts.Add(new Product($"SP{autoIncrementId++:D3}", "Tai nghe Bluetooth", "Phụ kiện", 1200000m, 25, ""));
            listProducts.Add(new Product($"SP{autoIncrementId++:D3}", "Bàn phím cơ Akko", "Phụ kiện", 1800000m, 10, ""));
            listProducts.Add(new Product($"SP{autoIncrementId++:D3}", "Màn hình Dell 27 inch", "Gia dụng", 5500000m, 5, ""));
        }

        private void BindControls()
        {
            txtProductId.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            cboCategory.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            numQuantity.DataBindings.Clear();
            txtImagePath.DataBindings.Clear();

            txtProductId.DataBindings.Add("Text", productBindingSource, "ProductId", true, DataSourceUpdateMode.Never);
            txtProductName.DataBindings.Add("Text", productBindingSource, "ProductName", true, DataSourceUpdateMode.OnPropertyChanged);
            cboCategory.DataBindings.Add("Text", productBindingSource, "Category", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPrice.DataBindings.Add("Text", productBindingSource, "Price", true, DataSourceUpdateMode.OnPropertyChanged, 0, "#,##0");
            numQuantity.DataBindings.Add("Value", productBindingSource, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);
            txtImagePath.DataBindings.Add("Text", productBindingSource, "ImagePath", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            lblStatusTime.Text = $"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
        }

        private void UpdateTotalInventoryValue()
        {
            decimal total = listProducts.Sum(p => p.TotalValue);
            lblTotalValue.Text = $"| Tổng giá trị kho: {total:#,##0} VNĐ";
        }

        private void DgvProducts_SelectionChanged(object? sender, EventArgs e)
        {
            if (productBindingSource.Current is Product p && !string.IsNullOrEmpty(p.ImagePath) && File.Exists(p.ImagePath))
            {
                try
                {
                    picProduct.Image = Image.FromFile(p.ImagePath);
                }
                catch
                {
                    picProduct.Image = null;
                }
            }
            else
            {
                picProduct.Image = null;
            }
        }

        private void btnBrowseImage_Click(object? sender, EventArgs e)
        {
            openFileDialog1.Filter = "File ảnh (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg|Tất cả tệp (*.*)|*.*";
            openFileDialog1.Title = "Chọn ảnh sản phẩm";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = openFileDialog1.FileName;
                picProduct.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private bool ValidateInput()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                errorProvider1.SetError(txtProductName, "Tên sản phẩm không được trống!");
                isValid = false;
            }

            if (!decimal.TryParse(txtPrice.Text.Replace(",", "").Replace(".", ""), out decimal price) || price < 0)
            {
                errorProvider1.SetError(txtPrice, "Đơn giá không hợp lệ!");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string newId = $"SP{autoIncrementId++:D3}";
            decimal price = decimal.Parse(txtPrice.Text.Replace(",", "").Replace(".", ""));
            string category = cboCategory.SelectedItem?.ToString() ?? "";

            Product newProd = new Product(newId, txtProductName.Text.Trim(), category, price, (int)numQuantity.Value, txtImagePath.Text);
            listProducts.Add(newProd);

            UpdateTotalInventoryValue();
            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear_Click(sender, e);
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (productBindingSource.Current is not Product current) return;
            if (!ValidateInput()) return;

            current.ProductName = txtProductName.Text.Trim();
            current.Category = cboCategory.SelectedItem?.ToString() ?? "";
            current.Price = decimal.Parse(txtPrice.Text.Replace(",", "").Replace(".", ""));
            current.Quantity = (int)numQuantity.Value;
            current.ImagePath = txtImagePath.Text;

            productBindingSource.ResetCurrentItem();
            UpdateTotalInventoryValue();
            MessageBox.Show("Cập nhật thông tin kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (productBindingSource.Current is not Product current) return;

            if (MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm [{current.ProductName}]?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listProducts.Remove(current);
                UpdateTotalInventoryValue();
                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtProductId.Text = $"SP{autoIncrementId:D3}";
            txtProductName.Clear();
            txtPrice.Clear();
            txtImagePath.Clear();
            picProduct.Image = null;
            numQuantity.Value = 0;
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            txtProductName.Focus();
        }

        private void btnExportCsv_Click(object? sender, EventArgs e)
        {
            saveFileDialog1.Filter = "File CSV (*.csv)|*.csv";
            saveFileDialog1.Title = "Xuất danh sách sản phẩm ra CSV";
            saveFileDialog1.FileName = "DanhSachKho.csv";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("ProductId,ProductName,Category,Price,Quantity,ImagePath");

                    foreach (var prod in listProducts)
                    {
                        sb.AppendLine(prod.ToCsvRow());
                    }

                    File.WriteAllText(saveFileDialog1.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnImportCsv_Click(object? sender, EventArgs e)
        {
            openFileDialog1.Filter = "File CSV (*.csv)|*.csv|Tất cả tệp (*.*)|*.*";
            openFileDialog1.Title = "Nhập danh sách sản phẩm từ CSV";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog1.FileName, Encoding.UTF8);
                    if (lines.Length <= 1)
                    {
                        MessageBox.Show("File CSV rỗng hoặc không đúng định dạng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    listProducts.Clear();
                    for (int i = 1; i < lines.Length; i++)
                    {
                        if (string.IsNullOrWhiteSpace(lines[i])) continue;
                        Product prod = Product.FromCsvRow(lines[i]);
                        if (!string.IsNullOrEmpty(prod.ProductId))
                        {
                            listProducts.Add(prod);
                        }
                    }

                    UpdateTotalInventoryValue();
                    MessageBox.Show("Nhập dữ liệu từ CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi đọc file CSV: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}