namespace DeveloperPortfolio_MVC.Models
{
	public class ArticlesModel
	{
		public long Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }

		public ArticlesModel(long id, string title, string description, string image)
		{
			Id = id;
			Title = title;
			Description = description;
			Image = image;
		}
	}

}
