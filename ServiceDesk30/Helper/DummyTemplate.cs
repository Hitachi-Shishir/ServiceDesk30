using System.Web.UI;
namespace ServiceDesk30.Helper
{
	public class DummyTemplate : ITemplate
	{
		public void InstantiateIn(Control container)
		{
			container.Controls.Add(new LiteralControl("&nbsp;"));
		}

	}
}