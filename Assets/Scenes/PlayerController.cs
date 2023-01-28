using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 target;
    public TextMeshProUGUI playerGoldText;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
        playerGoldText.text = "Gold: " + PlayerInventory.gold;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            PlayerInventory.gold += 1;
            playerGoldText.text = "Gold: " + PlayerInventory.gold;
            collision.gameObject.SetActive(false);
        }
    }
}
