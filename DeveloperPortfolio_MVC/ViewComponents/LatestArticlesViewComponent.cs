using DeveloperPortfolio_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperPortfolio_MVC.ViewComponents
{
	public class LatestArticlesViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var articles = new List<ArticlesModel>
			{
				new ArticlesModel(1,"آموزش کور","asp.net core mvc","blog-post-thumb-card-1.jpg"),
				new ArticlesModel(2,"آموزش سی شارپ","csharp beginner to zero","blog-post-thumb-card-2.jpg"),
				new ArticlesModel(3,"آموزش جنگو","Django site","blog-post-thumb-card-3.jpg"),
				new ArticlesModel(4,"آموزش پایتون","Python For evryone","blog-post-thumb-card-4.jpg")
			};
			return View("_LatestArticles",articles);
		}
	}
}
