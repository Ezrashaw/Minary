﻿namespace Minary.Form.GuiSimple.Presentation
{
  using Minary.Domain.MacVendor;
  using Minary.DataTypes.ArpScan;
  using Minary.Form.ArpScan.Task;
  using Minary.Form.GuiAdvanced;
  using System.ComponentModel;
  using System.Windows.Forms;


  public partial class GuiSimpleUserControl : UserControl
  {

    #region MEMBERS

    private MinaryMain minaryObj;
    protected BindingList<SystemFoundSimple> targetStringList = new BindingList<SystemFoundSimple>();
    private MacVendorHandler macVendorHandler = new MacVendorHandler();
    private ArpScan arpScanner = null;

    #endregion


    #region PUBLIC

    public GuiSimpleUserControl(MinaryMain minaryObj)
    {
      InitializeComponent();

      // Params
      this.minaryObj = minaryObj;

      // DataGridView columns declaration
      var columnIpAddress = new DataGridViewTextBoxColumn();
      columnIpAddress.DataPropertyName = "IpAddress";
      columnIpAddress.Name = "IpAddress";
      columnIpAddress.HeaderText = "IP Adresse";
      columnIpAddress.Visible = true;
      columnIpAddress.ReadOnly = true;
      columnIpAddress.Width = 200;
      this.dgv_GuiSimple.Columns.Add(columnIpAddress);

      var columnMacAddress = new DataGridViewImageColumn();
      columnMacAddress.DataPropertyName = "MacAddress";
      columnMacAddress.Name = "MacAddress";
      columnMacAddress.HeaderText = "MacAddress";
      columnMacAddress.Visible = false;
      columnMacAddress.ReadOnly = true;
      columnMacAddress.Width = 200;
      this.dgv_GuiSimple.Columns.Add(columnMacAddress);

      var columnAttack = new DataGridViewCheckBoxColumn();
      columnAttack.DataPropertyName = "Attack";
      columnAttack.Name = "Attack";
      columnAttack.HeaderText = "Attack";
      columnAttack.Visible = true;
      columnAttack.Width = 100;
      this.dgv_GuiSimple.Columns.Add(columnAttack);

      var columnLastSeen = new DataGridViewTextBoxColumn();
      columnLastSeen.DataPropertyName = "LastSeen";
      columnLastSeen.Name = "LastSeen";
      columnLastSeen.HeaderText = "Last seen";
      columnLastSeen.Visible = true;
      columnLastSeen.ReadOnly = true;
      columnLastSeen.Width = 100;
      columnLastSeen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      columnLastSeen.DefaultCellStyle.Format = "yyyy.MM.dd HH:mm:ss";
      this.dgv_GuiSimple.Columns.Add(columnLastSeen);

      // Initialize DGV data source list
      this.dgv_GuiSimple.DataSource = this.targetStringList;

      // Create member objects
      this.arpScanner = new ArpScan();

    }

    #endregion

  }
}
