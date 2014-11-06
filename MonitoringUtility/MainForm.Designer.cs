namespace MonitoringUtility
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.monUtilMenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monUtilTabControl = new System.Windows.Forms.TabControl();
            this.procesesTabPage = new System.Windows.Forms.TabPage();
            this.processesListView = new System.Windows.Forms.ListView();
            this.processColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pIDcolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.threadsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procPathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procDescriptiСolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servicesTabPage = new System.Windows.Forms.TabPage();
            this.servicesListView = new System.Windows.Forms.ListView();
            this.servicesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servPathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servDescriptColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.autorunsTabPage = new System.Windows.Forms.TabPage();
            this.autorunListView = new System.Windows.Forms.ListView();
            this.programColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.autorunPathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.regSectionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.connectionTabPage = new System.Windows.Forms.TabPage();
            this.connectionsListView = new System.Windows.Forms.ListView();
            this.conTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locPointCcolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remPointColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stateConColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.propertyColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monUtilMenuStrip.SuspendLayout();
            this.monUtilTabControl.SuspendLayout();
            this.procesesTabPage.SuspendLayout();
            this.servicesTabPage.SuspendLayout();
            this.autorunsTabPage.SuspendLayout();
            this.connectionTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // monUtilMenuStrip
            // 
            this.monUtilMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.monUtilMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.monUtilMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.monUtilMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.monUtilMenuStrip.Name = "monUtilMenuStrip";
            this.monUtilMenuStrip.Size = new System.Drawing.Size(674, 24);
            this.monUtilMenuStrip.TabIndex = 0;
            this.monUtilMenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Exit";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.видToolStripMenuItem.Text = "View";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.обновитьToolStripMenuItem.Text = "Refresh tab";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.toolStripSeparator1,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.справкаToolStripMenuItem.Text = "Help";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.помощьToolStripMenuItem.Text = "View Help";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПрограммеToolStripMenuItem.Text = "About...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // monUtilTabControl
            // 
            this.monUtilTabControl.Controls.Add(this.procesesTabPage);
            this.monUtilTabControl.Controls.Add(this.servicesTabPage);
            this.monUtilTabControl.Controls.Add(this.autorunsTabPage);
            this.monUtilTabControl.Controls.Add(this.connectionTabPage);
            this.monUtilTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monUtilTabControl.Location = new System.Drawing.Point(0, 24);
            this.monUtilTabControl.Name = "monUtilTabControl";
            this.monUtilTabControl.SelectedIndex = 0;
            this.monUtilTabControl.Size = new System.Drawing.Size(674, 388);
            this.monUtilTabControl.TabIndex = 1;
            // 
            // procesesTabPage
            // 
            this.procesesTabPage.Controls.Add(this.processesListView);
            this.procesesTabPage.Location = new System.Drawing.Point(4, 22);
            this.procesesTabPage.Name = "procesesTabPage";
            this.procesesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.procesesTabPage.Size = new System.Drawing.Size(666, 362);
            this.procesesTabPage.TabIndex = 0;
            this.procesesTabPage.Text = "Processes";
            this.procesesTabPage.UseVisualStyleBackColor = true;
            // 
            // processesListView
            // 
            this.processesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processColumn,
            this.pIDcolumn,
            this.threadsColumn,
            this.procPathColumn,
            this.procDescriptiСolumn,
            this.timeColumn});
            this.processesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processesListView.FullRowSelect = true;
            this.processesListView.GridLines = true;
            this.processesListView.Location = new System.Drawing.Point(3, 3);
            this.processesListView.Name = "processesListView";
            this.processesListView.ShowItemToolTips = true;
            this.processesListView.Size = new System.Drawing.Size(660, 356);
            this.processesListView.TabIndex = 0;
            this.processesListView.UseCompatibleStateImageBehavior = false;
            this.processesListView.View = System.Windows.Forms.View.Details;
            // 
            // processColumn
            // 
            this.processColumn.Text = "Process";
            this.processColumn.Width = 160;
            // 
            // pIDcolumn
            // 
            this.pIDcolumn.Text = "PID";
            this.pIDcolumn.Width = 50;
            // 
            // threadsColumn
            // 
            this.threadsColumn.Text = "Thread count";
            this.threadsColumn.Width = 85;
            // 
            // procPathColumn
            // 
            this.procPathColumn.Text = "Executable path";
            this.procPathColumn.Width = 125;
            // 
            // procDescriptiСolumn
            // 
            this.procDescriptiСolumn.Text = "Owner";
            this.procDescriptiСolumn.Width = 110;
            // 
            // timeColumn
            // 
            this.timeColumn.Text = "Creation time";
            this.timeColumn.Width = 105;
            // 
            // servicesTabPage
            // 
            this.servicesTabPage.Controls.Add(this.servicesListView);
            this.servicesTabPage.Location = new System.Drawing.Point(4, 22);
            this.servicesTabPage.Name = "servicesTabPage";
            this.servicesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.servicesTabPage.Size = new System.Drawing.Size(666, 362);
            this.servicesTabPage.TabIndex = 1;
            this.servicesTabPage.Text = "Services";
            this.servicesTabPage.UseVisualStyleBackColor = true;
            // 
            // servicesListView
            // 
            this.servicesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.servicesColumn,
            this.sIDColumn,
            this.stateColumn,
            this.typeColumn,
            this.startTypeColumn,
            this.servPathColumn,
            this.servDescriptColumn});
            this.servicesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicesListView.FullRowSelect = true;
            this.servicesListView.GridLines = true;
            this.servicesListView.Location = new System.Drawing.Point(3, 3);
            this.servicesListView.Name = "servicesListView";
            this.servicesListView.ShowItemToolTips = true;
            this.servicesListView.Size = new System.Drawing.Size(660, 356);
            this.servicesListView.TabIndex = 0;
            this.servicesListView.UseCompatibleStateImageBehavior = false;
            this.servicesListView.View = System.Windows.Forms.View.Details;
            // 
            // servicesColumn
            // 
            this.servicesColumn.Text = "Name";
            this.servicesColumn.Width = 160;
            // 
            // sIDColumn
            // 
            this.sIDColumn.Text = "PID";
            this.sIDColumn.Width = 50;
            // 
            // stateColumn
            // 
            this.stateColumn.Text = "Status";
            // 
            // typeColumn
            // 
            this.typeColumn.Text = "Type";
            this.typeColumn.Width = 90;
            // 
            // startTypeColumn
            // 
            this.startTypeColumn.Text = "Start mode";
            this.startTypeColumn.Width = 75;
            // 
            // servPathColumn
            // 
            this.servPathColumn.Text = "Executable path";
            this.servPathColumn.Width = 115;
            // 
            // servDescriptColumn
            // 
            this.servDescriptColumn.Text = "Description";
            this.servDescriptColumn.Width = 85;
            // 
            // autorunsTabPage
            // 
            this.autorunsTabPage.Controls.Add(this.autorunListView);
            this.autorunsTabPage.Location = new System.Drawing.Point(4, 22);
            this.autorunsTabPage.Name = "autorunsTabPage";
            this.autorunsTabPage.Size = new System.Drawing.Size(666, 362);
            this.autorunsTabPage.TabIndex = 2;
            this.autorunsTabPage.Text = "Autorun";
            this.autorunsTabPage.UseVisualStyleBackColor = true;
            // 
            // autorunListView
            // 
            this.autorunListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.programColumn,
            this.autorunPathColumn,
            this.regSectionColumn});
            this.autorunListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autorunListView.FullRowSelect = true;
            this.autorunListView.GridLines = true;
            this.autorunListView.Location = new System.Drawing.Point(0, 0);
            this.autorunListView.Name = "autorunListView";
            this.autorunListView.ShowItemToolTips = true;
            this.autorunListView.Size = new System.Drawing.Size(666, 362);
            this.autorunListView.TabIndex = 0;
            this.autorunListView.UseCompatibleStateImageBehavior = false;
            this.autorunListView.View = System.Windows.Forms.View.Details;
            // 
            // programColumn
            // 
            this.programColumn.Text = "Program name";
            this.programColumn.Width = 160;
            // 
            // autorunPathColumn
            // 
            this.autorunPathColumn.Text = "Executable path";
            this.autorunPathColumn.Width = 395;
            // 
            // regSectionColumn
            // 
            this.regSectionColumn.Text = "Registry section";
            this.regSectionColumn.Width = 95;
            // 
            // connectionTabPage
            // 
            this.connectionTabPage.Controls.Add(this.connectionsListView);
            this.connectionTabPage.Location = new System.Drawing.Point(4, 22);
            this.connectionTabPage.Name = "connectionTabPage";
            this.connectionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.connectionTabPage.Size = new System.Drawing.Size(666, 362);
            this.connectionTabPage.TabIndex = 3;
            this.connectionTabPage.Text = "Active connections";
            this.connectionTabPage.UseVisualStyleBackColor = true;
            // 
            // connectionsListView
            // 
            this.connectionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.conTypeColumn,
            this.locPointCcolumn,
            this.remPointColumn,
            this.stateConColumn});
            this.connectionsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionsListView.FullRowSelect = true;
            this.connectionsListView.GridLines = true;
            this.connectionsListView.Location = new System.Drawing.Point(3, 3);
            this.connectionsListView.Name = "connectionsListView";
            this.connectionsListView.Size = new System.Drawing.Size(660, 356);
            this.connectionsListView.TabIndex = 0;
            this.connectionsListView.UseCompatibleStateImageBehavior = false;
            this.connectionsListView.View = System.Windows.Forms.View.Details;
            // 
            // conTypeColumn
            // 
            this.conTypeColumn.Text = "Type";
            this.conTypeColumn.Width = 90;
            // 
            // locPointCcolumn
            // 
            this.locPointCcolumn.Text = "Local address";
            this.locPointCcolumn.Width = 190;
            // 
            // remPointColumn
            // 
            this.remPointColumn.Text = "Remote address";
            this.remPointColumn.Width = 190;
            // 
            // stateConColumn
            // 
            this.stateConColumn.Text = "Connection state";
            this.stateConColumn.Width = 100;
            // 
            // propertyColumn
            // 
            this.propertyColumn.DisplayIndex = 0;
            this.propertyColumn.Text = "Параметр";
            this.propertyColumn.Width = 160;
            // 
            // valueColumn
            // 
            this.valueColumn.DisplayIndex = 1;
            this.valueColumn.Text = "Значение";
            this.valueColumn.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 412);
            this.Controls.Add(this.monUtilTabControl);
            this.Controls.Add(this.monUtilMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.monUtilMenuStrip;
            this.MinimumSize = new System.Drawing.Size(690, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoring utility";
            this.monUtilMenuStrip.ResumeLayout(false);
            this.monUtilMenuStrip.PerformLayout();
            this.monUtilTabControl.ResumeLayout(false);
            this.procesesTabPage.ResumeLayout(false);
            this.servicesTabPage.ResumeLayout(false);
            this.autorunsTabPage.ResumeLayout(false);
            this.connectionTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip monUtilMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TabControl monUtilTabControl;
        private System.Windows.Forms.TabPage procesesTabPage;
        private System.Windows.Forms.TabPage servicesTabPage;
        private System.Windows.Forms.TabPage autorunsTabPage;
        private System.Windows.Forms.ListView processesListView;
        private System.Windows.Forms.ColumnHeader processColumn;
        private System.Windows.Forms.ColumnHeader pIDcolumn;
        private System.Windows.Forms.ColumnHeader threadsColumn;
        private System.Windows.Forms.ColumnHeader procPathColumn;
        private System.Windows.Forms.ColumnHeader procDescriptiСolumn;
        private System.Windows.Forms.ColumnHeader timeColumn;
        private System.Windows.Forms.ListView servicesListView;
        private System.Windows.Forms.ColumnHeader servicesColumn;
        private System.Windows.Forms.ColumnHeader stateColumn;
        private System.Windows.Forms.ColumnHeader typeColumn;
        private System.Windows.Forms.ColumnHeader startTypeColumn;
        private System.Windows.Forms.ColumnHeader servPathColumn;
        private System.Windows.Forms.ColumnHeader servDescriptColumn;
        private System.Windows.Forms.ColumnHeader sIDColumn;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ListView autorunListView;
        private System.Windows.Forms.ColumnHeader programColumn;
        private System.Windows.Forms.ColumnHeader autorunPathColumn;
        private System.Windows.Forms.ColumnHeader regSectionColumn;
        private System.Windows.Forms.TabPage connectionTabPage;
        private System.Windows.Forms.ColumnHeader propertyColumn;
        private System.Windows.Forms.ColumnHeader valueColumn;
        private System.Windows.Forms.ListView connectionsListView;
        private System.Windows.Forms.ColumnHeader conTypeColumn;
        private System.Windows.Forms.ColumnHeader locPointCcolumn;
        private System.Windows.Forms.ColumnHeader remPointColumn;
        private System.Windows.Forms.ColumnHeader stateConColumn;
    }
}

