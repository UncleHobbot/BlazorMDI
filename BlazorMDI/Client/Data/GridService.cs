using BlazorMDI.Shared.GridData;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorMDI.Client.Data
{
    public class GridService
    {
        private readonly HttpClient _client;
        public GridService(HttpClient client)
        {
            _client = client;
        }

        public Task<IEnumerable<FormMgmtGrid>> GetFormMgmtAsync(string appName, CancellationToken ct = default) 
            => _client.GetFromJsonAsync<IEnumerable<FormMgmtGrid>>($"api/Home/GetFormsList?appName={appName}", cancellationToken: ct);
    }
}
