using Donic.Scripts.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Player
{
    public class Player : MonoBehaviour, IPlayerMovement
    {
        [SerializeField] private float speed;
        private Rigidbody2D body;

        private float horizontalAxis;

        void Awake()
        {
            body = GetComponent<Rigidbody2D>();
            speed = 1;
        }

        void Update()
        {
            horizontalAxis = Input.GetAxis("Horizontal");
            if (horizontalAxis > 0)
                this.MoveRight();
            if (Input.GetKey(KeyCode.Space))
                this.MoveUp();
        }
        public void MoveUp()
        {
            body.velocity = new Vector2(body.velocity.x, speed);
        }

        public void MoveDown()
        {

        }

        public void MoveRight()
        {
            body.velocity = new Vector2(horizontalAxis * speed, body.velocity.y);
        }

        public void MoveLeft()
        {

        }
    }
}