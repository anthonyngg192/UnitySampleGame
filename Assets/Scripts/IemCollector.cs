using UnityEngine;
using UnityEngine.UI;

public class IemCollector : MonoBehaviour
{

    private int cherries = 0;

    [SerializeField] private Text cherriesText;

    [SerializeField] private AudioSource itemCollectEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Cherries: " + cherries;
            itemCollectEffect.Play();
        }
    }
}
