﻿using System.Threading;
using System.Threading.Tasks;

namespace CheckProxy.Core.Proxy
{
    public interface IProxyService
    {
        Task<IProxyInfo> GetProxyInformationAsync(string host, ushort port, CancellationToken cancellationToken);
    }
}