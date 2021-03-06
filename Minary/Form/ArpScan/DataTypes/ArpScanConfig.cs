﻿namespace Minary.Form.ArpScan.DataTypes
{
  using Minary.DataTypes.ArpScan;
  using System;


  public delegate void OnReplyDataCallback(SystemFound newSystem);

  public delegate void OnRequestSentCallback(string requestData);


  public class ArpScanConfig
  {

    #region PROPERTIES

    public string InterfaceId { get; set; }

    public string GatewayIp { get; set; }

    public string LocalIp { get; set; }

    public string LocalMac { get; set; }

    public string NetworkStartIp { get; set; }

    public uint NetworkStartIpUint { get; set; }

    public string NetworkStopIp { get; set; }

    public uint NetworkStopIpUint { get; set; }

    public uint StartStopCounter { get; set; }

    public uint TotalSystemsToScan { get; set; }

    public Action OnArpScanStopped { get; set; }


    public OnReplyDataCallback OnReplyDataReceived { get; set; }

    public OnRequestSentCallback OnRequestSent { get; set; }

    public bool IsDebuggingOn { get; set; }
    
    #endregion

  }
}