//-----------------------------------------------------------------------
// <copyright file="SnifferMode.cs" company="hiLab">
//     Copyright (c) Francesco Iovine.
// </copyright>
// <author>Francesco Iovine iovinemeccanica@gmail.com</author>
//-----------------------------------------------------------------------
namespace SerialSniffer
{
    /// <summary>
    /// Enumerates the way the sniffer is connected: through a com0com
    /// virtual null-modem pair (Simulate) or through a Y-cable (YCable,
    /// read-only tap that does not relay data).
    /// </summary>
    public enum SnifferMode
    {
        Simulate,
        YCable
    }
}
