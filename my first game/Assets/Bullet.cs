using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;    //ź���� �ӷ� 
    private Rigidbody bulletRigidbody;  // ź�˿� ���Ǵ� ���� ������Ʈ�� ������ ���� 


    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;       //transform.forward = vector3 (0f, 0f, 1f);

        Destroy(gameObject, 3.0f);      //3�� �ڿ� �ڽ��� �ı�

    }

    //Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼���
    void OnTriggerEnter(Collider other)
    {
        // �浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���
        if (other.tag == "Player")
        {
            // ���� ���� ������Ʈ���� PlayerController  ������Ʈ ��������
            Playercontroller1 playercontroller = other.GetComponent<Playercontroller1>();

            // �������κ��� PlayerController ������Ʈ�� �������µ� �����ߴٸ�
            if (playercontroller != null)
            {
                // ���� PlayerController ������Ʈ�� Die() �޼��� ����
                playercontroller.Die();
            }
        }
    }
}
