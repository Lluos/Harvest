using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public float interactionRadius = 1f; 
    public LayerMask playerLayer;
    public int fruitPrice = 10;

    void Update()
    {
        Collider2D playerCollider = Physics2D.OverlapCircle(transform.position, interactionRadius, playerLayer);

        if (playerCollider != null)
        {
            PlayerInventory playerInventory = playerCollider.GetComponent<PlayerInventory>();

            if (playerInventory != null)
            {
                SellFruits(playerInventory);
            }
        }
    }

    private void SellFruits(PlayerInventory inventory)
    {
        int fruitsToSell = inventory.redFruit;
        if (fruitsToSell > 0)
        {
            int totalAmount = fruitsToSell * fruitPrice;
            inventory.AddMoney(totalAmount);
            inventory.redFruit = 0;
            inventory.RedFruitText.text = inventory.redFruit.ToString();
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, interactionRadius);
    }
}
