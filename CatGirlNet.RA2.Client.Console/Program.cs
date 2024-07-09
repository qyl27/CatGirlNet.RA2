using System.Net;
using CatGirlNet.RA2.Client.Core;

var url = args[0];
var local = args[1];

Console.WriteLine(url);
Console.WriteLine(local);

var client = new OnlineClient(url);
var receiver = new GameRelay(client, new IPEndPoint(IPAddress.Any, 5000), IPEndPoint.Parse(local));

client.Connect();
receiver.Start();

Console.WriteLine("Online!");

while (true)
{
    
}
