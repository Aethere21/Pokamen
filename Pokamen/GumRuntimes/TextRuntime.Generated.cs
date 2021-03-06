	using System.Linq;
	namespace Pokamen.GumRuntimes
	{
		public partial class TextRuntime : Gum.Wireframe.GraphicalUiElement
		{
			public TextRuntime (bool fullInstantiation = true)
			{
				if (fullInstantiation)
				{
					Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.StandardElements.First(item => item.Name == "Text");
					this.ElementSave = elementSave;
					string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
					FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
					GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
					FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
					this.AssignReferences();
				}
			}
			RenderingLibrary.Graphics.Text mContainedText;
			RenderingLibrary.Graphics.Text ContainedText
			{
				get
				{
					if (mContainedText == null)
					{
						mContainedText = this.RenderableComponent as RenderingLibrary.Graphics.Text;
					}
					return mContainedText;
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
							Blue = 255;
							FontScale = 1;
							Green = 255;
							Height = 50;
							HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
							Red = 255;
							Text = "Hello";
							VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
							Visible = true;
							Width = 100;
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
				bool setFontScaleFirstValue = false;
				bool setFontScaleSecondValue = false;
				float FontScaleFirstValue= 0;
				float FontScaleSecondValue= 0;
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
						setBlueFirstValue = true;
						BlueFirstValue = 255;
						setFontScaleFirstValue = true;
						FontScaleFirstValue = 1;
						setGreenFirstValue = true;
						GreenFirstValue = 255;
						setHeightFirstValue = true;
						HeightFirstValue = 50;
						if (interpolationValue < 1)
						{
							this.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
						}
						setRedFirstValue = true;
						RedFirstValue = 255;
						if (interpolationValue < 1)
						{
							this.Text = "Hello";
						}
						if (interpolationValue < 1)
						{
							this.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
						}
						if (interpolationValue < 1)
						{
							this.Visible = true;
						}
						setWidthFirstValue = true;
						WidthFirstValue = 100;
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
						setBlueSecondValue = true;
						BlueSecondValue = 255;
						setFontScaleSecondValue = true;
						FontScaleSecondValue = 1;
						setGreenSecondValue = true;
						GreenSecondValue = 255;
						setHeightSecondValue = true;
						HeightSecondValue = 50;
						if (interpolationValue >= 1)
						{
							this.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
						}
						setRedSecondValue = true;
						RedSecondValue = 255;
						if (interpolationValue >= 1)
						{
							this.Text = "Hello";
						}
						if (interpolationValue >= 1)
						{
							this.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
						}
						if (interpolationValue >= 1)
						{
							this.Visible = true;
						}
						setWidthSecondValue = true;
						WidthSecondValue = 100;
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
				if (setFontScaleFirstValue && setFontScaleSecondValue)
				{
					FontScale = FontScaleFirstValue * (1 - interpolationValue) + FontScaleSecondValue * interpolationValue;
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
			public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Pokamen.GumRuntimes.TextRuntime.VariableState fromState,Pokamen.GumRuntimes.TextRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing)
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
							Name = "Blue",
							Value = Blue
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Font Scale",
							Value = FontScale
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
							Name = "HorizontalAlignment",
							Value = HorizontalAlignment
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
							Name = "Text",
							Value = Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "VerticalAlignment",
							Value = VerticalAlignment
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
							Name = "Blue",
							Value = Blue + 255
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Font Scale",
							Value = FontScale + 1
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
							Value = Height + 50
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "HorizontalAlignment",
							Value = HorizontalAlignment
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
							Name = "Text",
							Value = Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "VerticalAlignment",
							Value = VerticalAlignment
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
					return ContainedText.Alpha;
				}
				set
				{
					ContainedText.Alpha = value;
				}
			}
			public int Blue
			{
				get
				{
					return ContainedText.Blue;
				}
				set
				{
					ContainedText.Blue = value;
				}
			}
			public float FontScale
			{
				get
				{
					return ContainedText.FontScale;
				}
				set
				{
					ContainedText.FontScale = value;
				}
			}
			public int Green
			{
				get
				{
					return ContainedText.Green;
				}
				set
				{
					ContainedText.Green = value;
				}
			}
			public RenderingLibrary.Graphics.HorizontalAlignment HorizontalAlignment
			{
				get
				{
					return ContainedText.HorizontalAlignment;
				}
				set
				{
					ContainedText.HorizontalAlignment = value;
				}
			}
			public int Red
			{
				get
				{
					return ContainedText.Red;
				}
				set
				{
					ContainedText.Red = value;
				}
			}
			public string Text
			{
				get
				{
					return ContainedText.RawText;
				}
				set
				{
					ContainedText.RawText = value;
				}
			}
			public RenderingLibrary.Graphics.VerticalAlignment VerticalAlignment
			{
				get
				{
					return ContainedText.VerticalAlignment;
				}
				set
				{
					ContainedText.VerticalAlignment = value;
				}
			}
		}
	}
