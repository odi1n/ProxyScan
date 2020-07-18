# ProxyScan-Api
Реализация Api для сервиса [ProxyScap](https://www.proxyscan.io/api)

Получить все прокси
```C#
var proxyScan = new ProxyScanApi();
var proxy = proxyScan.GetProxy();
foreach (var prox in proxy)
    Console.WriteLine(prox.ToString());
```

В этом примере мы получим только прокси SOCKS4, в количестве 5 штук
```C#
var proxyScan = new ProxyScanApi();
var proxy = proxyScan.GetProxy(type:ProxyScanIo.Enums.TypeProxy.SOCKS4, limit:5);
foreach (var prox in proxy)
    Console.WriteLine(prox.ToString());
```

#### Метод имеет следующие свойства
* Level(transparent, anonymous, elite)	Anonymity Level	
* Type(http, https, socks4, socks5) -	Proxy Protocol
* Last_Check - Any Number	Seconds the proxy was last checked
* Port -	Any Number	Proxies with a specific port
* Ping -	Any Number	How fast you get a response after you've sent out a request	
* Limit -	How many proxies to list.
* Uptime -	How reliably a proxy has been running
* Country	Example(US, FR) -	Country of the proxy
* Not_Country	Example(CN, NL) -	Avoid proxy countries	

#### Используется:
* Leaf.Xnet
* Newtonsoft.Json
