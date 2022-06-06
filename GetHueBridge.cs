using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using HueController;
using Rssdp;

using System.Net;
using System.Threading.Tasks;

public class GetHueBridge{
    public static string BridgeIP = null;

    public static string FindBridgeIP()
    {
        SsdpDeviceLocator deviceLocator = new SsdpDeviceLocator(GetLocalIPAddress().ToString());
        var foundDevices = deviceLocator.SearchAsync().Result.ToList();

        foreach (var device in foundDevices)
        {
            if (device.ResponseHeaders.ToString().Contains("IpBridge"))
            {
                BridgeIP = device.DescriptionLocation.Host;
                break;
            }
            BridgeIP = "ERROR:NOTFOUND";
        }

        HueBridge.ip = BridgeIP.ToString();
        HueBridge.name = "defaultname";
        return BridgeIP.ToString();
    }

    private static IPAddress GetLocalIPAddress()
    {
        if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            return null;

        return Dns.GetHostEntry(Dns.GetHostName())
            .AddressList
            .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);

    }
}