using UnityEngine;

namespace MidtermExam.Prob01
{
    public  class Character : GameEntity
    {
        public string characterName;
        protected float moveSpeed;
        private int level;

        public virtual void Attack (GameEntity target)
        {
           
        }
        public virtual void LevelUp()
        {
            level = 1;
        }
    }
}
