using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private float speed = 30;
    private PlayerController playercontrollerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playercontrollerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playercontrollerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
