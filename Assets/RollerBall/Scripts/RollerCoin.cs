using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerCoin : MonoBehaviour
{
    public float amplitude;
    public float rate;
    public float spinRate;

    Vector3 initalPosition;
    float time;
    float angle;

    void Start()
    {
        time = Random.Range(0f, 5f);
        angle = Random.Range(0f, 160f);
        initalPosition = transform.position;
    }

    void Update()
    {
        time += Time.deltaTime * rate;
        angle += Time.deltaTime * spinRate;

        Vector3 offset = Vector3.up * Mathf.Sin(time * amplitude);
        transform.position = initalPosition + offset;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
    }
}
