using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{
    private Rigidbody _rigidbody;
    public void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (isLocalPlayer)
        {
            Move();
            Rotation();
        }
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        _rigidbody.velocity = new Vector3(horizontal, 0f, vertical) * Time.deltaTime * 100;
    }

    private void Rotation()
    {
        Vector2 playerPositionOnScreen = Camera.main.WorldToScreenPoint(transform.position);
        Vector2 mousePositionOnScreen = Input.mousePosition;

        float angle = AngleBetweenTwoPoints(playerPositionOnScreen, mousePositionOnScreen);
        transform.rotation = Quaternion.Euler(new Vector3(0f, -angle, 0f));
    }

    private float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
