using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokamen
{
    public static class GlobalVariables
    {
        //Create an instance of the class which stores variables for use in the game.
        static EntityInfo mEntityInfo = new EntityInfo();
        public static EntityInfo EntityInfo
        {
            get { return mEntityInfo; }
        }
    }
}
