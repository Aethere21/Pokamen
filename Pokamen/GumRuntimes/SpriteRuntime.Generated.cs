	using System.Linq;
	namespace Pokamen.GumRuntimes
	{
		public partial class SpriteRuntime : Gum.Wireframe.GraphicalUiElement
		{
			public SpriteRuntime (bool fullInstantiation = true)
			{
				if (fullInstantiation)
				{
					Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.StandardElements.First(item => item.Name == "Sprite");
					this.ElementSave = elementSave;
					string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
					FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
					GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
					FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
					this.AssignReferences();
				}
			}
			RenderingLibrary.Graphics.Sprite mContainedSprite;
			RenderingLibrary.Graphics.Sprite ContainedSprite
			{
				get
				{
					if (mContainedSprite == null)
					{
						mContainedSprite = this.RenderableComponent as RenderingLibrary.Graphics.Sprite;
					}
					return mContainedSprite;
				}
			}
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
							Alpha = 255;
							Animate = false;
							Blend = Gum.RenderingLibrary.Blend.Normal;
							Blue = 255;
							FlipHorizontal = false;
							FlipVertical = false;
							Green = 255;
							Height = 100;
							Red = 255;
							SourceFile = RenderingLibrary.Content.LoaderManager.Self.Load("", RenderingLibrary.SystemManagers.Default);
							TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
							TextureHeight = 0;
							TextureHeightScale = 0;
							TextureLeft = 0;
							TextureTop = 0;
							TextureWidth = 0;
							TextureWidthScale = 0;
							Visible = true;
							Width = 100;
							Wrap = false;
							X = 0;
							XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
							XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
							Y = 0;
							YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
							YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
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
				bool setAlphaFirstValue = false;
				bool setAlphaSecondValue = false;
				int AlphaFirstValue= 0;
				int AlphaSecondValue= 0;
				bool setBlueFirstValue = false;
				bool setBlueSecondValue = false;
				int BlueFirstValue= 0;
				int BlueSecondValue= 0;
				bool setGreenFirstValue = false;
				bool setGreenSecondValue = false;
				int GreenFirstValue= 0;
				int GreenSecondValue= 0;
				bool setHeightFirstValue = false;
				bool setHeightSecondValue = false;
				float HeightFirstValue= 0;
				float HeightSecondValue= 0;
				bool setRedFirstValue = false;
				bool setRedSecondValue = false;
				int RedFirstValue= 0;
				int RedSecondValue= 0;
				bool setTextureHeightFirstValue = false;
				bool setTextureHeightSecondValue = false;
				int TextureHeightFirstValue= 0;
				int TextureHeightSecondValue= 0;
				bool setTextureHeightScaleFirstValue = false;
				bool setTextureHeightScaleSecondValue = false;
				float TextureHeightScaleFirstValue= 0;
				float TextureHeightScaleSecondValue= 0;
				bool setTextureLeftFirstValue = false;
				bool setTextureLeftSecondValue = false;
				int TextureLeftFirstValue= 0;
				int TextureLeftSecondValue= 0;
				bool setTextureTopFirstValue = false;
				bool setTextureTopSecondValue = false;
				int TextureTopFirstValue= 0;
				int TextureTopSecondValue= 0;
				bool setTextureWidthFirstValue = false;
				bool setTextureWidthSecondValue = false;
				int TextureWidthFirstValue= 0;
				int TextureWidthSecondValue= 0;
				bool setTextureWidthScaleFirstValue = false;
				bool setTextureWidthScaleSecondValue = false;
				float TextureWidthScaleFirstValue= 0;
				float TextureWidthScaleSecondValue= 0;
				bool setWidthFirstValue = false;
				bool setWidthSecondValue = false;
				float WidthFirstValue= 0;
				float WidthSecondValue= 0;
				bool setXFirstValue = false;
				bool setXSecondValue = false;
				float XFirstValue= 0;
				float XSecondValue= 0;
				bool setYFirstValue = false;
				bool setYSecondValue = false;
				float YFirstValue= 0;
				float YSecondValue= 0;
				switch(firstState)
				{
					case  VariableState.Default:
						setAlphaFirstValue = true;
						AlphaFirstValue = 255;
						if (interpolationValue < 1)
						{
							this.Animate = false;
						}
						if (interpolationValue < 1)
						{
							this.Blend = Gum.RenderingLibrary.Blend.Normal;
						}
						setBlueFirstValue = true;
						BlueFirstValue = 255;
						if (interpolationValue < 1)
						{
							this.FlipHorizontal = false;
						}
						if (interpolationValue < 1)
						{
							this.FlipVertical = false;
						}
						setGreenFirstValue = true;
						GreenFirstValue = 255;
						setHeightFirstValue = true;
						HeightFirstValue = 100;
						setRedFirstValue = true;
						RedFirstValue = 255;
						if (interpolationValue < 1)
						{
							this.SourceFile = RenderingLibrary.Content.LoaderManager.Self.Load("", RenderingLibrary.SystemManagers.Default);
						}
						if (interpolationValue < 1)
						{
							this.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
						}
						setTextureHeightFirstValue = true;
						TextureHeightFirstValue = 0;
						setTextureHeightScaleFirstValue = true;
						TextureHeightScaleFirstValue = 0;
						setTextureLeftFirstValue = true;
						TextureLeftFirstValue = 0;
						setTextureTopFirstValue = true;
						TextureTopFirstValue = 0;
						setTextureWidthFirstValue = true;
						TextureWidthFirstValue = 0;
						setTextureWidthScaleFirstValue = true;
						TextureWidthScaleFirstValue = 0;
						if (interpolationValue < 1)
						{
							this.Visible = true;
						}
						setWidthFirstValue = true;
						WidthFirstValue = 100;
						if (interpolationValue < 1)
						{
							this.Wrap = false;
						}
						setXFirstValue = true;
						XFirstValue = 0;
						if (interpolationValue < 1)
						{
							this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
						}
						if (interpolationValue < 1)
						{
							this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
						}
						setYFirstValue = true;
						YFirstValue = 0;
						if (interpolationValue < 1)
						{
							this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
						}
						if (interpolationValue < 1)
						{
							this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
						}
						break;
				}
				switch(secondState)
				{
					case  VariableState.Default:
						setAlphaSecondValue = true;
						AlphaSecondValue = 255;
						if (interpolationValue >= 1)
						{
							this.Animate = false;
						}
						if (interpolationValue >= 1)
						{
							this.Blend = Gum.RenderingLibrary.Blend.Normal;
						}
						setBlueSecondValue = true;
						BlueSecondValue = 255;
						if (interpolationValue >= 1)
						{
							this.FlipHorizontal = false;
						}
						if (interpolationValue >= 1)
						{
							this.FlipVertical = false;
						}
						setGreenSecondValue = true;
						GreenSecondValue = 255;
						setHeightSecondValue = true;
						HeightSecondValue = 100;
						setRedSecondValue = true;
						RedSecondValue = 255;
						if (interpolationValue >= 1)
						{
							this.SourceFile = RenderingLibrary.Content.LoaderManager.Self.Load("", RenderingLibrary.SystemManagers.Default);
						}
						if (interpolationValue >= 1)
						{
							this.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
						}
						setTextureHeightSecondValue = true;
						TextureHeightSecondValue = 0;
						setTextureHeightScaleSecondValue = true;
						TextureHeightScaleSecondValue = 0;
						setTextureLeftSecondValue = true;
						TextureLeftSecondValue = 0;
						setTextureTopSecondValue = true;
						TextureTopSecondValue = 0;
						setTextureWidthSecondValue = true;
						TextureWidthSecondValue = 0;
						setTextureWidthScaleSecondValue = true;
						TextureWidthScaleSecondValue = 0;
						if (interpolationValue >= 1)
						{
							this.Visible = true;
						}
						setWidthSecondValue = true;
						WidthSecondValue = 100;
						if (interpolationValue >= 1)
						{
							this.Wrap = false;
						}
						setXSecondValue = true;
						XSecondValue = 0;
						if (interpolationValue >= 1)
						{
							this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
						}
						if (interpolationValue >= 1)
						{
							this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
						}
						setYSecondValue = true;
						YSecondValue = 0;
						if (interpolationValue >= 1)
						{
							this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
						}
						if (interpolationValue >= 1)
						{
							this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
						}
						break;
				}
				if (setAlphaFirstValue && setAlphaSecondValue)
				{
					Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(AlphaFirstValue* (1 - interpolationValue) + AlphaSecondValue * interpolationValue);
				}
				if (setBlueFirstValue && setBlueSecondValue)
				{
					Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BlueFirstValue* (1 - interpolationValue) + BlueSecondValue * interpolationValue);
				}
				if (setGreenFirstValue && setGreenSecondValue)
				{
					Green = FlatRedBall.Math.MathFunctions.RoundToInt(GreenFirstValue* (1 - interpolationValue) + GreenSecondValue * interpolationValue);
				}
				if (setHeightFirstValue && setHeightSecondValue)
				{
					Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
				}
				if (setRedFirstValue && setRedSecondValue)
				{
					Red = FlatRedBall.Math.MathFunctions.RoundToInt(RedFirstValue* (1 - interpolationValue) + RedSecondValue * interpolationValue);
				}
				if (setTextureHeightFirstValue && setTextureHeightSecondValue)
				{
					TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(TextureHeightFirstValue* (1 - interpolationValue) + TextureHeightSecondValue * interpolationValue);
				}
				if (setTextureHeightScaleFirstValue && setTextureHeightScaleSecondValue)
				{
					TextureHeightScale = TextureHeightScaleFirstValue * (1 - interpolationValue) + TextureHeightScaleSecondValue * interpolationValue;
				}
				if (setTextureLeftFirstValue && setTextureLeftSecondValue)
				{
					TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TextureLeftFirstValue* (1 - interpolationValue) + TextureLeftSecondValue * interpolationValue);
				}
				if (setTextureTopFirstValue && setTextureTopSecondValue)
				{
					TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TextureTopFirstValue* (1 - interpolationValue) + TextureTopSecondValue * interpolationValue);
				}
				if (setTextureWidthFirstValue && setTextureWidthSecondValue)
				{
					TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(TextureWidthFirstValue* (1 - interpolationValue) + TextureWidthSecondValue * interpolationValue);
				}
				if (setTextureWidthScaleFirstValue && setTextureWidthScaleSecondValue)
				{
					TextureWidthScale = TextureWidthScaleFirstValue * (1 - interpolationValue) + TextureWidthScaleSecondValue * interpolationValue;
				}
				if (setWidthFirstValue && setWidthSecondValue)
				{
					Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
				}
				if (setXFirstValue && setXSecondValue)
				{
					X = XFirstValue * (1 - interpolationValue) + XSecondValue * interpolationValue;
				}
				if (setYFirstValue && setYSecondValue)
				{
					Y = YFirstValue * (1 - interpolationValue) + YSecondValue * interpolationValue;
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
			public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Pokamen.GumRuntimes.SpriteRuntime.VariableState fromState,Pokamen.GumRuntimes.SpriteRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing)
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
							Name = "Alpha",
							Value = Alpha
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Animate",
							Value = Animate
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Blend",
							Value = Blend
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Blue",
							Value = Blue
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "FlipHorizontal",
							Value = FlipHorizontal
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "FlipVertical",
							Value = FlipVertical
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Green",
							Value = Green
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Height",
							Value = Height
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Red",
							Value = Red
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SourceFile",
							Value = SourceFile
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Texture Address",
							Value = TextureAddress
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Texture Height",
							Value = TextureHeight
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Texture Height Scale",
							Value = TextureHeightScale
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Texture Left",
							Value = TextureLeft
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Texture Top",
							Value = TextureTop
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Texture Width",
							Value = TextureWidth
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Texture Width Scale",
							Value = TextureWidthScale
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Visible",
							Value = Visible
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Width",
							Value = Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Wrap",
							Value = Wrap
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "X",
							Value = X
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "X Origin",
							Value = XOrigin
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "X Units",
							Value = XUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Y",
							Value = Y
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Y Origin",
							Value = YOrigin
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Y Units",
							Value = YUnits
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
							Name = "Alpha",
							Value = Alpha + 255
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Animate",
							Value = Animate
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Blend",
							Value = Blend
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Blue",
							Value = Blue + 255
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "FlipHorizontal",
							Value = FlipHorizontal
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "FlipVertical",
							Value = FlipVertical
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Green",
							Value = Green + 255
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Height",
							Value = Height + 100
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Red",
							Value = Red + 255
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SourceFile",
							Value = SourceFile
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Texture Address",
							Value = TextureAddress
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Texture Height",
							Value = TextureHeight + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Texture Height Scale",
							Value = TextureHeightScale + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Texture Left",
							Value = TextureLeft + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Texture Top",
							Value = TextureTop + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Texture Width",
							Value = TextureWidth + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Texture Width Scale",
							Value = TextureWidthScale + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Visible",
							Value = Visible
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Width",
							Value = Width + 100
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Wrap",
							Value = Wrap
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "X",
							Value = X + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "X Origin",
							Value = XOrigin
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "X Units",
							Value = XUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Y",
							Value = Y + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Y Origin",
							Value = YOrigin
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Y Units",
							Value = YUnits
						}
						);
						break;
				}
				return newState;
			}
			#endregion
			public int Alpha
			{
				get
				{
					return ContainedSprite.Alpha;
				}
				set
				{
					ContainedSprite.Alpha = value;
				}
			}
			public bool Animate
			{
				get
				{
					return ContainedSprite.Animate;
				}
				set
				{
					ContainedSprite.Animate = value;
				}
			}
			public Gum.RenderingLibrary.Blend Blend
			{
				get
				{
					return Gum.RenderingLibrary.BlendExtensions.ToBlend(ContainedSprite.BlendState);
				}
				set
				{
					ContainedSprite.BlendState = Gum.RenderingLibrary.BlendExtensions.ToBlendState(value);
				}
			}
			public int Blue
			{
				get
				{
					return ContainedSprite.Blue;
				}
				set
				{
					ContainedSprite.Blue = value;
				}
			}
			public bool FlipHorizontal
			{
				get
				{
					return ContainedSprite.FlipHorizontal;
				}
				set
				{
					ContainedSprite.FlipHorizontal = value;
				}
			}
			public bool FlipVertical
			{
				get
				{
					return ContainedSprite.FlipVertical;
				}
				set
				{
					ContainedSprite.FlipVertical = value;
				}
			}
			public int Green
			{
				get
				{
					return ContainedSprite.Green;
				}
				set
				{
					ContainedSprite.Green = value;
				}
			}
			public int Red
			{
				get
				{
					return ContainedSprite.Red;
				}
				set
				{
					ContainedSprite.Red = value;
				}
			}
			public Microsoft.Xna.Framework.Graphics.Texture2D SourceFile
			{
				get
				{
					return ContainedSprite.Texture;
				}
				set
				{
					ContainedSprite.Texture = value;
				}
			}
			public bool Wrap
			{
				get
				{
					return ContainedSprite.Wrap;
				}
				set
				{
					ContainedSprite.Wrap = value;
				}
			}
		}
	}
