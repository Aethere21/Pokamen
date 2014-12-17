using FlatRedBall;
using FlatRedBall.Graphics;
using Gum.DataTypes;
using Gum.Wireframe;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RenderingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GumRuntime;
using Gum.Managers;
using Gum.DataTypes.Variables;

namespace FlatRedBall.Gum
{
    public partial class GumIdb : IDrawableBatch, RenderingLibrary.Graphics.IVisible
    {
        #region Fields

        static SystemManagers mManagers;

        //The project file can be common across multiple instances of the IDB.
        static string mProjectFileName;

        static Dictionary<FlatRedBall.Graphics.Layer, List<RenderingLibrary.Graphics.Layer>> mFrbToGumLayers = 
            new Dictionary<FlatRedBall.Graphics.Layer, List<RenderingLibrary.Graphics.Layer>>();

        GraphicalUiElement element;

        #endregion

        #region Properties

        public bool Visible
        {
            get
            {
                return element.Visible;
            }
            set
            {
                element.Visible = value;
            }
        }

        public GraphicalUiElement Element
        {
            get
            {
                return element;
            }
        }

        public bool UpdateEveryFrame
        {
            get { return true; }
        }

        public float X
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float Y
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float Z
        {
            get;
            set;
        }

        #endregion

        #region Public Functions
        public GumIdb()
        {

        }

        public void AssignReferences()
        {
            this.element.AssignReferences();
        }

        public static void StaticInitialize(string projectFileName)
        {
            if (mManagers == null)
            {
                mManagers = new SystemManagers();
                mManagers.Initialize(FlatRedBallServices.GraphicsDevice);
                mManagers.Renderer.Camera.AbsoluteLeft = 0;
                mManagers.Renderer.Camera.AbsoluteTop = 0;

                var viewport = mManagers.Renderer.GraphicsDevice.Viewport;
                viewport.Width = FlatRedBall.Math.MathFunctions.RoundToInt(FlatRedBall.Camera.Main.DestinationRectangle.Width);
                viewport.Height = FlatRedBall.Math.MathFunctions.RoundToInt(FlatRedBall.Camera.Main.DestinationRectangle.Height);
                mManagers.Renderer.GraphicsDevice.Viewport = viewport;

                GraphicalUiElement.CanvasHeight = FlatRedBall.Camera.Main.OrthogonalHeight;
                GraphicalUiElement.CanvasWidth = FlatRedBall.Camera.Main.OrthogonalWidth;


                // Need to do the zoom here in response to the FRB camera vs. the Gum camera
                mManagers.Renderer.Camera.Zoom = viewport.Height / (float)GraphicalUiElement.CanvasHeight;
                mManagers.Renderer.Camera.CameraCenterOnScreen = CameraCenterOnScreen.TopLeft;
                mManagers.Renderer.Camera.X = 0;
                mManagers.Renderer.Camera.Y = 0;

                SystemManagers.Default = mManagers;
                FlatRedBallServices.AddManager(RenderingLibrary.SystemManagers.Default);

                RenderingLibrary.Graphics.Text.RenderBoundaryDefault = false;


            }

            if (projectFileName == null)
            {
                throw new Exception("The GumIDB must be initialized with a valid (non-null) project file.");
            }

            string errors;
            mProjectFileName = projectFileName;

            if (FlatRedBall.IO.FileManager.IsRelative(mProjectFileName))
            {
                mProjectFileName = FlatRedBall.IO.FileManager.RelativeDirectory + mProjectFileName;
            }

            // First let's set the relative directory to the file manager's relative directory so we can load
            // the file normally...
            ToolsUtilities.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;

            ObjectFinder.Self.GumProjectSave = GumProjectSave.Load(projectFileName, out errors);

#if DEBUG
            if(ObjectFinder.Self.GumProjectSave == null)
            {
                throw new Exception("Could not find Gum project at " + projectFileName);
            }
#endif

            // Now we can set the directory to Gum's root:
            ToolsUtilities.FileManager.RelativeDirectory = ToolsUtilities.FileManager.GetDirectory(mProjectFileName);

            // The Gum tool does a lot more init than this, but we're going to only do a subset 
            //of initialization for performance
            // reasons:
            foreach (var item in ObjectFinder.Self.GumProjectSave.Screens)
            {
                // Only initialize using the default state
                if (item.DefaultState != null)
                {
                    item.Initialize(item.DefaultState);
                }
            }
            foreach (var item in ObjectFinder.Self.GumProjectSave.Components)
            {
                // Only initialize using the default state
                if (item.DefaultState != null)
                {
                    item.Initialize(item.DefaultState);
                }
            }
            foreach (var item in ObjectFinder.Self.GumProjectSave.StandardElements)
            {
                // Only initialize using the default state
                if (item.DefaultState != null)
                {
                    item.Initialize(item.DefaultState);
                }
            }

            StandardElementsManager.Self.Initialize();
        }

        public void LoadFromFile(string fileName)
        {
            if (mProjectFileName == null || ObjectFinder.Self.GumProjectSave == null)
            {
                throw new Exception("The GumIDB must be initialized with a project file before loading any components/screens.  Make sure you have a .gumx project file in your global content, or call StaticInitialize in code first.");
            }

            string oldDir = ToolsUtilities.FileManager.RelativeDirectory;
            string oldFrbDir = FlatRedBall.IO.FileManager.RelativeDirectory;

            ToolsUtilities.FileManager.RelativeDirectory = ToolsUtilities.FileManager.GetDirectory(mProjectFileName);

            ElementSave elementSave = null;
            string extension = ToolsUtilities.FileManager.GetExtension(fileName);
            if (extension == GumProjectSave.ComponentExtension)
            {
                elementSave = FlatRedBall.IO.FileManager.XmlDeserialize<ComponentSave>(fileName);
            }
            else if (extension == GumProjectSave.ScreenExtension)
            {
                elementSave = FlatRedBall.IO.FileManager.XmlDeserialize<ScreenSave>(fileName);
            }
            else if (extension == GumProjectSave.StandardExtension)
            {
                elementSave = FlatRedBall.IO.FileManager.XmlDeserialize<StandardElementSave>(fileName);
            }

            // Set this *after* the deserialization happens.  The fileName is relative to FRB's relative directory but
            // contained file references won't be.
            FlatRedBall.IO.FileManager.RelativeDirectory = ToolsUtilities.FileManager.GetDirectory(mProjectFileName);


            foreach (var state in elementSave.States)
            {
                state.Initialize();
                state.ParentContainer = elementSave;
            }

            foreach (var instance in elementSave.Instances)
            {
                instance.ParentContainer = elementSave;
            }


            element = elementSave.ToGraphicalUiElement(mManagers, false);
            element.ExplicitIVisibleParent = this;

            //Set the relative directory back once we are done
            ToolsUtilities.FileManager.RelativeDirectory = oldDir;
            FlatRedBall.IO.FileManager.RelativeDirectory = oldFrbDir;
        }

        public void InstanceInitialize()
        {
            AddToManagers();
            SpriteManager.AddDrawableBatch(this);
        }

        public void InstanceDestroy()
        {
            SpriteManager.RemoveDrawableBatch(this);
        }

        IPositionedSizedObject FindByName(string name)
        {
            if (element.Name == name)
            {
                return element;
            }
            return element.GetChildByName(name);
        }

        public GraphicalUiElement GetGraphicalUiElementByName(string name)
        {
            if (name == "this")
            {
                return element;
            }
            else
            {
                return element.GetGraphicalUiElementByName(name);
            }
        }

        public void AddGumLayerToFrbLayer(RenderingLibrary.Graphics.Layer gumLayer, FlatRedBall.Graphics.Layer frbLayer)
        {
            if (mFrbToGumLayers.ContainsKey(frbLayer) == false)
            {
                mFrbToGumLayers[frbLayer] = new List<RenderingLibrary.Graphics.Layer>();
            }

            mFrbToGumLayers[frbLayer].Add(gumLayer);
            SpriteManager.AddToLayerAllowDuplicateAdds(this, frbLayer);
        }

        public IEnumerable<RenderingLibrary.Graphics.Layer> GumLayersOnFrbLayer(FlatRedBall.Graphics.Layer frbLayer)
        {
            if (frbLayer == null)
            {
                yield return SystemManagers.Default.Renderer.MainLayer;
            }
            else if (mFrbToGumLayers.ContainsKey(frbLayer))
            {
                foreach (var item in mFrbToGumLayers[frbLayer])
                {
                    yield return item;
                }
            }
            else
            {
                yield break;
            }
        }
        #endregion

        #region Internal Functions
        protected void AddToManagers()
        {
            element.AddToManagers(mManagers, null);
        }
        #endregion

        #region IDrawableBatch
        public void Update()
        {
            mManagers.Activity(TimeManager.CurrentTime);
        }

        // Currently we only want one Gum call per frame, so we should
        // make sure that this doesn't happen multiple times
        double mLastDrawCall = double.NaN;

        public void Draw(FlatRedBall.Camera camera)
        {
            if (FlatRedBall.Graphics.Renderer.CurrentLayer == null)
            {
                mManagers.TextManager.RenderTextTextures();
                mManagers.Draw(mManagers.Renderer.MainLayer);
            }
            else if (mFrbToGumLayers.ContainsKey(FlatRedBall.Graphics.Renderer.CurrentLayer))
            {
                mManagers.Draw(mFrbToGumLayers[FlatRedBall.Graphics.Renderer.CurrentLayer]);
            }
        }

        public void Destroy()
        {
            element.RemoveFromManagers();
        }
        #endregion

        #region RenderingLibrary.Graphics.IVisible

        public bool AbsoluteVisible
        {
            get
            {
                if (Parent == null)
                {
                    // Maybe update this if we support parent relationships between IDBs
                    return Visible;
                }
                else if (Parent is RenderingLibrary.Graphics.IVisible)
                {
                    return Visible && ((RenderingLibrary.Graphics.IVisible)Parent).AbsoluteVisible;
                }
                else if (Parent is FlatRedBall.Graphics.IVisible)
                {
                    return Visible && ((FlatRedBall.Graphics.IVisible)Parent).AbsoluteVisible;
                }
                else
                {
                    return Visible;
                }
            }
        }

        public PositionedObject Parent
        {
            get;
            set;
        }

        RenderingLibrary.Graphics.IVisible RenderingLibrary.Graphics.IVisible.Parent
        {
            get
            {
                return this.Parent as RenderingLibrary.Graphics.IVisible;
            }
        }

        // temporary to allow Glue to attach.  Eventually I'll change how Glue generates this code
        public void CopyAbsoluteToRelative()
        {
            // do nothing
        }

        public void AttachTo(PositionedObject newParent, bool throwaway)
        {
            Parent = newParent;
        }

        #endregion
    }
}
