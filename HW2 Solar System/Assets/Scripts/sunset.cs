using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunset : MonoBehaviour
{
    public Transform sun;
    public Transform mercury;
    public Transform venus;
    public Transform earth;
    public Transform mars;
    public Transform jupiter;
    public Transform saturn;
    public Transform uranus;
    public Transform neptune;
    
    // Use this for initialization
    Vector3[] a = new Vector3[9];
    float speed = 30;
    float y, z;
    void Start()
    {
        int i = 0;
        for (i = 0; i < 9; i++)
        {
            y = Random.Range(1, 360); // 随机设置角度
            z = Random.Range(1, 360); // 随机设置角度
            a[i] = new Vector3(0, y, z); // 以上是为了制造不同的运动法平面，修改y和z可以使得绕不同的轴转
        }
    }

    // Update is called once per frame
    void Update()
    { // 每个星球的旋转动作，用到了初始化的a[i]
        mercury.RotateAround(sun.position, a[0], 100 * Time.deltaTime);
        mercury.Rotate(Vector3.up * speed * Time.deltaTime);
        venus.RotateAround(sun.position, a[1], 40 * Time.deltaTime);
        venus.Rotate(Vector3.up * speed * Time.deltaTime);
        earth.RotateAround(sun.position, a[2], speed * Time.deltaTime);
        earth.Rotate(Vector3.up * speed * Time.deltaTime);
        mars.RotateAround(sun.position, a[3], 36 * Time.deltaTime);
        mars.Rotate(Vector3.up * speed * Time.deltaTime);
        jupiter.RotateAround(sun.position, a[4], 15 * Time.deltaTime);
        jupiter.Rotate(Vector3.up * speed * Time.deltaTime);
        saturn.RotateAround(sun.position, a[5], 9 * Time.deltaTime);
        saturn.Rotate(Vector3.up * speed * Time.deltaTime);
        uranus.RotateAround(sun.position, a[6], 20 * Time.deltaTime);
        uranus.Rotate(Vector3.up * speed * Time.deltaTime);
        neptune.RotateAround(sun.position, a[7], 5 * Time.deltaTime);
        neptune.Rotate(Vector3.up * speed * Time.deltaTime);
        sun.RotateAround(sun.position, a[0], 10 * Time.deltaTime);
        sun.Rotate(Vector3.up * speed * Time.deltaTime);

    }
}