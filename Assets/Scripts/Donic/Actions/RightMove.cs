using Donic.Scripts.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace Donic.Scripts.Actions
{
    public class RightMove : IMove
    {
        private IPlayerMovement _player;

        public RightMove(IPlayerMovement player)
        {
            this._player = player;

        }


        public void Move()
        {
            this._player.MoveRight();
        }
    }
}
