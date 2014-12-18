#region Usings

using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;

using FlatRedBall.Graphics.Model;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Math.Splines;

using Cursor = FlatRedBall.Gui.Cursor;
using GuiManager = FlatRedBall.Gui.GuiManager;
using FlatRedBall.Localization;

#if FRB_XNA || SILVERLIGHT
using Keys = Microsoft.Xna.Framework.Input.Keys;
using Vector3 = Microsoft.Xna.Framework.Vector3;
using Texture2D = Microsoft.Xna.Framework.Graphics.Texture2D;
#endif
#endregion

namespace Pokamen.Screens
{
    public partial class GameScreen
    {
        //Used for option selection and positioning of the cursor in the small menu
        //1 = Attack
        //2 = Defend
        //3 = Do Nothing
        private int cursorIndex;

        void CustomInitialize()
        {
            //Make the mouse visible, because why not...
            FlatRedBallServices.Game.IsMouseVisible = true;
            //Set cursorIndex to 1, first option
            cursorIndex = 1;
            //Make the player move first
            GlobalVariables.EntityInfo.PlayerTurn = true;
        }

        void CustomActivity(bool firstTimeCalled)
        {
            //If players turn
            if (GlobalVariables.EntityInfo.PlayerTurn)
            {
                CursorControl();
            }
            //If enemies turn
            else 
            {
                EnemyMovement();
            }
        }

        void CustomDestroy()
        {


        }

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

        private void CursorControl()
        {
            UpdateCursorPosition();
            //If up key is released and the index is bigger than 1, subtract 1 from it and move up.
            if (InputManager.Keyboard.KeyReleased(Keys.Up))
            {
                if (cursorIndex > 1)
                {
                    cursorIndex--;
                }
            }
            //If down key is released and the index is smalled than 3, add 1 to it and move down
            else if (InputManager.Keyboard.KeyReleased(Keys.Down))
            {
                if (cursorIndex < 3)
                {
                    cursorIndex++;
                }
            }
            else if (InputManager.Keyboard.KeyReleased(Keys.Enter) || InputManager.Keyboard.KeyReleased(Keys.Space))
            {
                GlobalVariables.EntityInfo.PlayerDefending = false;
                switch (cursorIndex)
                {
                    case 1:
                        Attack(true);
                        //Set enemy turn
                        GlobalVariables.EntityInfo.PlayerTurn = false;
                        break;
                    case 2:
                        Defend(true);
                        //Set enemy turn
                        GlobalVariables.EntityInfo.PlayerTurn = false;
                        break;
                    case 3:
                        GlobalVariables.EntityInfo.PlayerTurn = false;
                        break;
                }
            }
        }

        private void UpdateCursorPosition()
        {
            //Set the position of the cursor based on the index.
            switch (cursorIndex)
            {
                case 1:
                    CursorEntityInstance.Y = -177;
                    break;
                case 2:
                    CursorEntityInstance.Y = -215;
                    break;
                case 3:
                    CursorEntityInstance.Y = -254;
                    break;
            }
        }

        private void Attack(bool player)
        {
            //If Player Attacking
            if (player)
            {
                Entities.AttackPlayer bullet = Factories.AttackPlayerFactory.CreateNew();
                bullet.Position.X = PlayerInstance.Position.X;
                bullet.Position.Y = PlayerInstance.Position.Y;
                //Use some trigonometry I dont understand to make the bullet rotate towards the enemy
                float YDistance = bullet.Position.Y - EnemyInstance.Position.Y;
                float XDistance = bullet.Position.X - EnemyInstance.Position.X;
                bullet.RotationZ = (float)Math.Atan2(YDistance, XDistance) + (float)(Math.PI * 0.5f) + 0.4f;
                //Make the bullet move toward the enemy
                bullet.Velocity = new Vector3(EnemyInstance.Position.X - bullet.Position.X, EnemyInstance.Position.Y - bullet.Position.Y, 0);
            }
            //If enemy attacking
            else
            {
                Entities.AttackEnemy bullet = Factories.AttackEnemyFactory.CreateNew();
                bullet.Position.X = EnemyInstance.Position.X;
                bullet.Position.Y = EnemyInstance.Position.Y;
                //rotation
                float YDistance = bullet.Position.Y - PlayerInstance.Position.Y;
                float XDistance = bullet.Position.Y - PlayerInstance.Position.X;
                //-2.95f because texture not rotated correctly from start, causing rotation pointed towards not be correct... meaning I shouldnt really use this method.. eh.
                bullet.RotationZ = (float)Math.Atan2(YDistance, XDistance) + (float)(Math.PI * 0.5f) - 2.95f;
                //Bullte movement
                bullet.Velocity = new Vector3(PlayerInstance.Position.X - bullet.Position.X, PlayerInstance.Position.Y - bullet.Position.Y, 0);
            }
        }

        private void Defend(bool player)
        {
            //Player defending
            if (player)
            {
                GlobalVariables.EntityInfo.PlayerDefending = true;
            }
            //Enemy defending
            else
            {
                GlobalVariables.EntityInfo.EnemyDefending = true;
            }
        }

        const double MoveTime = 3.5;
        double LastTimeMoved = 0;
        private void EnemyMovement()
        {
            if (PauseAdjustedSecondsSince(MoveTime) >= MoveTime)
            {
                //LastTimeMoved = 0;
                GlobalVariables.EntityInfo.EnemyDefending = false;
                //Generate random number to randomize movement
                int RandomMove = FlatRedBallServices.Random.Next(100);
                //Attack
                if (RandomMove <= 50)
                {
                    Attack(false);
                    GlobalVariables.EntityInfo.PlayerTurn = true;
                    LastEnemyMoveText.Text = "Last Enemy Move: Attack";
                }
                //Defend
                else if (RandomMove >= 50 && RandomMove <= 95)
                {
                    Attack(false);
                    //Defend(false);
                    GlobalVariables.EntityInfo.PlayerTurn = true;
                    LastEnemyMoveText.Text = "Last Enemy Move: Defend";
                }
                //Do nothing
                else if (RandomMove > 95)
                {
                    Attack(false);
                    //GlobalVariables.EntityInfo.PlayerTurn = true;
                    LastEnemyMoveText.Text = "Last Enemy Move: Do Nothing";
                }
            }
        }
    }
}
