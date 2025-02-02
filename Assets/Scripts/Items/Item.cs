using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public static int itemCount = 0;

    private void OnCollisionEnter2D(Collision2D collision) {
        CharacterControl characterControl = collision.gameObject.GetComponent<CharacterControl>();
        itemCount++;
        if (characterControl != null) {
            ItemAction(characterControl);
            Destroy(gameObject);
        }
    }

    private protected virtual void ItemAction(CharacterControl characterControl) {
        Debug.Log("Entered ItemAction for Item");
    }
}
