using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ʵ������ƶ��ӽǸ�������ƶ�
/// </summary>
public class FPSMouseLook : MonoBehaviour
{
    //��������ƶ��ٶ�
    public float MouseMoveSpeed;
    //���������Transform��Ϣ
    private Transform CameraTransform;
    //����roation����
    private Vector3 CameraRoation;
    //����̧ͷ�͵�ͷ�����Ƕ�
    public Vector2 MaxMinAngle;
     void Start()
    {
        //��ʼ��������Դ���Transform��Ϣ
        CameraTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        //��ȡ����ƶ��¼�
        float inputx = Input.GetAxis("Mouse X");
        float inputy = Input.GetAxis("Mouse Y");
        //�����˸� roation�ı��� ���ڼ���ͱ䶯
        CameraRoation.y += inputx * MouseMoveSpeed;
        CameraRoation.x -= inputy * MouseMoveSpeed;
        //�����ӽ���ߺ����ת���Ƕ�
        CameraRoation.x = Mathf.Clamp(CameraRoation.x,MaxMinAngle.x,MaxMinAngle.y);
        //������õ�roation ��ֵ�����
        CameraTransform.rotation = Quaternion.Euler(CameraRoation.x, CameraRoation.y,0);
    }
}
