namespace Bai_kiem_tra_02
{
    partial class frmMainMdi
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
            msMain = new MenuStrip();
            menuHeThong = new ToolStripMenuItem();
            menuSyncData = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuExit = new ToolStripMenuItem();
            menuChucNang = new ToolStripMenuItem();
            menuDeviceMgr = new ToolStripMenuItem();
            menuInventoryMgr = new ToolStripMenuItem();
            menuCuaSo = new ToolStripMenuItem();
            menuCascade = new ToolStripMenuItem();
            menuTileHorizontal = new ToolStripMenuItem();
            menuTileVertical = new ToolStripMenuItem();
            ssStatus = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            tsProgressBar = new ToolStripProgressBar();
            msMain.SuspendLayout();
            ssStatus.SuspendLayout();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.Items.AddRange(new ToolStripItem[] { menuHeThong, menuChucNang, menuCuaSo });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(1000, 24);
            msMain.TabIndex = 1;
            // 
            // menuHeThong
            // 
            menuHeThong.DropDownItems.AddRange(new ToolStripItem[] { menuSyncData, toolStripSeparator1, menuExit });
            menuHeThong.Name = "menuHeThong";
            menuHeThong.Size = new Size(69, 20);
            menuHeThong.Text = "Hệ thống";
            // 
            // menuSyncData
            // 
            menuSyncData.Name = "menuSyncData";
            menuSyncData.Size = new Size(202, 22);
            menuSyncData.Text = "Đồng bộ dữ liệu (Async)";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(199, 6);
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(202, 22);
            menuExit.Text = "Thoát hệ thống";
            // 
            // menuChucNang
            // 
            menuChucNang.DropDownItems.AddRange(new ToolStripItem[] { menuDeviceMgr, menuInventoryMgr });
            menuChucNang.Name = "menuChucNang";
            menuChucNang.Size = new Size(77, 20);
            menuChucNang.Text = "Chức năng";
            // 
            // menuDeviceMgr
            // 
            menuDeviceMgr.Name = "menuDeviceMgr";
            menuDeviceMgr.Size = new Size(231, 22);
            menuDeviceMgr.Text = "Bài 1: Quản lý thiết bị";
            // 
            // menuInventoryMgr
            // 
            menuInventoryMgr.Name = "menuInventoryMgr";
            menuInventoryMgr.Size = new Size(231, 22);
            menuInventoryMgr.Text = "Bài 2: Quản lý kho hàng (CSV)";
            // 
            // menuCuaSo
            // 
            menuCuaSo.DropDownItems.AddRange(new ToolStripItem[] { menuCascade, menuTileHorizontal, menuTileVertical });
            menuCuaSo.Name = "menuCuaSo";
            menuCuaSo.Size = new Size(55, 20);
            menuCuaSo.Text = "Cửa sổ";
            // 
            // menuCascade
            // 
            menuCascade.Name = "menuCascade";
            menuCascade.Size = new Size(219, 22);
            menuCascade.Text = "Xếp lớp (Cascade)";
            // 
            // menuTileHorizontal
            // 
            menuTileHorizontal.Name = "menuTileHorizontal";
            menuTileHorizontal.Size = new Size(219, 22);
            menuTileHorizontal.Text = "Xếp ngang (Tile Horizontal)";
            // 
            // menuTileVertical
            // 
            menuTileVertical.Name = "menuTileVertical";
            menuTileVertical.Size = new Size(219, 22);
            menuTileVertical.Text = "Xếp dọc (Tile Vertical)";
            // 
            // ssStatus
            // 
            ssStatus.Items.AddRange(new ToolStripItem[] { lblStatus, tsProgressBar });
            ssStatus.Location = new Point(0, 639);
            ssStatus.Name = "ssStatus";
            ssStatus.Size = new Size(1000, 22);
            ssStatus.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(54, 17);
            lblStatus.Text = "Sẵn sàng";
            // 
            // tsProgressBar
            // 
            tsProgressBar.Name = "tsProgressBar";
            tsProgressBar.Size = new Size(150, 16);
            tsProgressBar.Visible = false;
            // 
            // frmMainMdi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 661);
            Controls.Add(ssStatus);
            Controls.Add(msMain);
            IsMdiContainer = true;
            MainMenuStrip = msMain;
            Name = "frmMainMdi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Quản Lý Đa Chức Năng (MDI System)";
            Load += frmMainMdi_Load;
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ssStatus.ResumeLayout(false);
            ssStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuSyncData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuChucNang;
        private System.Windows.Forms.ToolStripMenuItem menuDeviceMgr;
        private System.Windows.Forms.ToolStripMenuItem menuInventoryMgr;
        private System.Windows.Forms.ToolStripMenuItem menuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem menuCascade;
        private System.Windows.Forms.ToolStripMenuItem menuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuTileVertical;

        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
    }
}