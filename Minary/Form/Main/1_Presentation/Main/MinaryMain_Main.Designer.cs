﻿namespace Minary.Form.Main
{
  using Minary.DataTypes.Enum;
  using Minary.LogConsole.Main;


  public partial class MinaryMain
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      try
      {
        this.attackServiceHandler.ShutDown();
      }
      catch (System.Exception ex)
      {
        LogCons.Inst.Write(LogLevel.Error, "MinaryMain.Dispose(Exception): {0}", ex.Message);
      }

      if (disposing && (components != null))
      {
        components.Dispose();
      }

      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinaryMain));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.gb_Interfaces = new System.Windows.Forms.GroupBox();
      this.tb_TemplateName = new System.Windows.Forms.TextBox();
      this.l_Template = new System.Windows.Forms.Label();
      this.l_NetrangeSeparator = new System.Windows.Forms.Label();
      this.cb_Interfaces = new System.Windows.Forms.ComboBox();
      this.tb_NetworkStopIp = new System.Windows.Forms.TextBox();
      this.tb_NetworkStartIp = new System.Windows.Forms.TextBox();
      this.lab_Interface = new System.Windows.Forms.Label();
      this.lab_StartIP = new System.Windows.Forms.Label();
      this.bt_Attack = new System.Windows.Forms.Button();
      this.bt_ScanLan = new System.Windows.Forms.Button();
      this.gb_TargetRange = new System.Windows.Forms.GroupBox();
      this.tb_GatewayMac = new System.Windows.Forms.TextBox();
      this.l_GatewayMAC = new System.Windows.Forms.Label();
      this.tb_Vendor = new System.Windows.Forms.TextBox();
      this.l_VendorTitle = new System.Windows.Forms.Label();
      this.tb_GatewayIp = new System.Windows.Forms.TextBox();
      this.l_GatewayIP = new System.Windows.Forms.Label();
      this.tc_Plugins = new System.Windows.Forms.TabControl();
      this.tp_MinaryPluginCatalog = new System.Windows.Forms.TabPage();
      this.dgv_MainPlugins = new System.Windows.Forms.DataGridView();
      this.il_PluginStat = new System.Windows.Forms.ImageList(this.components);
      this.ms_MainWindow = new System.Windows.Forms.MenuStrip();
      this.tsmi_File = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_ResetMinary = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_Settings = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_Beep = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_Debugging = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_SimpleGUI = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_Attack = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_Template = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_LoadTemplate = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_CreateTemplate = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_UnloadTemplate = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_Tools = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_Minibrowser = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_DetectInterfaces = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_TlsSslCertificates = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_Help = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_GetUpdates = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_LogConsole = new System.Windows.Forms.ToolStripMenuItem();
      this.ofd_ImportSession = new System.Windows.Forms.OpenFileDialog();
      this.il_AttackServiceStat = new System.Windows.Forms.ImageList(this.components);
      this.flp_AttackServices = new System.Windows.Forms.FlowLayoutPanel();
      this.tsmi_ArpScan = new System.Windows.Forms.ToolStripMenuItem();
      this.gb_Interfaces.SuspendLayout();
      this.gb_TargetRange.SuspendLayout();
      this.tc_Plugins.SuspendLayout();
      this.tp_MinaryPluginCatalog.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_MainPlugins)).BeginInit();
      this.ms_MainWindow.SuspendLayout();
      this.SuspendLayout();
      // 
      // gb_Interfaces
      // 
      this.gb_Interfaces.Controls.Add(this.tb_TemplateName);
      this.gb_Interfaces.Controls.Add(this.l_Template);
      this.gb_Interfaces.Controls.Add(this.l_NetrangeSeparator);
      this.gb_Interfaces.Controls.Add(this.cb_Interfaces);
      this.gb_Interfaces.Controls.Add(this.tb_NetworkStopIp);
      this.gb_Interfaces.Controls.Add(this.tb_NetworkStartIp);
      this.gb_Interfaces.Controls.Add(this.lab_Interface);
      this.gb_Interfaces.Controls.Add(this.lab_StartIP);
      this.gb_Interfaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb_Interfaces.Location = new System.Drawing.Point(593, 35);
      this.gb_Interfaces.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.gb_Interfaces.Name = "gb_Interfaces";
      this.gb_Interfaces.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.gb_Interfaces.Size = new System.Drawing.Size(600, 162);
      this.gb_Interfaces.TabIndex = 2;
      this.gb_Interfaces.TabStop = false;
      // 
      // tb_TemplateName
      // 
      this.tb_TemplateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tb_TemplateName.Location = new System.Drawing.Point(150, 111);
      this.tb_TemplateName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tb_TemplateName.Name = "tb_TemplateName";
      this.tb_TemplateName.ReadOnly = true;
      this.tb_TemplateName.Size = new System.Drawing.Size(415, 26);
      this.tb_TemplateName.TabIndex = 10;
      this.tb_TemplateName.TabStop = false;
      // 
      // l_Template
      // 
      this.l_Template.AutoSize = true;
      this.l_Template.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.l_Template.Location = new System.Drawing.Point(14, 115);
      this.l_Template.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.l_Template.Name = "l_Template";
      this.l_Template.Size = new System.Drawing.Size(86, 20);
      this.l_Template.TabIndex = 11;
      this.l_Template.Text = "Template";
      // 
      // l_NetrangeSeparator
      // 
      this.l_NetrangeSeparator.AutoSize = true;
      this.l_NetrangeSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.l_NetrangeSeparator.Location = new System.Drawing.Point(352, 75);
      this.l_NetrangeSeparator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.l_NetrangeSeparator.Name = "l_NetrangeSeparator";
      this.l_NetrangeSeparator.Size = new System.Drawing.Size(15, 20);
      this.l_NetrangeSeparator.TabIndex = 9;
      this.l_NetrangeSeparator.Text = "-";
      // 
      // cb_Interfaces
      // 
      this.cb_Interfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cb_Interfaces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.cb_Interfaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cb_Interfaces.FormattingEnabled = true;
      this.cb_Interfaces.Location = new System.Drawing.Point(147, 26);
      this.cb_Interfaces.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cb_Interfaces.Name = "cb_Interfaces";
      this.cb_Interfaces.Size = new System.Drawing.Size(418, 28);
      this.cb_Interfaces.TabIndex = 3;
      this.cb_Interfaces.SelectedIndexChanged += new System.EventHandler(this.CB_Interfaces_SelectedIndexChanged);
      // 
      // tb_NetworkStopIp
      // 
      this.tb_NetworkStopIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tb_NetworkStopIp.Location = new System.Drawing.Point(376, 69);
      this.tb_NetworkStopIp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tb_NetworkStopIp.Name = "tb_NetworkStopIp";
      this.tb_NetworkStopIp.ReadOnly = true;
      this.tb_NetworkStopIp.Size = new System.Drawing.Size(188, 26);
      this.tb_NetworkStopIp.TabIndex = 0;
      this.tb_NetworkStopIp.TabStop = false;
      // 
      // tb_NetworkStartIp
      // 
      this.tb_NetworkStartIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tb_NetworkStartIp.Location = new System.Drawing.Point(150, 69);
      this.tb_NetworkStartIp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tb_NetworkStartIp.Name = "tb_NetworkStartIp";
      this.tb_NetworkStartIp.ReadOnly = true;
      this.tb_NetworkStartIp.Size = new System.Drawing.Size(192, 26);
      this.tb_NetworkStartIp.TabIndex = 0;
      this.tb_NetworkStartIp.TabStop = false;
      // 
      // lab_Interface
      // 
      this.lab_Interface.AutoSize = true;
      this.lab_Interface.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lab_Interface.Location = new System.Drawing.Point(14, 31);
      this.lab_Interface.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lab_Interface.Name = "lab_Interface";
      this.lab_Interface.Size = new System.Drawing.Size(83, 20);
      this.lab_Interface.TabIndex = 0;
      this.lab_Interface.Text = "Interface";
      // 
      // lab_StartIP
      // 
      this.lab_StartIP.AutoSize = true;
      this.lab_StartIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lab_StartIP.Location = new System.Drawing.Point(14, 74);
      this.lab_StartIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lab_StartIP.Name = "lab_StartIP";
      this.lab_StartIP.Size = new System.Drawing.Size(91, 20);
      this.lab_StartIP.TabIndex = 0;
      this.lab_StartIP.Text = "Net range";
      // 
      // bt_Attack
      // 
      this.bt_Attack.AutoSize = true;
      this.bt_Attack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Attack.BackgroundImage")));
      this.bt_Attack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.bt_Attack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.bt_Attack.Location = new System.Drawing.Point(1418, 44);
      this.bt_Attack.Margin = new System.Windows.Forms.Padding(0);
      this.bt_Attack.Name = "bt_Attack";
      this.bt_Attack.Size = new System.Drawing.Size(184, 151);
      this.bt_Attack.TabIndex = 6;
      this.bt_Attack.UseVisualStyleBackColor = true;
      this.bt_Attack.Click += new System.EventHandler(this.BT_Attack_Click);
      // 
      // bt_ScanLan
      // 
      this.bt_ScanLan.AutoSize = true;
      this.bt_ScanLan.BackgroundImage = global::Minary.Properties.Resources.FA_Scan;
      this.bt_ScanLan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.bt_ScanLan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.bt_ScanLan.Location = new System.Drawing.Point(1213, 44);
      this.bt_ScanLan.Margin = new System.Windows.Forms.Padding(0);
      this.bt_ScanLan.Name = "bt_ScanLan";
      this.bt_ScanLan.Size = new System.Drawing.Size(184, 151);
      this.bt_ScanLan.TabIndex = 5;
      this.bt_ScanLan.UseVisualStyleBackColor = true;
      this.bt_ScanLan.Click += new System.EventHandler(this.BT_ScanLan_Click);
      // 
      // gb_TargetRange
      // 
      this.gb_TargetRange.Controls.Add(this.tb_GatewayMac);
      this.gb_TargetRange.Controls.Add(this.l_GatewayMAC);
      this.gb_TargetRange.Controls.Add(this.tb_Vendor);
      this.gb_TargetRange.Controls.Add(this.l_VendorTitle);
      this.gb_TargetRange.Controls.Add(this.tb_GatewayIp);
      this.gb_TargetRange.Controls.Add(this.l_GatewayIP);
      this.gb_TargetRange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.gb_TargetRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb_TargetRange.Location = new System.Drawing.Point(18, 35);
      this.gb_TargetRange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.gb_TargetRange.Name = "gb_TargetRange";
      this.gb_TargetRange.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.gb_TargetRange.Size = new System.Drawing.Size(549, 162);
      this.gb_TargetRange.TabIndex = 1;
      this.gb_TargetRange.TabStop = false;
      // 
      // tb_GatewayMac
      // 
      this.tb_GatewayMac.Location = new System.Drawing.Point(164, 69);
      this.tb_GatewayMac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tb_GatewayMac.Name = "tb_GatewayMac";
      this.tb_GatewayMac.ReadOnly = true;
      this.tb_GatewayMac.Size = new System.Drawing.Size(358, 26);
      this.tb_GatewayMac.TabIndex = 13;
      this.tb_GatewayMac.TabStop = false;
      // 
      // l_GatewayMAC
      // 
      this.l_GatewayMAC.AutoSize = true;
      this.l_GatewayMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.l_GatewayMAC.Location = new System.Drawing.Point(21, 74);
      this.l_GatewayMAC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.l_GatewayMAC.Name = "l_GatewayMAC";
      this.l_GatewayMAC.Size = new System.Drawing.Size(127, 20);
      this.l_GatewayMAC.TabIndex = 12;
      this.l_GatewayMAC.Text = "Gateway MAC";
      // 
      // tb_Vendor
      // 
      this.tb_Vendor.Location = new System.Drawing.Point(164, 111);
      this.tb_Vendor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tb_Vendor.Name = "tb_Vendor";
      this.tb_Vendor.ReadOnly = true;
      this.tb_Vendor.Size = new System.Drawing.Size(358, 26);
      this.tb_Vendor.TabIndex = 11;
      this.tb_Vendor.TabStop = false;
      // 
      // l_VendorTitle
      // 
      this.l_VendorTitle.AutoSize = true;
      this.l_VendorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.l_VendorTitle.Location = new System.Drawing.Point(21, 115);
      this.l_VendorTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.l_VendorTitle.Name = "l_VendorTitle";
      this.l_VendorTitle.Size = new System.Drawing.Size(68, 20);
      this.l_VendorTitle.TabIndex = 10;
      this.l_VendorTitle.Text = "Vendor";
      // 
      // tb_GatewayIp
      // 
      this.tb_GatewayIp.Location = new System.Drawing.Point(164, 28);
      this.tb_GatewayIp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tb_GatewayIp.Name = "tb_GatewayIp";
      this.tb_GatewayIp.ReadOnly = true;
      this.tb_GatewayIp.Size = new System.Drawing.Size(358, 26);
      this.tb_GatewayIp.TabIndex = 0;
      this.tb_GatewayIp.TabStop = false;
      // 
      // l_GatewayIP
      // 
      this.l_GatewayIP.AutoSize = true;
      this.l_GatewayIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.l_GatewayIP.Location = new System.Drawing.Point(21, 31);
      this.l_GatewayIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.l_GatewayIP.Name = "l_GatewayIP";
      this.l_GatewayIP.Size = new System.Drawing.Size(104, 20);
      this.l_GatewayIP.TabIndex = 0;
      this.l_GatewayIP.Text = "Gateway IP";
      // 
      // tc_Plugins
      // 
      this.tc_Plugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tc_Plugins.Controls.Add(this.tp_MinaryPluginCatalog);
      this.tc_Plugins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tc_Plugins.ImageList = this.il_PluginStat;
      this.tc_Plugins.ItemSize = new System.Drawing.Size(79, 23);
      this.tc_Plugins.Location = new System.Drawing.Point(18, 218);
      this.tc_Plugins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tc_Plugins.Multiline = true;
      this.tc_Plugins.Name = "tc_Plugins";
      this.tc_Plugins.SelectedIndex = 0;
      this.tc_Plugins.Size = new System.Drawing.Size(1584, 640);
      this.tc_Plugins.TabIndex = 7;
      // 
      // tp_MinaryPluginCatalog
      // 
      this.tp_MinaryPluginCatalog.BackColor = System.Drawing.Color.White;
      this.tp_MinaryPluginCatalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.tp_MinaryPluginCatalog.Controls.Add(this.dgv_MainPlugins);
      this.tp_MinaryPluginCatalog.Location = new System.Drawing.Point(4, 27);
      this.tp_MinaryPluginCatalog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tp_MinaryPluginCatalog.Name = "tp_MinaryPluginCatalog";
      this.tp_MinaryPluginCatalog.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tp_MinaryPluginCatalog.Size = new System.Drawing.Size(1576, 609);
      this.tp_MinaryPluginCatalog.TabIndex = 0;
      this.tp_MinaryPluginCatalog.Text = "Minary";
      // 
      // dgv_MainPlugins
      // 
      this.dgv_MainPlugins.AllowUserToAddRows = false;
      this.dgv_MainPlugins.AllowUserToDeleteRows = false;
      this.dgv_MainPlugins.AllowUserToResizeColumns = false;
      this.dgv_MainPlugins.AllowUserToResizeRows = false;
      this.dgv_MainPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgv_MainPlugins.BackgroundColor = System.Drawing.Color.White;
      this.dgv_MainPlugins.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgv_MainPlugins.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.dgv_MainPlugins.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv_MainPlugins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dgv_MainPlugins.ColumnHeadersHeight = 28;
      this.dgv_MainPlugins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgv_MainPlugins.DefaultCellStyle = dataGridViewCellStyle2;
      this.dgv_MainPlugins.EnableHeadersVisualStyles = false;
      this.dgv_MainPlugins.GridColor = System.Drawing.Color.White;
      this.dgv_MainPlugins.Location = new System.Drawing.Point(69, 31);
      this.dgv_MainPlugins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.dgv_MainPlugins.MultiSelect = false;
      this.dgv_MainPlugins.Name = "dgv_MainPlugins";
      this.dgv_MainPlugins.ReadOnly = true;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv_MainPlugins.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dgv_MainPlugins.RowHeadersVisible = false;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dgv_MainPlugins.RowsDefaultCellStyle = dataGridViewCellStyle4;
      this.dgv_MainPlugins.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dgv_MainPlugins.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
      this.dgv_MainPlugins.RowTemplate.ReadOnly = true;
      this.dgv_MainPlugins.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.dgv_MainPlugins.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dgv_MainPlugins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv_MainPlugins.Size = new System.Drawing.Size(1470, 518);
      this.dgv_MainPlugins.TabIndex = 0;
      this.dgv_MainPlugins.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_MainPlugins_CellContentClick);
      this.dgv_MainPlugins.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DGV_MainPlugins_DataError);
      // 
      // il_PluginStat
      // 
      this.il_PluginStat.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_PluginStat.ImageStream")));
      this.il_PluginStat.TransparentColor = System.Drawing.Color.Transparent;
      this.il_PluginStat.Images.SetKeyName(0, "fa_paus_plugin.png");
      this.il_PluginStat.Images.SetKeyName(1, "fa_play_plugin.png");
      this.il_PluginStat.Images.SetKeyName(2, "fa_stop_plugin.png");
      // 
      // ms_MainWindow
      // 
      this.ms_MainWindow.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.ms_MainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_File,
            this.tsmi_Settings,
            this.tsmi_Template,
            this.tsmi_Tools,
            this.tsmi_Help});
      this.ms_MainWindow.Location = new System.Drawing.Point(0, 0);
      this.ms_MainWindow.Name = "ms_MainWindow";
      this.ms_MainWindow.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
      this.ms_MainWindow.Size = new System.Drawing.Size(1622, 35);
      this.ms_MainWindow.TabIndex = 0;
      this.ms_MainWindow.Text = "ms_MainGUI";
      // 
      // tsmi_File
      // 
      this.tsmi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Exit,
            this.tsmi_ResetMinary});
      this.tsmi_File.Name = "tsmi_File";
      this.tsmi_File.Size = new System.Drawing.Size(50, 29);
      this.tsmi_File.Text = "File";
      // 
      // tsmi_Exit
      // 
      this.tsmi_Exit.Name = "tsmi_Exit";
      this.tsmi_Exit.Size = new System.Drawing.Size(197, 30);
      this.tsmi_Exit.Text = "Exit";
      this.tsmi_Exit.Click += new System.EventHandler(this.TSMI_ExitTool_Click);
      // 
      // tsmi_ResetMinary
      // 
      this.tsmi_ResetMinary.Name = "tsmi_ResetMinary";
      this.tsmi_ResetMinary.Size = new System.Drawing.Size(197, 30);
      this.tsmi_ResetMinary.Text = "Reset Minary";
      this.tsmi_ResetMinary.Click += new System.EventHandler(this.TSMI_ResetAllPlugins_Click);
      // 
      // tsmi_Settings
      // 
      this.tsmi_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Beep,
            this.tsmi_Debugging,
            this.tsmi_SimpleGUI,
            this.tsmi_Attack});
      this.tsmi_Settings.Name = "tsmi_Settings";
      this.tsmi_Settings.Size = new System.Drawing.Size(88, 29);
      this.tsmi_Settings.Text = "Settings";
      // 
      // tsmi_Beep
      // 
      this.tsmi_Beep.Name = "tsmi_Beep";
      this.tsmi_Beep.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
      this.tsmi_Beep.Size = new System.Drawing.Size(295, 30);
      this.tsmi_Beep.Text = "Beep (off)";
      this.tsmi_Beep.Click += new System.EventHandler(this.TSMI_BeepToolStrip_Click);
      // 
      // tsmi_Debugging
      // 
      this.tsmi_Debugging.Name = "tsmi_Debugging";
      this.tsmi_Debugging.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
      this.tsmi_Debugging.Size = new System.Drawing.Size(295, 30);
      this.tsmi_Debugging.Text = "Debugging (off)";
      this.tsmi_Debugging.Click += new System.EventHandler(this.TSMI_DebugginOn_Click);
      // 
      // tsmi_SimpleGUI
      // 
      this.tsmi_SimpleGUI.Name = "tsmi_SimpleGUI";
      this.tsmi_SimpleGUI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.tsmi_SimpleGUI.Size = new System.Drawing.Size(295, 30);
      this.tsmi_SimpleGUI.Text = "Simple GUI (off)";
      this.tsmi_SimpleGUI.Click += new System.EventHandler(this.TSMI_SimpleGui_Click);
      // 
      // tsmi_Attack
      // 
      this.tsmi_Attack.Name = "tsmi_Attack";
      this.tsmi_Attack.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.tsmi_Attack.Size = new System.Drawing.Size(295, 30);
      this.tsmi_Attack.Text = "Attack  (stopped)";
      this.tsmi_Attack.Click += new System.EventHandler(this.TSMI_Attack_Click);
      // 
      // tsmi_Template
      // 
      this.tsmi_Template.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_LoadTemplate,
            this.tsmi_CreateTemplate,
            this.tsmi_UnloadTemplate});
      this.tsmi_Template.Name = "tsmi_Template";
      this.tsmi_Template.Size = new System.Drawing.Size(95, 29);
      this.tsmi_Template.Text = "Template";
      // 
      // tsmi_LoadTemplate
      // 
      this.tsmi_LoadTemplate.Name = "tsmi_LoadTemplate";
      this.tsmi_LoadTemplate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
      this.tsmi_LoadTemplate.Size = new System.Drawing.Size(227, 30);
      this.tsmi_LoadTemplate.Text = "Load ...";
      this.tsmi_LoadTemplate.Click += new System.EventHandler(this.TSMI_LoadTemplate_Click);
      // 
      // tsmi_CreateTemplate
      // 
      this.tsmi_CreateTemplate.Name = "tsmi_CreateTemplate";
      this.tsmi_CreateTemplate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.tsmi_CreateTemplate.Size = new System.Drawing.Size(227, 30);
      this.tsmi_CreateTemplate.Text = "Create ...";
      this.tsmi_CreateTemplate.Click += new System.EventHandler(this.TSMI_CreateTool_Click);
      // 
      // tsmi_UnloadTemplate
      // 
      this.tsmi_UnloadTemplate.Name = "tsmi_UnloadTemplate";
      this.tsmi_UnloadTemplate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
      this.tsmi_UnloadTemplate.Size = new System.Drawing.Size(227, 30);
      this.tsmi_UnloadTemplate.Text = "Unload ";
      this.tsmi_UnloadTemplate.Click += new System.EventHandler(this.TSMI_UnloadTemplate_Click);
      // 
      // tsmi_Tools
      // 
      this.tsmi_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Minibrowser,
            this.tsmi_DetectInterfaces,
            this.tsmi_TlsSslCertificates,
            this.tsmi_ArpScan});
      this.tsmi_Tools.Name = "tsmi_Tools";
      this.tsmi_Tools.Size = new System.Drawing.Size(65, 29);
      this.tsmi_Tools.Text = "Tools";
      // 
      // tsmi_Minibrowser
      // 
      this.tsmi_Minibrowser.Name = "tsmi_Minibrowser";
      this.tsmi_Minibrowser.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
      this.tsmi_Minibrowser.Size = new System.Drawing.Size(296, 30);
      this.tsmi_Minibrowser.Text = "Minibrowser ...";
      this.tsmi_Minibrowser.Click += new System.EventHandler(this.TSMI_Minibrowser_Click);
      // 
      // tsmi_DetectInterfaces
      // 
      this.tsmi_DetectInterfaces.Name = "tsmi_DetectInterfaces";
      this.tsmi_DetectInterfaces.Size = new System.Drawing.Size(296, 30);
      this.tsmi_DetectInterfaces.Text = "Detect network interfaces";
      this.tsmi_DetectInterfaces.Click += new System.EventHandler(this.TSMI_SearchNetworkInterfaces_Click);
      // 
      // tsmi_TlsSslCertificates
      // 
      this.tsmi_TlsSslCertificates.Name = "tsmi_TlsSslCertificates";
      this.tsmi_TlsSslCertificates.Size = new System.Drawing.Size(296, 30);
      this.tsmi_TlsSslCertificates.Text = "TLS/SSL certificates";
      this.tsmi_TlsSslCertificates.Click += new System.EventHandler(this.TSMI_ServerCert_Click);
      // 
      // tsmi_Help
      // 
      this.tsmi_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_GetUpdates,
            this.tsmi_LogConsole});
      this.tsmi_Help.Name = "tsmi_Help";
      this.tsmi_Help.Size = new System.Drawing.Size(61, 29);
      this.tsmi_Help.Text = "Help";
      // 
      // tsmi_GetUpdates
      // 
      this.tsmi_GetUpdates.Name = "tsmi_GetUpdates";
      this.tsmi_GetUpdates.Size = new System.Drawing.Size(268, 30);
      this.tsmi_GetUpdates.Text = "Check for updates ...";
      this.tsmi_GetUpdates.Click += new System.EventHandler(this.TSMI_GetUpdatesTool_Click);
      // 
      // tsmi_LogConsole
      // 
      this.tsmi_LogConsole.Name = "tsmi_LogConsole";
      this.tsmi_LogConsole.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
      this.tsmi_LogConsole.Size = new System.Drawing.Size(268, 30);
      this.tsmi_LogConsole.Text = "Log console ...";
      this.tsmi_LogConsole.Click += new System.EventHandler(this.TSMI_LogConsoleTool_Click);
      // 
      // ofd_ImportSession
      // 
      this.ofd_ImportSession.DefaultExt = "mry";
      this.ofd_ImportSession.Filter = "Minary session file | *.mry";
      this.ofd_ImportSession.Title = "Select Minary session file";
      // 
      // il_AttackServiceStat
      // 
      this.il_AttackServiceStat.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_AttackServiceStat.ImageStream")));
      this.il_AttackServiceStat.TransparentColor = System.Drawing.Color.Transparent;
      this.il_AttackServiceStat.Images.SetKeyName(0, "fa_paus_plugin.png");
      this.il_AttackServiceStat.Images.SetKeyName(1, "fa_play_plugin.png");
      this.il_AttackServiceStat.Images.SetKeyName(2, "fa_stop_plugin.png");
      // 
      // flp_AttackServices
      // 
      this.flp_AttackServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.flp_AttackServices.Location = new System.Drawing.Point(22, 866);
      this.flp_AttackServices.Name = "flp_AttackServices";
      this.flp_AttackServices.Size = new System.Drawing.Size(1576, 28);
      this.flp_AttackServices.TabIndex = 0;
      // 
      // tsmi_ArpScan
      // 
      this.tsmi_ArpScan.Name = "tsmi_ArpScan";
      this.tsmi_ArpScan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.tsmi_ArpScan.Size = new System.Drawing.Size(296, 30);
      this.tsmi_ArpScan.Text = "ARP scan";
      this.tsmi_ArpScan.Click += new System.EventHandler(this.TSMI_ArpScan_Click);
      // 
      // MinaryMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1622, 906);
      this.Controls.Add(this.flp_AttackServices);
      this.Controls.Add(this.tc_Plugins);
      this.Controls.Add(this.gb_TargetRange);
      this.Controls.Add(this.bt_Attack);
      this.Controls.Add(this.bt_ScanLan);
      this.Controls.Add(this.gb_Interfaces);
      this.Controls.Add(this.ms_MainWindow);
      this.Icon = global::Minary.Properties.Resources.Minary;
      this.MainMenuStrip = this.ms_MainWindow;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MinimumSize = new System.Drawing.Size(1644, 934);
      this.Name = "MinaryMain";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.Text = " Minary ";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MinaryMain_FormClosing);
      this.Shown += new System.EventHandler(this.MinaryMain_Shown);
      this.gb_Interfaces.ResumeLayout(false);
      this.gb_Interfaces.PerformLayout();
      this.gb_TargetRange.ResumeLayout(false);
      this.gb_TargetRange.PerformLayout();
      this.tc_Plugins.ResumeLayout(false);
      this.tp_MinaryPluginCatalog.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_MainPlugins)).EndInit();
      this.ms_MainWindow.ResumeLayout(false);
      this.ms_MainWindow.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox gb_Interfaces;
    private System.Windows.Forms.ComboBox cb_Interfaces;
    private System.Windows.Forms.Label lab_Interface;
    private System.Windows.Forms.GroupBox gb_TargetRange;
    private System.Windows.Forms.TextBox tb_NetworkStopIp;
    private System.Windows.Forms.TextBox tb_NetworkStartIp;
    private System.Windows.Forms.Label lab_StartIP;
    private System.Windows.Forms.TabControl tc_Plugins;
    private System.Windows.Forms.TabPage tp_MinaryPluginCatalog;
    private System.Windows.Forms.DataGridView dgv_MainPlugins;
    private System.Windows.Forms.MenuStrip ms_MainWindow;
    private System.Windows.Forms.ToolStripMenuItem tsmi_File;
    private System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
    private System.Windows.Forms.ToolStripMenuItem tsmi_Help;
    private System.Windows.Forms.ToolStripMenuItem tsmi_GetUpdates;
    private System.Windows.Forms.ToolStripMenuItem tsmi_LogConsole;
    private System.Windows.Forms.Button bt_ScanLan;
    private System.Windows.Forms.Label l_GatewayIP;
    private System.Windows.Forms.TextBox tb_GatewayIp;
    private System.Windows.Forms.Button bt_Attack;
    private System.Windows.Forms.Label l_NetrangeSeparator;
    private System.Windows.Forms.ImageList il_PluginStat;
    private System.Windows.Forms.TextBox tb_Vendor;
    private System.Windows.Forms.Label l_VendorTitle;
    private System.Windows.Forms.TextBox tb_GatewayMac;
    private System.Windows.Forms.Label l_GatewayMAC;
    private System.Windows.Forms.OpenFileDialog ofd_ImportSession;
    private System.Windows.Forms.ToolStripMenuItem tsmi_Template;
    private System.Windows.Forms.ToolStripMenuItem tsmi_LoadTemplate;
    private System.Windows.Forms.ToolStripMenuItem tsmi_CreateTemplate;
    private System.Windows.Forms.TextBox tb_TemplateName;
    private System.Windows.Forms.Label l_Template;
    private System.Windows.Forms.ImageList il_AttackServiceStat;
    private System.Windows.Forms.ToolStripMenuItem tsmi_UnloadTemplate;
    private System.Windows.Forms.ToolStripMenuItem tsmi_ResetMinary;
    private System.Windows.Forms.ToolStripMenuItem tsmi_Tools;
    private System.Windows.Forms.ToolStripMenuItem tsmi_Minibrowser;
    private System.Windows.Forms.ToolStripMenuItem tsmi_DetectInterfaces;
    private System.Windows.Forms.ToolStripMenuItem tsmi_Settings;
    private System.Windows.Forms.ToolStripMenuItem tsmi_Beep;
    private System.Windows.Forms.ToolStripMenuItem tsmi_Debugging;
    private System.Windows.Forms.FlowLayoutPanel flp_AttackServices;
    private System.Windows.Forms.ToolStripMenuItem tsmi_SimpleGUI;
    private System.Windows.Forms.ToolStripMenuItem tsmi_TlsSslCertificates;
    private System.Windows.Forms.ToolStripMenuItem tsmi_Attack;
    private System.Windows.Forms.ToolStripMenuItem tsmi_ArpScan;
  }
}