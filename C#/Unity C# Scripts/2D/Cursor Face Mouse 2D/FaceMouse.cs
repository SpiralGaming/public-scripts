using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class FaceMouse : MonoBehaviour
{
    [SerializeField] int angleOffset;
    [SerializeField] GameObject Princess;
    [SerializeField] float speed;
    void Update()
    {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg + angleOffset;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
