﻿namespace Minary.Form.ArpScan.DataTypes
{
  using System;
  using System.Net;


  public static class IpHelper
  {

    #region PUBLIC

    /// <summary>
    ///
    /// </summary>
    /// <param name="IpAddress"></param>
    /// <returns></returns>
    public static int IPAddressToInt(IPAddress ipAddress)
    {
      var result = 0;

      byte[] bytes = ipAddress.GetAddressBytes();
      result = (int)(bytes[0] << 24 | bytes[1] << 16 | bytes[2] << 8 | bytes[3]);

      return result;
    }



    public static uint CastIp(string ip)
    {
      IPAddress address = IPAddress.Parse(ip);
      byte[] addressBytes = address.GetAddressBytes();

      // This restriction is implicit in your existing code, but
      // it would currently just lose data...
      if (addressBytes.Length != 4)
      {
        throw new ArgumentException("Must be an IPv4 address");
      }

      int networkOrder = BitConverter.ToInt32(addressBytes, 0);
      return (uint)IPAddress.NetworkToHostOrder(networkOrder);
    }



    public static IPAddress IntToIPAddress(int ipAddressInt)
    {
      return new IPAddress(ipAddressInt);
    }


    public static string IntToIpString(int ipAddressInt)
    {
      var ipAddress = new System.Net.IPAddress(BitConverter.GetBytes(ipAddressInt));
      var ipAddressString = ipAddress.ToString();

      return ipAddressString;
    }


    public static string UIntToIpString(uint ipAddressInt)
    {
      var ipAddress = new System.Net.IPAddress(BitConverter.GetBytes(ipAddressInt));
      var ipAddressString = ipAddress.ToString();

      return ipAddressString;
    }



 

    /// <summary>
    ///
    /// </summary>
    /// <param name="ipObj1"></param>
    /// <param name="ipObj2"></param>
    /// <returns></returns>
    public static long Compare(this IPAddress ipObj1, IPAddress ipObj2)
    {
      long ipAsInteger1 = IPAddressToInt(ipObj1);
      long ipAsInteger2 = IPAddressToInt(ipObj2);

      return (((ipAsInteger1 - ipAsInteger2) >> 0x1F) | (long)((uint)(-(ipAsInteger1 - ipAsInteger2)) >> 0x1F));
    }

    #endregion

  }
}
