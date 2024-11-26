using CatGirlNet.RA2.Protocol.Common;
using Microsoft.AspNetCore.SignalR.Client;

namespace CatGirlNet.RA2.Client.Core;

public class OnlineClient
{
    public delegate void RelayReceiver(RelayData data);

    public event RelayReceiver? OnRelay;
    
    private HubConnection Connection { get; }
    
    public OnlineClient(string url)
    {
        Connection = new HubConnectionBuilder()
            .WithUrl(url)
            .WithStatefulReconnect()
            .WithAutomaticReconnect()
            .Build();

        Connection.On<RelayData>("OnRelay", Relay);
    }

    public async void Connect()
    {
        await Connection.StartAsync();
    }

    public async void Disconnect()
    {
        await Connection.StopAsync();
    }

    public async void Send(RelayData data)
    {
        await Connection.InvokeAsync<RelayData>("Relay", data);
    }

    protected virtual void Relay(RelayData data)
    {
        OnRelay?.Invoke(data);
    }
}