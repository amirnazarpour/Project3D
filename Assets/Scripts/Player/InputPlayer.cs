using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class InputPlayer : MonoBehaviour
    {
        public Action Up;
        public Action Down;

        Vector3 last;
        void Update()
        {
            if (LogicCheck.IsPlay)
            {
                if (UnityEngine.Input.GetKey(KeyCode.UpArrow))
                {
                    Up();
                }
                if (UnityEngine.Input.GetKey(KeyCode.DownArrow))
                {
                    Down();
                }

                if (Input.GetMouseButton(0))
                {
                    Vector3 mouse = Input.mousePosition;
                    if (last != mouse)
                    {
                        if (mouse.y > last.y)
                        {
                            Up();
                        }
                        else
                        {
                            Down();
                        }
                        last = mouse;
                    }
                }
            }

        }
    }
}
