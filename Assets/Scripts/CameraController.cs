using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Camera camera;
    public Vector2 targetRes = new Vector2(1080, 1920);
    public float zoomRatio = 49;

    public float y; 

    private float lastCamSize = -1;


    public void CameraOrthographicSize()
    {
        {
            float scrnHeight = 800f;
            float scrnWidth = 480f;
            float targetRatio = targetRes.x / targetRes.y;
            scrnHeight = Screen.height;
            scrnWidth = Screen.width;
            float screenRatio = scrnWidth / scrnHeight;
            float oSize = targetRatio / screenRatio;
            float camSize = oSize * zoomRatio;
            if (camSize != lastCamSize)
            {
                camera.fieldOfView = camSize;
                lastCamSize = camSize;
                camera.transform.position = new Vector3(camera.transform.position.x,  y + oSize, camera.transform.position.z);
            }
            //backgroundTransform.localPosition = new Vector3(0, -Camera.main.orthographicSize, 10);
        }
    }
    private void Start()
    {
        CameraOrthographicSize();
    }
}


