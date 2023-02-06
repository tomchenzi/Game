using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 实现鼠标移动视角跟着鼠标移动
/// </summary>
public class FPSMouseLook : MonoBehaviour
{
    //定义鼠标移动速度
    public float MouseMoveSpeed;
    //定义组件的Transform信息
    private Transform CameraTransform;
    //定义roation变量
    private Vector3 CameraRoation;
    //定义抬头和低头的最大角度
    public Vector2 MaxMinAngle;
     void Start()
    {
        //初始化绑定组件自带的Transform信息
        CameraTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        //获取鼠标移动事假
        float inputx = Input.GetAxis("Mouse X");
        float inputy = Input.GetAxis("Mouse Y");
        //定义了个 roation的变量 用于计算和变动
        CameraRoation.y += inputx * MouseMoveSpeed;
        CameraRoation.x -= inputy * MouseMoveSpeed;
        //限制视角最高和最低转动角度
        CameraRoation.x = Mathf.Clamp(CameraRoation.x,MaxMinAngle.x,MaxMinAngle.y);
        //将计算好的roation 赋值给组件
        CameraTransform.rotation = Quaternion.Euler(CameraRoation.x, CameraRoation.y,0);
    }
}
