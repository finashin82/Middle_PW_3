using UnityEngine;

public class TowerRotation : MonoBehaviour
{
    [SerializeField] private float rotationVel = 20f;

    private Vector3 rotationRight;

    private void Update()
    {
        RotationTowerButton();
    }

    private void RotationTowerButton()
    {
        // ������� ����� ������
        if (Input.GetKey(KeyCode.X))
        {            
            transform.Rotate(new Vector3(0, rotationVel * Time.deltaTime, 0));
        }
        // ������� ����� �����
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(new Vector3(0, -rotationVel * Time.deltaTime, 0));
        }
    }
}
