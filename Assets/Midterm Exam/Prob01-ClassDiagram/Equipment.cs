using UnityEngine;


namespace MidtermExam.Prob01
{
    public class Equipment : InventoryItem
    {
        public int durability;
        public bool isEquipped;
        public virtual void Equip(Hero hero)
        {
            isEquipped = true;
        }
        public override void Use(Character user)
        {

        }
        // TODO: Implement inheritance, fields and methods according to Class Diagram
    }
}
