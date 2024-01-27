using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public GameObject prefabToShoot;
    public float shootForce = 100f;
    public GameObject ShootingPosition;
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = new Vector2(Input.GetAxis("Horizontal") * 5, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootPrefab();
        }
    }
    void ShootPrefab()
    {
        GameObject prefabInstance = Instantiate(prefabToShoot, ShootingPosition.transform.position, Quaternion.identity);
        Rigidbody2D rb = prefabInstance.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.AddForce(-transform.up * shootForce, ForceMode2D.Impulse);
        }
        else
        {
            Debug.LogError("Prefab is missing Rigidbody2D component!");
        }
    }
}
