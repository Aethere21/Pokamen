using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokamen
{
    public static class GlobalVariables
    {
        static EntityInfo mEntityInfo = new EntityInfo();
        public static EntityInfo EntityInfo
        {
            get { return mEntityInfo; }
        }
    }
}
