namespace Fortis.Model
{
	using Fortis.Providers;

	public class CustomItemFactory : ItemFactory, ICustomItemFactory
	{
		public CustomItemFactory(IContextProvider contextProvider, ISpawnProvider spawnProvider) 
			: base(contextProvider, spawnProvider)
		{
		}
	}
}
