﻿namespace Minary
{
  using Minary.Form;
  using Minary.Form.GuiAdvanced;
  using System;
  using System.IO;
  using System.Windows.Forms;


  public static class Program
  {

    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    [STAThread]
    public static void Main(string[] args)
    {
      OperatingSystem operatingSystem = Environment.OSVersion;
      Version operatingSystemVersion = operatingSystem.Version;

      Application.SetCompatibleTextRenderingDefault(false);

      // Initialization
      Directory.SetCurrentDirectory(Application.StartupPath);
      DirectoryChecks(Application.StartupPath);

      Application.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
      Application.EnableVisualStyles();

      // Load GUI
      try
      {
        var minaryGuiObj = new MinaryMain(args);
        minaryGuiObj.LoadAllFormElements();
        minaryGuiObj.StartAllHandlers();
        minaryGuiObj.StartBackgroundThreads();
        minaryGuiObj.PreRun();
        minaryGuiObj.SetMinaryState();
        Application.Run(minaryGuiObj);
      }
      catch (Exception ex)
      {
        var message = $"Minary: The following error occured: {ex.Message}\r\n\r\nStacktrace: {ex.StackTrace}";
        MessageDialog.Inst.ShowError(string.Empty, message, null);
      }
    }


    /// <summary>
    ///
    /// </summary>
    /// <param name="baseDir"></param>
    private static void DirectoryChecks(string baseDir)
    {
      string[] directoryList = new string[]
                            {
                              Config.AttackServicesPluginsDir,
                              Config.PluginsDir,
                              Config.TemplatesDir,
                              Config.CustomTemplatesDir,
//                              Config.DataDir,
                              Config.MinaryDllDir
                            };

      foreach (string tmpDirectoryPath in directoryList)
      {
        try
        {
          string tmpAttackServiceDirectory = $@"{baseDir}\{tmpDirectoryPath}";
          if (!Directory.Exists(tmpAttackServiceDirectory))
          {
            Directory.CreateDirectory(tmpAttackServiceDirectory);
          }
        }
        catch (Exception ex)
        {
          string message = $"Error occurred while creating \"{tmpDirectoryPath}\"\r\nMessage: {ex.Message}";
          MessageDialog.Inst.ShowError(string.Empty, message, null);
        }
      }
    }
  }
}
