using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    public GameObject gameoverpanel;
    public float moveSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveEnemy());
    }

    IEnumerator MoveEnemy()
    {
        while (true)
        {
            Vector3 targetPosition = new Vector3(transform.position.x, transform.position.y - 1f, transform.position.z);
            float elapsedTime = 0f;

            while (elapsedTime < 2f)
            {
                transform.position = Vector3.Lerp(transform.position, targetPosition, (elapsedTime / 2f) * moveSpeed);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            yield return new WaitForSeconds(1f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            gameoverpanel.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (collision.CompareTag("Bounds"))
        {
            gameoverpanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
