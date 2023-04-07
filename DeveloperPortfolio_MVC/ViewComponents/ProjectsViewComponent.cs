using DeveloperPortfolio_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperPortfolio_MVC.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var projects = new List<ProjectModel>
			{
				new ProjectModel(1,"تاکسی","درخواست آنلاین تاکسی","محمد بهنام","project-1.jpg"),
				new ProjectModel(2,"فود","درخواست آنلاین غذا","محمد بهنام","project-2.jpg"),
				new ProjectModel(3,"مارکت","درخواست آنلاین تغذیه","محمد بهنام","project-3.jpg"),
				new ProjectModel(4,"وانتسان","درخواست آنلاین وانت","محمد بهنام","project-4.jpg")
			};
			return View("_Projects",projects);
		}
	}
}
