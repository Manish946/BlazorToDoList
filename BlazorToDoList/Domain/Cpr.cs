using BlazorToDoList.Data;

namespace BlazorToDoList.Domain
{
	public class Cpr
	{
		public int CprId { get; set; }
		public ApplicationUser User { get; set; }
		public string CprNr {  get; set; }
	}
}
