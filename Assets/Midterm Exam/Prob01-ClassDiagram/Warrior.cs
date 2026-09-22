using System;
using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Warrior : Hero
    {
        public int shieldDefense;
        private float rage;

        public override void Attack(GameEntity target)
        {
            
        }
        public void ShieldBash(GameEntity target)
        {
            target.TakeDamage(shieldDefense);
        }
        
        // TODO: Implement inheritance, fields and methods according to Class Diagram
    }
}
