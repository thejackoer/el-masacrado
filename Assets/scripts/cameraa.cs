using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraa : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public bool offsetbool;
    public bool cinvertida;

    public float rot;
    public Transform pivote;

    // Start is called before the first frame update
    void Start()
    {
        if (!offsetbool)
        {
            offset = target.position - transform.position;

        }
        pivote.transform.position = target.transform.position;
        pivote.transform.parent = target.transform;
       // Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("MouseX") * rot;
        target.Rotate(0, horizontal, 0);
        float vertical = Input.GetAxis("MouseY") * rot;

        if (cinvertida)
        {
            pivote.Rotate(vertical, 0, 0);

        }
        else
        {
            pivote.Rotate(-vertical, 0, 0);
        }

        if (pivote.rotation.eulerAngles.x > 45f && pivote.rotation.eulerAngles.x < 180f)
        {
            pivote.rotation = Quaternion.Euler(45f, 0, 0);
        }

        if (pivote.rotation.eulerAngles.x > 180f && pivote.rotation.eulerAngles.x < 315f)
        {
            pivote.rotation = Quaternion.Euler(315f, 0, 0);
        }

        float anguloy = target.eulerAngles.y;
        float angulox = pivote.eulerAngles.x;

        Quaternion rotation = Quaternion.Euler(angulox, anguloy, 0);
        transform.position = target.position - (rotation * offset);

        // transform.position = target.position - offset;

        if (transform.position.y < target.position.y)
        {
            transform.position = new Vector3(transform.position.x, target.position.y - 0.5f, transform.position.z);
        }

        transform.LookAt(target);
    }
}
