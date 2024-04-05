using UnityEngine;

public class ChangeGear : MonoBehaviour
{
    private Equipment equipment;

    private void Start()
    {
        equipment = GetComponent<Equipment>();
        //create equipment list
        equipment.InitializeEquipptedItemsList();
        //equip stuff
        // EquipItem("Legs", "pants");
    }

    public void EquipItem(string itemType, string itemSlug)
    {
        for (int i = 0; i < equipment.equippedItems.Count; i++)
        {
            if (equipment.equippedItems[i].ItemType == itemType)
            {
                equipment.equippedItems[i] = ItemDatabase.instance.FetchItemBySlug(itemSlug);
                equipment.AddEquipment(equipment.equippedItems[i]);
                break;
            }
        }
    }

    public void UnequipItem(string itemType, string itemSlug)
    {
        for (int i = 0; i < equipment.equippedItems.Count; i++)
        {
            if (equipment.equippedItems[i].ItemType == itemType)
            {
                equipment.RemoveEquipment(equipment.equippedItems[i]);
                break;
            }
        }
    }
}