using Pokamen.Entities;
using System;
using FlatRedBall.Math;
using FlatRedBall.Graphics;
using Pokamen.Performance;

namespace Pokamen.Factories
{
	public class AttackPlayerFactory : IEntityFactory
	{
		public static AttackPlayer CreateNew ()
		{
			return CreateNew(null);
		}
		public static AttackPlayer CreateNew (Layer layer)
		{
			if (string.IsNullOrEmpty(mContentManagerName))
			{
				throw new System.Exception("You must first initialize the factory to use it.");
			}
			AttackPlayer instance = null;
			instance = new AttackPlayer(mContentManagerName, false);
			instance.AddToManagers(layer);
			if (mScreenListReference != null)
			{
				mScreenListReference.Add(instance);
			}
			if (EntitySpawned != null)
			{
				EntitySpawned(instance);
			}
			return instance;
		}
		
		public static void Initialize (PositionedObjectList<AttackPlayer> listFromScreen, string contentManager)
		{
			mContentManagerName = contentManager;
			mScreenListReference = listFromScreen;
		}
		
		public static void Destroy ()
		{
			mContentManagerName = null;
			mScreenListReference = null;
			mPool.Clear();
			EntitySpawned = null;
		}
		
		private static void FactoryInitialize ()
		{
			const int numberToPreAllocate = 20;
			for (int i = 0; i < numberToPreAllocate; i++)
			{
				AttackPlayer instance = new AttackPlayer(mContentManagerName, false);
				mPool.AddToPool(instance);
			}
		}
		
		/// <summary>
		/// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
		/// by generated code.  Use Destroy instead when writing custom code so that your code will behave
		/// the same whether your Entity is pooled or not.
		/// </summary>
		public static void MakeUnused (AttackPlayer objectToMakeUnused)
		{
			MakeUnused(objectToMakeUnused, true);
		}
		
		/// <summary>
		/// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
		/// by generated code.  Use Destroy instead when writing custom code so that your code will behave
		/// the same whether your Entity is pooled or not.
		/// </summary>
		public static void MakeUnused (AttackPlayer objectToMakeUnused, bool callDestroy)
		{
			objectToMakeUnused.Destroy();
		}
		
		
			static string mContentManagerName;
			static PositionedObjectList<AttackPlayer> mScreenListReference;
			static PoolList<AttackPlayer> mPool = new PoolList<AttackPlayer>();
			public static Action<AttackPlayer> EntitySpawned;
			object IEntityFactory.CreateNew ()
			{
				return AttackPlayerFactory.CreateNew();
			}
			object IEntityFactory.CreateNew (Layer layer)
			{
				return AttackPlayerFactory.CreateNew(layer);
			}
			public static PositionedObjectList<AttackPlayer> ScreenListReference
			{
				get
				{
					return mScreenListReference;
				}
				set
				{
					mScreenListReference = value;
				}
			}
			static AttackPlayerFactory mSelf;
			public static AttackPlayerFactory Self
			{
				get
				{
					if (mSelf == null)
					{
						mSelf = new AttackPlayerFactory();
					}
					return mSelf;
				}
			}
	}
}
