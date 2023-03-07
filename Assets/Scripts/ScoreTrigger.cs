using UnityEngine;

namespace Pong
{
    public class ScoreTrigger : MonoBehaviour
    {
        // Who gets the point.
        public bool isLeft;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            GameManager.instance.ScorePoint(!isLeft);
        }
    }

}
