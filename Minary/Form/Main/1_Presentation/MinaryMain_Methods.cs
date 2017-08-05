﻿namespace Minary.Form
{
  using Minary.Common;
  using System;
  using System.ComponentModel;
  using System.IO;
  using System.Linq;
  using System.Windows.Forms;


  public partial class MinaryMain
  {

    #region MEMBERS

    public TabPage TabPagePluginCatalog { get { return this.tp_MinaryPluginCatalog; } }

    public TabControl TCPlugins { get { return this.tc_Plugins; } }

    public BindingList<PluginTableRecord> DgvUsedPlugins { get { return this.usedPlugins; } }

    private BackgroundWorker bgwOnStartAttack;
    private BackgroundWorker bgwOnStopAttack;

    #endregion


    #region PUBLIC

    public delegate void StartAttacksOnBackgroundDelegate();
    public void StartAttacksOnBackground()
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new StartAttacksOnBackgroundDelegate(this.StartAttacksOnBackground), new object[] { });
        return;
      }

      if (this.cb_Interfaces.SelectedIndex < 0)
      {
        throw new Exception("No network interface selected");

        // Stop the attack
      }
      else if (this.attackStarted)
      {
        this.Cursor = Cursors.WaitCursor;
        this.EnableGUIElements();

        if (!this.bgwOnStopAttack.IsBusy)
        {
          this.bgwOnStopAttack.RunWorkerAsync();
        }

        this.attackStarted = false;
        this.bt_Attack.BackgroundImage = (System.Drawing.Image)Properties.Resources.StartBig;
        this.Cursor = Cursors.Default;

      // Notify user to select at least one targetSystem system
      }
      else if (Debugging.IsDebuggingOn == false &&
               this.arpScanHandler.TargetList.Where(elem => elem.Attack == true).Count() <= 0)
      {
        MessageBox.Show("You have to select at least one targetSystem system.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


      // Start new attack
      }
      else
      {
        this.Cursor = Cursors.WaitCursor;
        this.DisableGuiElements();

        // Starting plugins in a background worker
        if (!this.bgwOnStartAttack.IsBusy)
        {
          this.bgwOnStartAttack.RunWorkerAsync(this.bgwOnStartAttack);
        }
        else
        {
          Minary.LogConsole.Main.LogConsole.LogInstance.LogMessage("Starting attack: Can't start plugins because of a colision with another attacking session");
        }

        this.attackStarted = true;
        this.bt_Attack.BackgroundImage = (System.Drawing.Image)Properties.Resources.StopBig;
        this.Cursor = Cursors.Default;
      }
    }

    #endregion


    #region PRIVATE
    
    /// <summary>
    ///
    /// </summary>
    private void DisableGuiElements()
    {
      this.bt_Attack.BackgroundImage = Properties.Resources.StartBig;
      this.bt_ScanLAN.Enabled = false;
      this.cb_Interfaces.Enabled = false;
      this.dgv_MainPlugins.Enabled = false;
      this.tb_NetworkStartIp.Enabled = false;
      this.tb_NetworkStopIp.Enabled = false;
      this.tsmi_LoadTemplate.Enabled = false;
      this.tsmi_GetUpdates.Enabled = false;
      this.tsmi_Exit.Enabled = false;
      this.tsmi_ResetMinary.Enabled = false;
      this.tsmi_DetectInterfaces.Enabled = false;
      this.tsmi_Debugging.Enabled = false;
      this.tsmi_LoadTemplate.Enabled = false;
      this.tsmi_CreateTemplate.Enabled = false;
      this.tsmi_UnloadTemplate.Enabled = false;
    }


    /// <summary>
    ///
    /// </summary>
    private void EnableGUIElements()
    {
      this.bt_Attack.BackgroundImage = Properties.Resources.StopBig;
      this.bt_ScanLAN.Enabled = true;
      this.cb_Interfaces.Enabled = true;
      this.dgv_MainPlugins.Enabled = true;
      this.tb_NetworkStartIp.Enabled = true;
      this.tb_NetworkStopIp.Enabled = true;
      this.tsmi_LoadTemplate.Enabled = true;
      this.tsmi_GetUpdates.Enabled = true;
      this.tsmi_Exit.Enabled = true;
      this.tsmi_ResetMinary.Enabled = true;
      this.tsmi_DetectInterfaces.Enabled = true;
      this.tsmi_Debugging.Enabled = true;
      this.tsmi_LoadTemplate.Enabled = true;
      this.tsmi_CreateTemplate.Enabled = true;
      this.tsmi_UnloadTemplate.Enabled = true;
    }


    public enum MinaryFileType
    {
      SessionFile,
      TemplateFile,
      Undetermined
    }


    private MinaryFileType DetermineFileType(string filePath)
    {
      if (this.templateTaskLayer.IsFileATemplate(filePath))
      {
        return MinaryFileType.TemplateFile;
      }
      else
      {
        return MinaryFileType.Undetermined;
      }
    }


    private void LoadUserTemplate(string cmdLineArgument)
    {
      MinaryFileType fileType = this.DetermineFileType(cmdLineArgument);

      if (fileType == MinaryFileType.TemplateFile)
      {
        Template.Presentation.LoadTemplate loadTemplatePresentation = null;
        try
        {
          loadTemplatePresentation = new Template.Presentation.LoadTemplate(this, cmdLineArgument);
        }
        catch (Exception ex)
        {
          string message = string.Format("Error 1 occurred while loading template file \"{0}\".\r\n\r\n{1}", Path.GetFileName(cmdLineArgument), ex.Message);
          MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          Minary.LogConsole.Main.LogConsole.LogInstance.LogMessage(message);
        }

        try
        {
          loadTemplatePresentation.ShowDialog();
        }
        catch (Exception ex)
        {
          string message = string.Format("Error 2 occurred while loading template file \"{0}\".\r\n\r\n{1}", Path.GetFileName(cmdLineArgument), ex.Message);
          MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          Minary.LogConsole.Main.LogConsole.LogInstance.LogMessage(message);
        }

        try
        {
          if (loadTemplatePresentation != null &&
              loadTemplatePresentation.TemplateData != null &&
              !string.IsNullOrEmpty(loadTemplatePresentation.TemplateData.TemplateConfig.Name))
          {
            this.tb_TemplateName.Text = loadTemplatePresentation.TemplateData.TemplateConfig.Name;
          }
        }
        catch (Exception ex)
        {
          string message = string.Format("Error 3 occurred while loading template file \"{0}\".\r\n\r\n{1}", Path.GetFileName(cmdLineArgument), ex.Message);
          MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          Minary.LogConsole.Main.LogConsole.LogInstance.LogMessage(message);

          this.pluginHandler.RestoreLastPluginLoadState();
        }
      }
      else
      {
        this.pluginHandler.RestoreLastPluginLoadState();
      }
    }


    #endregion

  }
}