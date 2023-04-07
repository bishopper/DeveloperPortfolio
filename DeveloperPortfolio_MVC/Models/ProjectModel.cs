namespace DeveloperPortfolio_MVC.Models
{
	public class ProjectModel
	{
		public long Id { get; set; }
		public string Name { get; set; }

		public string Description { get; set; }
        public string Image { get; set; }
        public string Client { get; set; }

		public ProjectModel(long id, string name, string description, string client, string image)
		{
			Id = id;
			Name = name;
			Description = description;
			Client = client;
			Image = image;
		}
	}
}
