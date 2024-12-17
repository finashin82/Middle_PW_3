using System.IO.Pipes;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    [SerializeField] private GameObject bullet;

    private Transform transformRay;

    private void Start()
    {
        transformRay = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Instantiate(bullet, transform.position, Quaternion.identity);
            Shoot();

        }
    }

    void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);

            //Instantiate(bullet, hit.point, Quaternion.LookRotation(hit.normal));

            var fire = Instantiate(bullet, transform.position, Quaternion.identity);

            Vector3 swipeDirection = new Vector3(hit.point.x, transform.position.y, hit.point.z);

            swipeDirection.Normalize();

            fire.GetComponent<Rigidbody>().linearVelocity = swipeDirection * 50;
            //fire.rigidbody.AddForce(swipeDirection * 5);
        }

    }
}
