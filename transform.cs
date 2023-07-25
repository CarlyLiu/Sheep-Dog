using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (rb.velocity.magnitude > 0.1f) // 检查物体的速度是否大于一个阈值，以确定其是否在移动
        {
            Vector3 direction = rb.velocity.normalized; // 获取物体的归一化速度向量
            transform.rotation = Quaternion.LookRotation(direction); // 使物体面向运动方向
        }
    }
}

