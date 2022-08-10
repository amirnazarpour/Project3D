using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(InputPlayer))]
    public class ResizePlayer : MonoBehaviour
    {
        [SerializeField] private float Speed;

        private float Size;

        InputPlayer input;
        void Start()
        {
            input = GetComponent<InputPlayer>();
            input.Up += ScaleUp;
            input.Down += SacleDown;
            Size = transform.localScale.y;
        }
        public void ScaleUp()
        {
            Size += Time.deltaTime * Speed;
            if (Size > 2.7f)
            {
                Size = 2.7f;
            }
            transform.localScale = Vector3.right * transform.localScale.x + Vector3.up * Size + Vector3.forward * transform.localScale.z;
        }
        public void SacleDown()
        {
            Size -= Time.deltaTime * Speed;
            if (Size < 0.1f)
            {
                Size= 0.1f;
            }
            transform.localScale = Vector3.right * transform.localScale.x + Vector3.up * Size + Vector3.forward * transform.localScale.z;
        }
    }
}
