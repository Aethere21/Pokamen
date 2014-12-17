	namespace FlatRedBall.Gum
	{
		public partial class GumIdb
		{
			public static void RegisterTypes ()
			{
				GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("ColoredRectangle", typeof(Pokamen.GumRuntimes.ColoredRectangleRuntime));
				GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Container", typeof(Pokamen.GumRuntimes.ContainerRuntime));
				GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("NineSlice", typeof(Pokamen.GumRuntimes.NineSliceRuntime));
				GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Sprite", typeof(Pokamen.GumRuntimes.SpriteRuntime));
				GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Text", typeof(Pokamen.GumRuntimes.TextRuntime));
				GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("AboutScreenGum", typeof(Pokamen.GumRuntimes.AboutScreenGumRuntime));
				GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("GameScreenGum", typeof(Pokamen.GumRuntimes.GameScreenGumRuntime));
				GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("MenuScreenGum", typeof(Pokamen.GumRuntimes.MenuScreenGumRuntime));
			}
		}
	}
