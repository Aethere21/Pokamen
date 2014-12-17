#if ANDROID
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using System.Collections.Generic;
using System.Threading;
using FlatRedBall;
using FlatRedBall.Math.Geometry;
using FlatRedBall.ManagedSpriteGroups;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Utilities;
using BitmapFont = FlatRedBall.Graphics.BitmapFont;
using FlatRedBall.Localization;

namespace Pokamen
{
	public static partial class GlobalContent
	{
		
		public static FlatRedBall.Gum.GumIdb GumProject { get; set; }
		[System.Obsolete("Use GetFile instead")]
		public static object GetStaticMember (string memberName)
		{
			switch(memberName)
			{
				case  "GumProject":
					return GumProject;
			}
			return null;
		}
		public static object GetFile (string memberName)
		{
			switch(memberName)
			{
				case  "GumProject":
					return GumProject;
			}
			return null;
		}
		public static bool IsInitialized { get; private set; }
		public static bool ShouldStopLoading { get; set; }
		const string ContentManagerName = "Global";
		public static void Initialize ()
		{
			
			#if !REQUIRES_PRIMARY_THREAD_LOADING
			FlatRedBall.Gum.GumIdb.StaticInitialize("content/gumproject/gumproject.gumx"); FlatRedBall.Gum.GumIdb.RegisterTypes();  FlatRedBall.Gui.GuiManager.BringsClickedWindowsToFront = false; FlatRedBallServices.AddManager(RenderingLibrary.SystemManagers.Default);
			#endif
						IsInitialized = true;
		}
		public static void Reload (object whatToReload)
		{
		}
		
		
	}
}
