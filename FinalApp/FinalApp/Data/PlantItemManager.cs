using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp.Data
{
    class PlantItemManager
    {
			IRestService restService;

			public PlantItemManager(IRestService service)
			{
				restService = service;
			}

			public Task<List<PlantItem>> GetTasksAsync()
			{
				return restService.RefreshDataAsync();
			}
		}
}
