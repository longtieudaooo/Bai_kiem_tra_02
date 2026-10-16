namespace Bai_kiem_tra_02
{
    partial class frmInventoryManager
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTepTin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImportCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportCsv = new System.Windows.Forms.ToolStripMenuItem();

            this.grpInput = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.txtImagePath = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnImportCsv = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();

            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalValue = new System.Windows.Forms.ToolStripStatusLabel();

            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            this.msMain.SuspendLayout();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // MenuStrip
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuHeThong, this.menuTepTin });
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(834, 24);

            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuExit });
            this.menuHeThong.Text = "Hệ thống";
            this.menuExit.Text = "Thoát";

            this.menuTepTin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuImportCsv, this.menuExportCsv });
            this.menuTepTin.Text = "Tệp tin";
            this.menuImportCsv.Text = "Nhập CSV";
            this.menuExportCsv.Text = "Xuất CSV";

            // GroupBox grpInput
            this.grpInput.Controls.Add(this.txtImagePath);
            this.grpInput.Controls.Add(this.btnBrowseImage);
            this.grpInput.Controls.Add(this.picProduct);
            this.grpInput.Controls.Add(this.numQuantity);
            this.grpInput.Controls.Add(this.txtPrice);
            this.grpInput.Controls.Add(this.cboCategory);
            this.grpInput.Controls.Add(this.txtProductName);
            this.grpInput.Controls.Add(this.txtProductId);
            this.grpInput.Controls.Add(this.label5);
            this.grpInput.Controls.Add(this.label4);
            this.grpInput.Controls.Add(this.label3);
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Controls.Add(this.label1);
            this.grpInput.Location = new System.Drawing.Point(15, 30);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(800, 190);
            this.grpInput.Text = "Thông tin sản phẩm & Hình ảnh";

            // Labels & Inputs
            this.label1.Text = "Mã SP:"; this.label1.Location = new System.Drawing.Point(15, 25);
            this.txtProductId.Location = new System.Drawing.Point(95, 22); this.txtProductId.ReadOnly = true; this.txtProductId.Size = new System.Drawing.Size(180, 23);

            this.label2.Text = "Tên SP:"; this.label2.Location = new System.Drawing.Point(15, 58);
            this.txtProductName.Location = new System.Drawing.Point(95, 55); this.txtProductName.Size = new System.Drawing.Size(180, 23);

            this.label3.Text = "Loại hàng:"; this.label3.Location = new System.Drawing.Point(15, 91);
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Items.AddRange(new object[] { "Điện thoại", "Laptop", "Gia dụng", "Phụ kiện" });
            this.cboCategory.Location = new System.Drawing.Point(95, 88); this.cboCategory.Size = new System.Drawing.Size(180, 23);

            this.label4.Text = "Đơn giá:"; this.label4.Location = new System.Drawing.Point(15, 124);
            this.txtPrice.Location = new System.Drawing.Point(95, 121); this.txtPrice.Size = new System.Drawing.Size(180, 23);

            this.label5.Text = "Số lượng:"; this.label5.Location = new System.Drawing.Point(15, 157);
            this.numQuantity.Location = new System.Drawing.Point(95, 154); this.numQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 }); this.numQuantity.Size = new System.Drawing.Size(180, 23);

            // Picture & Image Path
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Location = new System.Drawing.Point(310, 22);
            this.picProduct.Size = new System.Drawing.Size(150, 155);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnBrowseImage.Text = "Chọn ảnh...";
            this.btnBrowseImage.Location = new System.Drawing.Point(475, 22);
            this.btnBrowseImage.Size = new System.Drawing.Size(100, 30);

            this.txtImagePath.Location = new System.Drawing.Point(475, 58);
            this.txtImagePath.ReadOnly = true;
            this.txtImagePath.Size = new System.Drawing.Size(305, 23);

            // Buttons
            this.btnAdd.Text = "Thêm mới"; this.btnAdd.Location = new System.Drawing.Point(15, 230); this.btnAdd.Size = new System.Drawing.Size(95, 32);
            this.btnUpdate.Text = "Cập nhật"; this.btnUpdate.Location = new System.Drawing.Point(120, 230); this.btnUpdate.Size = new System.Drawing.Size(95, 32);
            this.btnDelete.Text = "Xóa"; this.btnDelete.Location = new System.Drawing.Point(225, 230); this.btnDelete.Size = new System.Drawing.Size(95, 32);
            this.btnClear.Text = "Làm mới"; this.btnClear.Location = new System.Drawing.Point(330, 230); this.btnClear.Size = new System.Drawing.Size(95, 32);
            this.btnImportCsv.Text = "Nhập CSV"; this.btnImportCsv.Location = new System.Drawing.Point(590, 230); this.btnImportCsv.Size = new System.Drawing.Size(110, 32);
            this.btnExportCsv.Text = "Xuất CSV"; this.btnExportCsv.Location = new System.Drawing.Point(705, 230); this.btnExportCsv.Size = new System.Drawing.Size(110, 32);

            // DataGridView
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.Location = new System.Drawing.Point(15, 275);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(800, 220);

            // StatusStrip
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatusTime, this.lblTotalValue });
            this.ssStatus.Location = new System.Drawing.Point(0, 509);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(834, 22);

            this.lblStatusTime.Text = "Thời gian: ...";
            this.lblTotalValue.Text = "| Tổng giá trị kho: 0 VNĐ";

            // Timer & ErrorProvider
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.errorProvider1.ContainerControl = this;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 531);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnExportCsv);
            this.Controls.Add(this.btnImportCsv);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "frmInventoryManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Kho Hàng & Xuất Nhập CSV";
            this.Load += new System.EventHandler(this.frmInventoryManager_Load);

            this.msMain.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ssStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuTepTin;
        private System.Windows.Forms.ToolStripMenuItem menuImportCsv;
        private System.Windows.Forms.ToolStripMenuItem menuExportCsv;

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.TextBox txtImagePath;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnImportCsv;
        private System.Windows.Forms.Button btnExportCsv;

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTime;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalValue;

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}