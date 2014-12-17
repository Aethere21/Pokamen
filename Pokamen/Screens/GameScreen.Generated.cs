#if ANDROID
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif


using BitmapFont = FlatRedBall.Graphics.BitmapFont;

using Cursor = FlatRedBall.Gui.Cursor;
using GuiManager = FlatRedBall.Gui.GuiManager;

#if XNA4 || WINDOWS_8
using Color = Microsoft.Xna.Framework.Color;
#elif FRB_MDX
using Color = System.Drawing.Color;
#else
using Color = Microsoft.Xna.Framework.Graphics.Color;
#endif

#if FRB_XNA || SILVERLIGHT
using Keys = Microsoft.Xna.Framework.Input.Keys;
using Vector3 = Microsoft.Xna.Framework.Vector3;
using Texture2D = Microsoft.Xna.Framework.Graphics.Texture2D;
using Microsoft.Xna.Framework.Media;
#endif

// Generated Usings
using Pokamen.Entities;
using Pokamen.Factories;
using FlatRedBall;
using FlatRedBall.Screens;
using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall.Math;
using FlatRedBall.Gum;

namespace Pokamen.Screens
{
	public partial class GameScreen : Screen
	{
		// Generated Fields
		#if DEBUG
		static bool HasBeenLoadedWithGlobalContentManager = false;
		#endif
		protected static FlatRedBall.Gum.GumIdb GameScreenGum;
		
		private Pokamen.Entities.Enemy EnemyInstance;
		private Pokamen.Entities.Player PlayerInstance;
		private PositionedObjectList<Pokamen.Entities.AttackEnemy> AttackEnemyList;
		private PositionedObjectList<Pokamen.Entities.AttackPlayer> AttackPlayerList;
		private Pokamen.Entities.CursorEntity CursorEntityInstance;

		public GameScreen()
			: base("GameScreen")
		{
		}

        public override void Initialize(bool addToManagers)
        {
			// Generated Initialize
			LoadStaticContent(ContentManagerName);
			EnemyInstance = new Pokamen.Entities.Enemy(ContentManagerName, false);
			EnemyInstance.Name = "EnemyInstance";
			PlayerInstance = new Pokamen.Entities.Player(ContentManagerName, false);
			PlayerInstance.Name = "PlayerInstance";
			AttackEnemyList = new PositionedObjectList<Pokamen.Entities.AttackEnemy>();
			AttackEnemyList.Name = "AttackEnemyList";
			AttackPlayerList = new PositionedObjectList<Pokamen.Entities.AttackPlayer>();
			AttackPlayerList.Name = "AttackPlayerList";
			CursorEntityInstance = new Pokamen.Entities.CursorEntity(ContentManagerName, false);
			CursorEntityInstance.Name = "CursorEntityInstance";
			
			
			PostInitialize();
			base.Initialize(addToManagers);
			if (addToManagers)
			{
				AddToManagers();
			}

        }
        
// Generated AddToManagers
		public override void AddToManagers ()
		{
			GameScreenGum.InstanceInitialize();
			AttackEnemyFactory.Initialize(AttackEnemyList, ContentManagerName);
			AttackPlayerFactory.Initialize(AttackPlayerList, ContentManagerName);
			EnemyInstance.AddToManagers(mLayer);
			PlayerInstance.AddToManagers(mLayer);
			CursorEntityInstance.AddToManagers(mLayer);
			base.AddToManagers();
			AddToManagersBottomUp();
			CustomInitialize();
		}


		public override void Activity(bool firstTimeCalled)
		{
			// Generated Activity
			if (!IsPaused)
			{
				
				EnemyInstance.Activity();
				PlayerInstance.Activity();
				for (int i = AttackEnemyList.Count - 1; i > -1; i--)
				{
					if (i < AttackEnemyList.Count)
					{
						// We do the extra if-check because activity could destroy any number of entities
						AttackEnemyList[i].Activity();
					}
				}
				for (int i = AttackPlayerList.Count - 1; i > -1; i--)
				{
					if (i < AttackPlayerList.Count)
					{
						// We do the extra if-check because activity could destroy any number of entities
						AttackPlayerList[i].Activity();
					}
				}
				CursorEntityInstance.Activity();
			}
			else
			{
			}
			base.Activity(firstTimeCalled);
			if (!IsActivityFinished)
			{
				CustomActivity(firstTimeCalled);
			}


				// After Custom Activity
				
            
		}

		public override void Destroy()
		{
			// Generated Destroy
			AttackEnemyFactory.Destroy();
			AttackPlayerFactory.Destroy();
			GameScreenGum.InstanceDestroy();
			GameScreenGum = null;
			
			AttackEnemyList.MakeOneWay();
			AttackPlayerList.MakeOneWay();
			if (EnemyInstance != null)
			{
				EnemyInstance.Destroy();
				EnemyInstance.Detach();
			}
			if (PlayerInstance != null)
			{
				PlayerInstance.Destroy();
				PlayerInstance.Detach();
			}
			for (int i = AttackEnemyList.Count - 1; i > -1; i--)
			{
				AttackEnemyList[i].Destroy();
			}
			for (int i = AttackPlayerList.Count - 1; i > -1; i--)
			{
				AttackPlayerList[i].Destroy();
			}
			if (CursorEntityInstance != null)
			{
				CursorEntityInstance.Destroy();
				CursorEntityInstance.Detach();
			}
			AttackEnemyList.MakeTwoWay();
			AttackPlayerList.MakeTwoWay();

			base.Destroy();

			CustomDestroy();

		}

		// Generated Methods
		public virtual void PostInitialize ()
		{
			bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
			FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
			FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
		}
		public virtual void AddToManagersBottomUp ()
		{
			CameraSetup.ResetCamera(SpriteManager.Camera);
			AssignCustomVariables(false);
		}
		public virtual void RemoveFromManagers ()
		{
			EnemyInstance.RemoveFromManagers();
			PlayerInstance.RemoveFromManagers();
			for (int i = AttackEnemyList.Count - 1; i > -1; i--)
			{
				AttackEnemyList[i].Destroy();
			}
			for (int i = AttackPlayerList.Count - 1; i > -1; i--)
			{
				AttackPlayerList[i].Destroy();
			}
			CursorEntityInstance.RemoveFromManagers();
		}
		public virtual void AssignCustomVariables (bool callOnContainedElements)
		{
			if (callOnContainedElements)
			{
				EnemyInstance.AssignCustomVariables(true);
				PlayerInstance.AssignCustomVariables(true);
				CursorEntityInstance.AssignCustomVariables(true);
			}
		}
		public virtual void ConvertToManuallyUpdated ()
		{
			EnemyInstance.ConvertToManuallyUpdated();
			PlayerInstance.ConvertToManuallyUpdated();
			for (int i = 0; i < AttackEnemyList.Count; i++)
			{
				AttackEnemyList[i].ConvertToManuallyUpdated();
			}
			for (int i = 0; i < AttackPlayerList.Count; i++)
			{
				AttackPlayerList[i].ConvertToManuallyUpdated();
			}
			CursorEntityInstance.ConvertToManuallyUpdated();
		}
		public static void LoadStaticContent (string contentManagerName)
		{
			if (string.IsNullOrEmpty(contentManagerName))
			{
				throw new ArgumentException("contentManagerName cannot be empty or null");
			}
			// Set the content manager for Gum
			var contentManagerWrapper = new FlatRedBall.Gum.ContentManagerWrapper();
			contentManagerWrapper.ContentManagerName = contentManagerName;
			RenderingLibrary.Content.LoaderManager.Self.ContentLoader = contentManagerWrapper;
			// Access the GumProject just in case it's async loaded
			var throwaway = GlobalContent.GumProject;
			#if DEBUG
			if (contentManagerName == FlatRedBallServices.GlobalContentManager)
			{
				HasBeenLoadedWithGlobalContentManager = true;
			}
			else if (HasBeenLoadedWithGlobalContentManager)
			{
				throw new Exception("This type has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
			}
			#endif
			if (!FlatRedBallServices.IsLoaded<FlatRedBall.Gum.GumIdb>(@"content/gumproject/screens/gamescreengum.gusx", contentManagerName))
			{
			}
			GameScreenGum = new GumIdb();  GameScreenGum.LoadFromFile("content/gumproject/screens/gamescreengum.gusx");  GameScreenGum.AssignReferences();
			Pokamen.Entities.Enemy.LoadStaticContent(contentManagerName);
			Pokamen.Entities.Player.LoadStaticContent(contentManagerName);
			Pokamen.Entities.CursorEntity.LoadStaticContent(contentManagerName);
			CustomLoadStaticContent(contentManagerName);
		}
		[System.Obsolete("Use GetFile instead")]
		public static object GetStaticMember (string memberName)
		{
			switch(memberName)
			{
				case  "GameScreenGum":
					return GameScreenGum;
			}
			return null;
		}
		public static object GetFile (string memberName)
		{
			switch(memberName)
			{
				case  "GameScreenGum":
					return GameScreenGum;
			}
			return null;
		}
		object GetMember (string memberName)
		{
			switch(memberName)
			{
				case  "GameScreenGum":
					return GameScreenGum;
			}
			return null;
		}


	}
}
