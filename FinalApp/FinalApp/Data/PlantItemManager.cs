using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp.Data
{
    public class PlantItemManager
    {
			IRestService restService;

			public PlantItemManager(IRestService service)
			{
				restService = service;
			}

			public Task<List<PlantItem>> GetTasksAsync(string term)
			{
				return restService.RefreshDataAsync(term);
			}
		}
}
