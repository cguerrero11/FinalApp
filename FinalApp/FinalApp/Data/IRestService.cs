using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp.Data
{
	public interface IRestService
	{
        Task<List<PlantItem>> RefreshDataAsync();



	}
}
