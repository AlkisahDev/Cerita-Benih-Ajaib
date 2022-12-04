using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMainMenu : MonoBehaviour
{
    [SerializeField] float speed = 1;

    float time;

    public enum CameraPosition
    {
        Position1,
        Position2,
        Position3,
        Position4,
        Position5,
        Position6,
        Position7,
        Position8,
        Position9,
        Position10,
    }

    private CameraPosition currentPosition;

    private void Start()
    {
        currentPosition = CameraPosition.Position1;

    }

    public void Update()
    {
        time += Time.deltaTime;
        switch (currentPosition)
        {
            case CameraPosition.Position1:
                Debug.Log("Position 1");
                transform.Translate(Vector3.right * Time.deltaTime * speed);
                if (this.transform.position.x >= 97)
                {
                    currentPosition = CameraPosition.Position2;
                }
                return;

            case CameraPosition.Position2:
                Debug.Log("Position 2");
                transform.Translate(Vector3.down * Time.deltaTime * speed);
                if (this.transform.position.y <= -35)
                {
                    currentPosition = CameraPosition.Position3;
                }
                return;

            case CameraPosition.Position3:
                Debug.Log("Position 3");
                transform.Translate(Vector3.left * Time.deltaTime * speed);
                if (transform.position.x <= 42)
                {
                    currentPosition = CameraPosition.Position4;
                }
                return;

            case CameraPosition.Position4:
                Debug.Log("Position 4");
                transform.Translate(Vector3.down * Time.deltaTime * speed);
                if (transform.position.y <= -48)
                {
                    time = 0;
                    currentPosition = CameraPosition.Position5;
                }
                return;

            case CameraPosition.Position5:
                Debug.Log("Position 5");
                transform.Translate(Vector3.left * Time.deltaTime * speed);
                if (transform.position.x <= 3)
                {
                    time = 0;
                    currentPosition = CameraPosition.Position6;
                }
                return;

            case CameraPosition.Position6:
                Debug.Log("Position 6");
                transform.Translate(Vector3.up * Time.deltaTime * speed);
                if (transform.position.y >= -22)
                {
                    time = 0;
                    currentPosition = CameraPosition.Position7;
                }
                return;

            case CameraPosition.Position7:
                Debug.Log("Position 7");
                transform.Translate(Vector3.right * Time.deltaTime * speed);
                if (transform.position.x >= 72)
                {
                    time = 0;
                    currentPosition = CameraPosition.Position8;
                }
                return;

            case CameraPosition.Position8:
                Debug.Log("Position 8");
                transform.Translate(Vector3.up * Time.deltaTime * speed);
                if (transform.position.y >= -10)
                {
                    time = 0;
                    currentPosition = CameraPosition.Position9;
                }
                return;

            case CameraPosition.Position9:
                Debug.Log("Position 9");
                transform.Translate(Vector3.left * Time.deltaTime * speed);
                if (transform.position.x <= 0)
                {
                    time = 0;
                    currentPosition = CameraPosition.Position10;
                }
                return;

            case CameraPosition.Position10:
                Debug.Log("Position 10");
                transform.Translate(Vector3.up * Time.deltaTime * speed);
                if (transform.position.y >= 0)
                {
                    time = 0;
                    currentPosition = CameraPosition.Position1;
                }
                return;
        }
    }
}
