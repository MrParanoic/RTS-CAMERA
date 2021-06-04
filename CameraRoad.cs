using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRoad : MonoBehaviour
{
    public float Speed = 200f;
    public float pabBort = 10f;
    [SerializeField] private float _scrollWheelSpeed;
    public Vector3 diraction;
    public Quaternion rotation;
    public float rotatoonQ;
    private void Start()
    {
    }
    void Update()
    {
        Vector3 posCam1 = transform.position;
        Vector3 mousePos = Input.mousePosition;
        if (Input.GetKey(KeyCode.W) || mousePos.y >= Screen.height - pabBort)
        {
            posCam1.z += Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) || mousePos.y <= pabBort)
        {
            posCam1.z -= Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) || mousePos.x >= Screen.width - pabBort)
        {
            posCam1.x += Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || mousePos.x <= pabBort)
        {
            posCam1.x -= Speed * Time.deltaTime;
        }
        transform.position = posCam1;
    }
}
