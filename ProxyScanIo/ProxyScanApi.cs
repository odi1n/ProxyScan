using ProxyScanIo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leaf.xNet;
using ProxyScanIo.Enums;
using Newtonsoft.Json;

namespace ProxyScanIo
{
    public class ProxyScanApi
    {
        private HttpRequest _request = new HttpRequest();

        /// <summary>
        /// Получить список прокси
        /// </summary>
        /// <param name="level">Anonymity Level</param>
        /// <param name="type">Proxy Protocol</param>
        /// <param name="lastCheck">Seconds the proxy was last checked</param>
        /// <param name="port">Proxies with a specific port	</param>
        /// <param name="ping">How fast you get a response after you've sent out a request	</param>
        /// <param name="limit">How many proxies to list. Maxsimum - 20</param>
        /// <param name="upTime">How reliably a proxy has been running. Minimum = 0, maximum - 100</param>
        /// <param name="country">Country of the proxy</param>
        /// <param name="notCountry">Avoid proxy countries</param>
        /// <returns></returns>
        public List<Proxy> GetProxy(Anonymity? level = null, TypeProxy? type = null, int? lastCheck = null, int? port = null, int? ping = null, int? limit = null
            , int? upTime = null, Country? country = null, Country? notCountry = null)
        {
            RequestParams param = new RequestParams()
            {
                ["level"]=level,
                ["type"]=type,
                ["last_check"]=lastCheck,
                ["port"]=port,
                ["ping"]=ping,
                ["limit"]=limit,
                ["uptime"] =upTime,
                ["country"]=country,
                ["not_country"]=notCountry,
            };
            var response = _request.Get("https://www.proxyscan.io/api/proxy", param).ToString().Replace("\r\n","").Trim();
            return JsonConvert.DeserializeObject<List<Proxy>>(response);
        }
    }
}
