using Pokamen.Entities;
using System;
using FlatRedBall.Math;
using FlatRedBall.Graphics;
using Pokamen.Performance;

namespace Pokamen.Factories
{
	public class AttackEnemyFactory : IEntityFactory
	{
		public static AttackEnemy CreateNew ()
		{
			return CreateNew(null);
		}
		public static AttackEnemy CreateNew (Layer layer)
		{
			if (string.IsNullOrEmpty(mContentManagerName))
			{
				throw new System.Exception("You must first initialize the factory to use it.");
			}
			AttackEnemy instance = null;
			instance = new AttackEnemy(mContentManagerName, false);
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
		
		public static void Initialize (PositionedObjectList<AttackEnemy> listFromScreen, string contentManager)
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
				AttackEnemy instance = new AttackEnemy(mContentManagerName, false);
				mPool.AddToPool(instance);
			}
		}
		
		/// <summary>
		/// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
		/// by generated code.  Use Destroy instead when writing custom code so that your code will behave
		/// the same whether your Entity is pooled or not.
		/// </summary>
		public static void MakeUnused (AttackEnemy objectToMakeUnused)
		{
			MakeUnused(objectToMakeUnused, true);
		}
		
		/// <summary>
		/// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
		/// by generated code.  Use Destroy instead when writing custom code so that your code will behave
		/// the same whether your Entity is pooled or not.
		/// </summary>
		public static void MakeUnused (AttackEnemy objectToMakeUnused, bool callDestroy)
		{
			objectToMakeUnused.Destroy();
		}
		
		
			static string mContentManagerName;
			static PositionedObjectList<AttackEnemy> mScreenListReference;
			static PoolList<AttackEnemy> mPool = new PoolList<AttackEnemy>();
			public static Action<AttackEnemy> EntitySpawned;
			object IEntityFactory.CreateNew ()
			{
				return AttackEnemyFactory.CreateNew();
			}
			object IEntityFactory.CreateNew (Layer layer)
			{
				return AttackEnemyFactory.CreateNew(layer);
			}
			public static PositionedObjectList<AttackEnemy> ScreenListReference
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
			static AttackEnemyFactory mSelf;
			public static AttackEnemyFactory Self
			{
				get
				{
					if (mSelf == null)
					{
						mSelf = new AttackEnemyFactory();
					}
					return mSelf;
				}
			}
	}
}
