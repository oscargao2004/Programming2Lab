using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float sensitivity = 1f;
    [SerializeField] Vector3 camOffset;
    [HideInInspector] public Transform camTrans;
    Transform targetTrans;
    public Quaternion camRotation;
    Quaternion newPos;
    float hMouse;
    float vMouse;

    void Start()
    {
        targetTrans = target.GetComponent<Transform>();
        camTrans = GetComponent<Transform>();
        
    }

    void Update()
    {
        GetMouseInput();
        FollowPlayer();
    }
    void LateUpdate()
    {
    }

    void FollowPlayer()
    {
        //camTrans.RotateAround(targetTrans.position, Vector3.up, hMouse * sensitivity);

        camTrans.LookAt(targetTrans.position);
        camOffset = camRotation * camOffset;
        camTrans.position = targetTrans.position + camOffset;

    }
    void GetMouseInput()
    {
        hMouse = Input.GetAxis("Mouse X");
        vMouse = Input.GetAxis("Mouse Y");

        camRotation = Quaternion.AngleAxis(hMouse * sensitivity, Vector3.up);
    }

}
