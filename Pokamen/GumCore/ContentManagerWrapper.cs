using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlatRedBall.Gum
{
    public class ContentManagerWrapper : RenderingLibrary.Content.IContentLoader
    {
        public string ContentManagerName
        {
            get;
            set;
        }

        public T LoadContent<T>(string contentName)
        {
#if ANDROID
			contentName = contentName.ToLowerInvariant();
#endif
            return FlatRedBall.FlatRedBallServices.Load<T>(contentName, ContentManagerName);
        }
    }
}
