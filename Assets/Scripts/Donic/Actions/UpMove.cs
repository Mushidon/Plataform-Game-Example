using Donic.Scripts.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace Donic.Scripts.Actions
{
    public class UpMove : IMove
    {
        private IPlayerMovement _player;

        public UpMove(IPlayerMovement player)
        {
            this._player = player;

        }


        public void Move()
        {
            this._player.MoveUp();
        }
    }
}
