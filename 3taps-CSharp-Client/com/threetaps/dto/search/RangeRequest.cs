using System;
using System.Collections.Generic;

namespace com.threetaps.dto.search
{
	public class RangeRequest : IQueryRequest
	{
		public RangeRequest()
		{
			this.fields = new List<string>();
		}
		
		private SearchRequest searchRequest { get; set; }
		private List<string> fields { get; set; }
		
		public void addField(string field) {
			fields.Add(field);
		}
		
		public Dictionary<string, string> getQueryParams() {
			
			Dictionary<string, string> queryParams = searchRequest.getQueryParams();
			queryParams["fields"] =  Utils.Join(fields);
			
			return queryParams;
		}
	}
}