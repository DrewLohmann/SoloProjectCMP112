using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public enum SpellEffects
{
    projectile,
    beam,
    trigger,
    regen
}
public enum Triggers
{
    playerHit,
    playerKilled,
    enemyHit,
    enemyKilled
}


public class PlayerInventoryScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    class MagicData
    {
        int damage;
        int timeAlive;
        KeyCode keyToPress;
        List<SpellEffects> spellEffects;
        List<Triggers> triggers;
        Sprite idleSprite;
    };
    class InventoryData
    {
        int itemID = -1;
        void setData(int itemIdIn)
        {
            itemID = itemIdIn;
        }
        Sprite getSprite()
        {
            Sprite validSprite = null;

            return validSprite;
        }
    };

    List<InventoryData> Inventory;
    List<MagicData> Spells;

    void addItem(int pointInList, InventoryData data)
    {
        Inventory[pointInList] = data;
    }

    InventoryData getItem(int pointInList)
    { 
        return Inventory[pointInList];
    }

    void removeItem(int pointInList)
    {
        InventoryData emptyData = new InventoryData{ };
        Inventory[pointInList] = emptyData;
    }

    void modifyItem(int pointInList, InventoryData data)
    {
        Inventory[pointInList] = data;
    }
}
