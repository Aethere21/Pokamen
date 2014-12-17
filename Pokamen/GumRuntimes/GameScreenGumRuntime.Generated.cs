	using System.Linq;
	namespace Pokamen.GumRuntimes
	{
		public partial class GameScreenGumRuntime : Gum.Wireframe.GraphicalUiElement
		{
			#region State Enums
			public enum VariableState
			{
				Default
			}
			#endregion
			#region State Fields
			VariableState mCurrentVariableState;
			#endregion
			#region State Properties
			public VariableState CurrentVariableState
			{
				get
				{
					return mCurrentVariableState;
				}
				set
				{
					mCurrentVariableState = value;
					switch(mCurrentVariableState)
					{
						case  VariableState.Default:
							Background.Height = 0;
							Background.SourceFile = RenderingLibrary.Content.LoaderManager.Self.Load("Content\\GameScreen\\Background.png", RenderingLibrary.SystemManagers.Default);
							Background.Width = 0;
							Background.X = 0;
							Background.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
							Background.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
							Background.Y = 0;
							Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
							Background.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
							EnemyHealthText.Height = 23;
							EnemyHealthText.Text = "Health: 100";
							EnemyHealthText.X = 300;
							EnemyHealthText.Y = 81;
							EnemyScoreBack.SourceFile = RenderingLibrary.Content.LoaderManager.Self.Load("Content\\GameScreen\\HealthBack.png", RenderingLibrary.SystemManagers.Default);
							EnemyScoreBack.X = 283;
							EnemyScoreBack.Y = 58;
							LastEnemyMoveText.Text = "Last Enemy Move: Do Nothing";
							LastEnemyMoveText.Width = 276;
							LastEnemyMoveText.X = 535;
							LastEnemyMoveText.Y = 375;
							MenuBack.SourceFile = RenderingLibrary.Content.LoaderManager.Self.Load("Content\\GameScreen\\MenuBack.png", RenderingLibrary.SystemManagers.Default);
							MenuBack.X = -251;
							MenuBack.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
							MenuBack.Y = -194;
							MenuBack.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
							PlayerHealthText.Height = 22;
							PlayerHealthText.Text = "Health: 100";
							PlayerHealthText.Width = 122;
							PlayerHealthText.X = 48;
							PlayerHealthText.Y = 273;
							PlayerScoreBack.SourceFile = RenderingLibrary.Content.LoaderManager.Self.Load("Content\\GameScreen\\HealthBack.png", RenderingLibrary.SystemManagers.Default);
							PlayerScoreBack.X = 31;
							PlayerScoreBack.Y = 251;
							ScoreText.Height = 31;
							ScoreText.Text = "Score: 0";
							ScoreText.Width = 236;
							ScoreText.X = 560;
							ScoreText.Y = 423;
							break;
					}
				}
			}
			#endregion
			#region State Interpolation
			public void InterpolateBetween (VariableState firstState, VariableState secondState, float interpolationValue)
			{
				#if DEBUG
				if (float.IsNaN(interpolationValue))
				{
					throw new System.Exception("interpolationValue cannot be NaN");
				}
				#endif
				bool setBackgroundHeightFirstValue = false;
				bool setBackgroundHeightSecondValue = false;
				float BackgroundHeightFirstValue= 0;
				float BackgroundHeightSecondValue= 0;
				bool setBackgroundWidthFirstValue = false;
				bool setBackgroundWidthSecondValue = false;
				float BackgroundWidthFirstValue= 0;
				float BackgroundWidthSecondValue= 0;
				bool setBackgroundXFirstValue = false;
				bool setBackgroundXSecondValue = false;
				float BackgroundXFirstValue= 0;
				float BackgroundXSecondValue= 0;
				bool setBackgroundYFirstValue = false;
				bool setBackgroundYSecondValue = false;
				float BackgroundYFirstValue= 0;
				float BackgroundYSecondValue= 0;
				bool setEnemyHealthTextHeightFirstValue = false;
				bool setEnemyHealthTextHeightSecondValue = false;
				float EnemyHealthTextHeightFirstValue= 0;
				float EnemyHealthTextHeightSecondValue= 0;
				bool setEnemyHealthTextXFirstValue = false;
				bool setEnemyHealthTextXSecondValue = false;
				float EnemyHealthTextXFirstValue= 0;
				float EnemyHealthTextXSecondValue= 0;
				bool setEnemyHealthTextYFirstValue = false;
				bool setEnemyHealthTextYSecondValue = false;
				float EnemyHealthTextYFirstValue= 0;
				float EnemyHealthTextYSecondValue= 0;
				bool setEnemyScoreBackXFirstValue = false;
				bool setEnemyScoreBackXSecondValue = false;
				float EnemyScoreBackXFirstValue= 0;
				float EnemyScoreBackXSecondValue= 0;
				bool setEnemyScoreBackYFirstValue = false;
				bool setEnemyScoreBackYSecondValue = false;
				float EnemyScoreBackYFirstValue= 0;
				float EnemyScoreBackYSecondValue= 0;
				bool setLastEnemyMoveTextWidthFirstValue = false;
				bool setLastEnemyMoveTextWidthSecondValue = false;
				float LastEnemyMoveTextWidthFirstValue= 0;
				float LastEnemyMoveTextWidthSecondValue= 0;
				bool setLastEnemyMoveTextXFirstValue = false;
				bool setLastEnemyMoveTextXSecondValue = false;
				float LastEnemyMoveTextXFirstValue= 0;
				float LastEnemyMoveTextXSecondValue= 0;
				bool setLastEnemyMoveTextYFirstValue = false;
				bool setLastEnemyMoveTextYSecondValue = false;
				float LastEnemyMoveTextYFirstValue= 0;
				float LastEnemyMoveTextYSecondValue= 0;
				bool setMenuBackXFirstValue = false;
				bool setMenuBackXSecondValue = false;
				float MenuBackXFirstValue= 0;
				float MenuBackXSecondValue= 0;
				bool setMenuBackYFirstValue = false;
				bool setMenuBackYSecondValue = false;
				float MenuBackYFirstValue= 0;
				float MenuBackYSecondValue= 0;
				bool setPlayerHealthTextHeightFirstValue = false;
				bool setPlayerHealthTextHeightSecondValue = false;
				float PlayerHealthTextHeightFirstValue= 0;
				float PlayerHealthTextHeightSecondValue= 0;
				bool setPlayerHealthTextWidthFirstValue = false;
				bool setPlayerHealthTextWidthSecondValue = false;
				float PlayerHealthTextWidthFirstValue= 0;
				float PlayerHealthTextWidthSecondValue= 0;
				bool setPlayerHealthTextXFirstValue = false;
				bool setPlayerHealthTextXSecondValue = false;
				float PlayerHealthTextXFirstValue= 0;
				float PlayerHealthTextXSecondValue= 0;
				bool setPlayerHealthTextYFirstValue = false;
				bool setPlayerHealthTextYSecondValue = false;
				float PlayerHealthTextYFirstValue= 0;
				float PlayerHealthTextYSecondValue= 0;
				bool setPlayerScoreBackXFirstValue = false;
				bool setPlayerScoreBackXSecondValue = false;
				float PlayerScoreBackXFirstValue= 0;
				float PlayerScoreBackXSecondValue= 0;
				bool setPlayerScoreBackYFirstValue = false;
				bool setPlayerScoreBackYSecondValue = false;
				float PlayerScoreBackYFirstValue= 0;
				float PlayerScoreBackYSecondValue= 0;
				bool setScoreTextHeightFirstValue = false;
				bool setScoreTextHeightSecondValue = false;
				float ScoreTextHeightFirstValue= 0;
				float ScoreTextHeightSecondValue= 0;
				bool setScoreTextWidthFirstValue = false;
				bool setScoreTextWidthSecondValue = false;
				float ScoreTextWidthFirstValue= 0;
				float ScoreTextWidthSecondValue= 0;
				bool setScoreTextXFirstValue = false;
				bool setScoreTextXSecondValue = false;
				float ScoreTextXFirstValue= 0;
				float ScoreTextXSecondValue= 0;
				bool setScoreTextYFirstValue = false;
				bool setScoreTextYSecondValue = false;
				float ScoreTextYFirstValue= 0;
				float ScoreTextYSecondValue= 0;
				switch(firstState)
				{
					case  VariableState.Default:
						setBackgroundHeightFirstValue = true;
						BackgroundHeightFirstValue = 0;
						if (interpolationValue < 1)
						{
							this.Background.SourceFile = RenderingLibrary.Content.LoaderManager.Self.Load("Content\\GameScreen\\Background.png", RenderingLibrary.SystemManagers.Default);
						}
						setBackgroundWidthFirstValue = true;
						BackgroundWidthFirstValue = 0;
						setBackgroundXFirstValue = true;
						BackgroundXFirstValue = 0;
						if (interpolationValue < 1)
						{
							this.Background.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
						}
						if (interpolationValue < 1)
						{
							this.Background.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
						}
						setBackgroundYFirstValue = true;
						BackgroundYFirstValue = 0;
						if (interpolationValue < 1)
						{
							this.Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
						}
						if (interpolationValue < 1)
						{
							this.Background.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
						}
						setEnemyHealthTextHeightFirstValue = true;
						EnemyHealthTextHeightFirstValue = 23;
						if (interpolationValue < 1)
						{
							this.EnemyHealthText.Text = "Health: 100";
						}
						setEnemyHealthTextXFirstValue = true;
						EnemyHealthTextXFirstValue = 300;
						setEnemyHealthTextYFirstValue = true;
						EnemyHealthTextYFirstValue = 81;
						if (interpolationValue < 1)
						{
							this.EnemyScoreBack.SourceFile = RenderingLibrary.Content.LoaderManager.Self.Load("Content\\GameScreen\\HealthBack.png", RenderingLibrary.SystemManagers.Default);
						}
						setEnemyScoreBackXFirstValue = true;
						EnemyScoreBackXFirstValue = 283;
						setEnemyScoreBackYFirstValue = true;
						EnemyScoreBackYFirstValue = 58;
						if (interpolationValue < 1)
						{
							this.LastEnemyMoveText.Text = "Last Enemy Move: Do Nothing";
						}
						setLastEnemyMoveTextWidthFirstValue = true;
						LastEnemyMoveTextWidthFirstValue = 276;
						setLastEnemyMoveTextXFirstValue = true;
						LastEnemyMoveTextXFirstValue = 535;
						setLastEnemyMoveTextYFirstValue = true;
						LastEnemyMoveTextYFirstValue = 375;
						if (interpolationValue < 1)
						{
							this.MenuBack.SourceFile = RenderingLibrary.Content.LoaderManager.Self.Load("Content\\GameScreen\\MenuBack.png", RenderingLibrary.SystemManagers.Default);
						}
						setMenuBackXFirstValue = true;
						MenuBackXFirstValue = -251;
						if (interpolationValue < 1)
						{
							this.MenuBack.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
						}
						setMenuBackYFirstValue = true;
						MenuBackYFirstValue = -194;
						if (interpolationValue < 1)
						{
							this.MenuBack.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
						}
						setPlayerHealthTextHeightFirstValue = true;
						PlayerHealthTextHeightFirstValue = 22;
						if (interpolationValue < 1)
						{
							this.PlayerHealthText.Text = "Health: 100";
						}
						setPlayerHealthTextWidthFirstValue = true;
						PlayerHealthTextWidthFirstValue = 122;
						setPlayerHealthTextXFirstValue = true;
						PlayerHealthTextXFirstValue = 48;
						setPlayerHealthTextYFirstValue = true;
						PlayerHealthTextYFirstValue = 273;
						if (interpolationValue < 1)
						{
							this.PlayerScoreBack.SourceFile = RenderingLibrary.Content.LoaderManager.Self.Load("Content\\GameScreen\\HealthBack.png", RenderingLibrary.SystemManagers.Default);
						}
						setPlayerScoreBackXFirstValue = true;
						PlayerScoreBackXFirstValue = 31;
						setPlayerScoreBackYFirstValue = true;
						PlayerScoreBackYFirstValue = 251;
						setScoreTextHeightFirstValue = true;
						ScoreTextHeightFirstValue = 31;
						if (interpolationValue < 1)
						{
							this.ScoreText.Text = "Score: 0";
						}
						setScoreTextWidthFirstValue = true;
						ScoreTextWidthFirstValue = 236;
						setScoreTextXFirstValue = true;
						ScoreTextXFirstValue = 560;
						setScoreTextYFirstValue = true;
						ScoreTextYFirstValue = 423;
						break;
				}
				switch(secondState)
				{
					case  VariableState.Default:
						setBackgroundHeightSecondValue = true;
						BackgroundHeightSecondValue = 0;
						if (interpolationValue >= 1)
						{
							this.Background.SourceFile = RenderingLibrary.Content.LoaderManager.Self.Load("Content\\GameScreen\\Background.png", RenderingLibrary.SystemManagers.Default);
						}
						setBackgroundWidthSecondValue = true;
						BackgroundWidthSecondValue = 0;
						setBackgroundXSecondValue = true;
						BackgroundXSecondValue = 0;
						if (interpolationValue >= 1)
						{
							this.Background.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
						}
						if (interpolationValue >= 1)
						{
							this.Background.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
						}
						setBackgroundYSecondValue = true;
						BackgroundYSecondValue = 0;
						if (interpolationValue >= 1)
						{
							this.Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
						}
						if (interpolationValue >= 1)
						{
							this.Background.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
						}
						setEnemyHealthTextHeightSecondValue = true;
						EnemyHealthTextHeightSecondValue = 23;
						if (interpolationValue >= 1)
						{
							this.EnemyHealthText.Text = "Health: 100";
						}
						setEnemyHealthTextXSecondValue = true;
						EnemyHealthTextXSecondValue = 300;
						setEnemyHealthTextYSecondValue = true;
						EnemyHealthTextYSecondValue = 81;
						if (interpolationValue >= 1)
						{
							this.EnemyScoreBack.SourceFile = RenderingLibrary.Content.LoaderManager.Self.Load("Content\\GameScreen\\HealthBack.png", RenderingLibrary.SystemManagers.Default);
						}
						setEnemyScoreBackXSecondValue = true;
						EnemyScoreBackXSecondValue = 283;
						setEnemyScoreBackYSecondValue = true;
						EnemyScoreBackYSecondValue = 58;
						if (interpolationValue >= 1)
						{
							this.LastEnemyMoveText.Text = "Last Enemy Move: Do Nothing";
						}
						setLastEnemyMoveTextWidthSecondValue = true;
						LastEnemyMoveTextWidthSecondValue = 276;
						setLastEnemyMoveTextXSecondValue = true;
						LastEnemyMoveTextXSecondValue = 535;
						setLastEnemyMoveTextYSecondValue = true;
						LastEnemyMoveTextYSecondValue = 375;
						if (interpolationValue >= 1)
						{
							this.MenuBack.SourceFile = RenderingLibrary.Content.LoaderManager.Self.Load("Content\\GameScreen\\MenuBack.png", RenderingLibrary.SystemManagers.Default);
						}
						setMenuBackXSecondValue = true;
						MenuBackXSecondValue = -251;
						if (interpolationValue >= 1)
						{
							this.MenuBack.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
						}
						setMenuBackYSecondValue = true;
						MenuBackYSecondValue = -194;
						if (interpolationValue >= 1)
						{
							this.MenuBack.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
						}
						setPlayerHealthTextHeightSecondValue = true;
						PlayerHealthTextHeightSecondValue = 22;
						if (interpolationValue >= 1)
						{
							this.PlayerHealthText.Text = "Health: 100";
						}
						setPlayerHealthTextWidthSecondValue = true;
						PlayerHealthTextWidthSecondValue = 122;
						setPlayerHealthTextXSecondValue = true;
						PlayerHealthTextXSecondValue = 48;
						setPlayerHealthTextYSecondValue = true;
						PlayerHealthTextYSecondValue = 273;
						if (interpolationValue >= 1)
						{
							this.PlayerScoreBack.SourceFile = RenderingLibrary.Content.LoaderManager.Self.Load("Content\\GameScreen\\HealthBack.png", RenderingLibrary.SystemManagers.Default);
						}
						setPlayerScoreBackXSecondValue = true;
						PlayerScoreBackXSecondValue = 31;
						setPlayerScoreBackYSecondValue = true;
						PlayerScoreBackYSecondValue = 251;
						setScoreTextHeightSecondValue = true;
						ScoreTextHeightSecondValue = 31;
						if (interpolationValue >= 1)
						{
							this.ScoreText.Text = "Score: 0";
						}
						setScoreTextWidthSecondValue = true;
						ScoreTextWidthSecondValue = 236;
						setScoreTextXSecondValue = true;
						ScoreTextXSecondValue = 560;
						setScoreTextYSecondValue = true;
						ScoreTextYSecondValue = 423;
						break;
				}
				if (setBackgroundHeightFirstValue && setBackgroundHeightSecondValue)
				{
					Background.Height = BackgroundHeightFirstValue * (1 - interpolationValue) + BackgroundHeightSecondValue * interpolationValue;
				}
				if (setBackgroundWidthFirstValue && setBackgroundWidthSecondValue)
				{
					Background.Width = BackgroundWidthFirstValue * (1 - interpolationValue) + BackgroundWidthSecondValue * interpolationValue;
				}
				if (setBackgroundXFirstValue && setBackgroundXSecondValue)
				{
					Background.X = BackgroundXFirstValue * (1 - interpolationValue) + BackgroundXSecondValue * interpolationValue;
				}
				if (setBackgroundYFirstValue && setBackgroundYSecondValue)
				{
					Background.Y = BackgroundYFirstValue * (1 - interpolationValue) + BackgroundYSecondValue * interpolationValue;
				}
				if (setEnemyHealthTextHeightFirstValue && setEnemyHealthTextHeightSecondValue)
				{
					EnemyHealthText.Height = EnemyHealthTextHeightFirstValue * (1 - interpolationValue) + EnemyHealthTextHeightSecondValue * interpolationValue;
				}
				if (setEnemyHealthTextXFirstValue && setEnemyHealthTextXSecondValue)
				{
					EnemyHealthText.X = EnemyHealthTextXFirstValue * (1 - interpolationValue) + EnemyHealthTextXSecondValue * interpolationValue;
				}
				if (setEnemyHealthTextYFirstValue && setEnemyHealthTextYSecondValue)
				{
					EnemyHealthText.Y = EnemyHealthTextYFirstValue * (1 - interpolationValue) + EnemyHealthTextYSecondValue * interpolationValue;
				}
				if (setEnemyScoreBackXFirstValue && setEnemyScoreBackXSecondValue)
				{
					EnemyScoreBack.X = EnemyScoreBackXFirstValue * (1 - interpolationValue) + EnemyScoreBackXSecondValue * interpolationValue;
				}
				if (setEnemyScoreBackYFirstValue && setEnemyScoreBackYSecondValue)
				{
					EnemyScoreBack.Y = EnemyScoreBackYFirstValue * (1 - interpolationValue) + EnemyScoreBackYSecondValue * interpolationValue;
				}
				if (setLastEnemyMoveTextWidthFirstValue && setLastEnemyMoveTextWidthSecondValue)
				{
					LastEnemyMoveText.Width = LastEnemyMoveTextWidthFirstValue * (1 - interpolationValue) + LastEnemyMoveTextWidthSecondValue * interpolationValue;
				}
				if (setLastEnemyMoveTextXFirstValue && setLastEnemyMoveTextXSecondValue)
				{
					LastEnemyMoveText.X = LastEnemyMoveTextXFirstValue * (1 - interpolationValue) + LastEnemyMoveTextXSecondValue * interpolationValue;
				}
				if (setLastEnemyMoveTextYFirstValue && setLastEnemyMoveTextYSecondValue)
				{
					LastEnemyMoveText.Y = LastEnemyMoveTextYFirstValue * (1 - interpolationValue) + LastEnemyMoveTextYSecondValue * interpolationValue;
				}
				if (setMenuBackXFirstValue && setMenuBackXSecondValue)
				{
					MenuBack.X = MenuBackXFirstValue * (1 - interpolationValue) + MenuBackXSecondValue * interpolationValue;
				}
				if (setMenuBackYFirstValue && setMenuBackYSecondValue)
				{
					MenuBack.Y = MenuBackYFirstValue * (1 - interpolationValue) + MenuBackYSecondValue * interpolationValue;
				}
				if (setPlayerHealthTextHeightFirstValue && setPlayerHealthTextHeightSecondValue)
				{
					PlayerHealthText.Height = PlayerHealthTextHeightFirstValue * (1 - interpolationValue) + PlayerHealthTextHeightSecondValue * interpolationValue;
				}
				if (setPlayerHealthTextWidthFirstValue && setPlayerHealthTextWidthSecondValue)
				{
					PlayerHealthText.Width = PlayerHealthTextWidthFirstValue * (1 - interpolationValue) + PlayerHealthTextWidthSecondValue * interpolationValue;
				}
				if (setPlayerHealthTextXFirstValue && setPlayerHealthTextXSecondValue)
				{
					PlayerHealthText.X = PlayerHealthTextXFirstValue * (1 - interpolationValue) + PlayerHealthTextXSecondValue * interpolationValue;
				}
				if (setPlayerHealthTextYFirstValue && setPlayerHealthTextYSecondValue)
				{
					PlayerHealthText.Y = PlayerHealthTextYFirstValue * (1 - interpolationValue) + PlayerHealthTextYSecondValue * interpolationValue;
				}
				if (setPlayerScoreBackXFirstValue && setPlayerScoreBackXSecondValue)
				{
					PlayerScoreBack.X = PlayerScoreBackXFirstValue * (1 - interpolationValue) + PlayerScoreBackXSecondValue * interpolationValue;
				}
				if (setPlayerScoreBackYFirstValue && setPlayerScoreBackYSecondValue)
				{
					PlayerScoreBack.Y = PlayerScoreBackYFirstValue * (1 - interpolationValue) + PlayerScoreBackYSecondValue * interpolationValue;
				}
				if (setScoreTextHeightFirstValue && setScoreTextHeightSecondValue)
				{
					ScoreText.Height = ScoreTextHeightFirstValue * (1 - interpolationValue) + ScoreTextHeightSecondValue * interpolationValue;
				}
				if (setScoreTextWidthFirstValue && setScoreTextWidthSecondValue)
				{
					ScoreText.Width = ScoreTextWidthFirstValue * (1 - interpolationValue) + ScoreTextWidthSecondValue * interpolationValue;
				}
				if (setScoreTextXFirstValue && setScoreTextXSecondValue)
				{
					ScoreText.X = ScoreTextXFirstValue * (1 - interpolationValue) + ScoreTextXSecondValue * interpolationValue;
				}
				if (setScoreTextYFirstValue && setScoreTextYSecondValue)
				{
					ScoreText.Y = ScoreTextYFirstValue * (1 - interpolationValue) + ScoreTextYSecondValue * interpolationValue;
				}
				if (interpolationValue < 1)
				{
					mCurrentVariableState = firstState;
				}
				else
				{
					mCurrentVariableState = secondState;
				}
			}
			#endregion
			#region State Interpolate To
			public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Pokamen.GumRuntimes.GameScreenGumRuntime.VariableState fromState,Pokamen.GumRuntimes.GameScreenGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing)
			{
				FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
				tweener.Owner = this;
				tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
				tweener.Start();
				StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
				return tweener;
			}
			public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing)
			{
				Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
				Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.AllStates.First(item => item.Name == toState.ToString());
				FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
				tweener.Owner = this;
				tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
				tweener.Start();
				StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
				return tweener;
			}
			public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing)
			{
				Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
				Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
				FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
				tweener.Owner = this;
				tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
				tweener.Start();
				StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
				return tweener;
			}
			#endregion
			#region State Animations
			#endregion
			public virtual void StopAnimations ()
			{
				// remove all instructions
				for(int i = FlatRedBall.Instructions.InstructionManager.Instructions.Count - 1; i > -1; i--)
				{
					var instruction = FlatRedBall.Instructions.InstructionManager.Instructions[i];
					if (instruction.Target == this)
					{
						FlatRedBall.Instructions.InstructionManager.Remove(instruction);
					}
				}
				StateInterpolationPlugin.TweenerManager.Self.StopAllTweenersOwnedBy(this);
			}
			#region Get Current Values on State
			private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (VariableState state)
			{
				Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
				switch(state)
				{
					case  VariableState.Default:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.Height",
							Value = Background.Height
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.SourceFile",
							Value = Background.SourceFile
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.Width",
							Value = Background.Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.X",
							Value = Background.X
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.X Origin",
							Value = Background.XOrigin
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.X Units",
							Value = Background.XUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.Y",
							Value = Background.Y
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.Y Origin",
							Value = Background.YOrigin
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.Y Units",
							Value = Background.YUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnemyHealthText.Height",
							Value = EnemyHealthText.Height
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnemyHealthText.Text",
							Value = EnemyHealthText.Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnemyHealthText.X",
							Value = EnemyHealthText.X
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnemyHealthText.Y",
							Value = EnemyHealthText.Y
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnemyScoreBack.SourceFile",
							Value = EnemyScoreBack.SourceFile
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnemyScoreBack.X",
							Value = EnemyScoreBack.X
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnemyScoreBack.Y",
							Value = EnemyScoreBack.Y
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "LastEnemyMoveText.Text",
							Value = LastEnemyMoveText.Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "LastEnemyMoveText.Width",
							Value = LastEnemyMoveText.Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "LastEnemyMoveText.X",
							Value = LastEnemyMoveText.X
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "LastEnemyMoveText.Y",
							Value = LastEnemyMoveText.Y
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "MenuBack.SourceFile",
							Value = MenuBack.SourceFile
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "MenuBack.X",
							Value = MenuBack.X
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "MenuBack.X Units",
							Value = MenuBack.XUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "MenuBack.Y",
							Value = MenuBack.Y
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "MenuBack.Y Units",
							Value = MenuBack.YUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "PlayerHealthText.Height",
							Value = PlayerHealthText.Height
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "PlayerHealthText.Text",
							Value = PlayerHealthText.Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "PlayerHealthText.Width",
							Value = PlayerHealthText.Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "PlayerHealthText.X",
							Value = PlayerHealthText.X
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "PlayerHealthText.Y",
							Value = PlayerHealthText.Y
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "PlayerScoreBack.SourceFile",
							Value = PlayerScoreBack.SourceFile
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "PlayerScoreBack.X",
							Value = PlayerScoreBack.X
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "PlayerScoreBack.Y",
							Value = PlayerScoreBack.Y
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ScoreText.Height",
							Value = ScoreText.Height
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ScoreText.Text",
							Value = ScoreText.Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ScoreText.Width",
							Value = ScoreText.Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ScoreText.X",
							Value = ScoreText.X
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ScoreText.Y",
							Value = ScoreText.Y
						}
						);
						break;
				}
				return newState;
			}
			private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (VariableState state)
			{
				Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
				switch(state)
				{
					case  VariableState.Default:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.Height",
							Value = Background.Height + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.SourceFile",
							Value = Background.SourceFile
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.Width",
							Value = Background.Width + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.X",
							Value = Background.X + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.X Origin",
							Value = Background.XOrigin
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.X Units",
							Value = Background.XUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.Y",
							Value = Background.Y + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.Y Origin",
							Value = Background.YOrigin
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Background.Y Units",
							Value = Background.YUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnemyHealthText.Height",
							Value = EnemyHealthText.Height + 23
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnemyHealthText.Text",
							Value = EnemyHealthText.Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnemyHealthText.X",
							Value = EnemyHealthText.X + 300
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnemyHealthText.Y",
							Value = EnemyHealthText.Y + 81
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnemyScoreBack.SourceFile",
							Value = EnemyScoreBack.SourceFile
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnemyScoreBack.X",
							Value = EnemyScoreBack.X + 283
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnemyScoreBack.Y",
							Value = EnemyScoreBack.Y + 58
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "LastEnemyMoveText.Text",
							Value = LastEnemyMoveText.Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "LastEnemyMoveText.Width",
							Value = LastEnemyMoveText.Width + 276
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "LastEnemyMoveText.X",
							Value = LastEnemyMoveText.X + 535
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "LastEnemyMoveText.Y",
							Value = LastEnemyMoveText.Y + 375
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "MenuBack.SourceFile",
							Value = MenuBack.SourceFile
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "MenuBack.X",
							Value = MenuBack.X + -251
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "MenuBack.X Units",
							Value = MenuBack.XUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "MenuBack.Y",
							Value = MenuBack.Y + -194
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "MenuBack.Y Units",
							Value = MenuBack.YUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "PlayerHealthText.Height",
							Value = PlayerHealthText.Height + 22
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "PlayerHealthText.Text",
							Value = PlayerHealthText.Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "PlayerHealthText.Width",
							Value = PlayerHealthText.Width + 122
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "PlayerHealthText.X",
							Value = PlayerHealthText.X + 48
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "PlayerHealthText.Y",
							Value = PlayerHealthText.Y + 273
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "PlayerScoreBack.SourceFile",
							Value = PlayerScoreBack.SourceFile
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "PlayerScoreBack.X",
							Value = PlayerScoreBack.X + 31
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "PlayerScoreBack.Y",
							Value = PlayerScoreBack.Y + 251
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ScoreText.Height",
							Value = ScoreText.Height + 31
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ScoreText.Text",
							Value = ScoreText.Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ScoreText.Width",
							Value = ScoreText.Width + 236
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ScoreText.X",
							Value = ScoreText.X + 560
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ScoreText.Y",
							Value = ScoreText.Y + 423
						}
						);
						break;
				}
				return newState;
			}
			#endregion
			private SpriteRuntime Background { get; set; }
			private SpriteRuntime MenuBack { get; set; }
			private SpriteRuntime EnemyScoreBack { get; set; }
			private SpriteRuntime PlayerScoreBack { get; set; }
			private TextRuntime ScoreText { get; set; }
			private TextRuntime LastEnemyMoveText { get; set; }
			private TextRuntime PlayerHealthText { get; set; }
			private TextRuntime EnemyHealthText { get; set; }
			public GameScreenGumRuntime (bool fullInstantiation = true)
			{
				if (fullInstantiation)
				{
					Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "GameScreenGum");
					this.ElementSave = elementSave;
					string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
					FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
					GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
					FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
					this.AssignReferences();
				}
			}
			public override void AssignReferences ()
			{
				base.AssignReferences();
				Background = this.GetGraphicalUiElementByName("Background") as SpriteRuntime;
				MenuBack = this.GetGraphicalUiElementByName("MenuBack") as SpriteRuntime;
				EnemyScoreBack = this.GetGraphicalUiElementByName("EnemyScoreBack") as SpriteRuntime;
				PlayerScoreBack = this.GetGraphicalUiElementByName("PlayerScoreBack") as SpriteRuntime;
				ScoreText = this.GetGraphicalUiElementByName("ScoreText") as TextRuntime;
				LastEnemyMoveText = this.GetGraphicalUiElementByName("LastEnemyMoveText") as TextRuntime;
				PlayerHealthText = this.GetGraphicalUiElementByName("PlayerHealthText") as TextRuntime;
				EnemyHealthText = this.GetGraphicalUiElementByName("EnemyHealthText") as TextRuntime;
			}
			public override void AddToManagers (RenderingLibrary.SystemManagers managers, RenderingLibrary.Graphics.Layer layer)
			{
				base.AddToManagers(managers, layer);
				CustomInitialize();
			}
			partial void CustomInitialize();
		}
	}
