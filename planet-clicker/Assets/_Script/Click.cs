using UnityEngine;
using UnityEngine.UI;

namespace _Script
{
    public class Click : MonoBehaviour
    {
        public int count;
        public Image image;

        private void Awake()
        {
            Set(1);
            ResetCount();
        }

        public void Plus()
        {
            count++;
        }

        public void ResetCount()
        {
            count = 0;
        }

        public void Set(int id)
        {
            image.sprite = null;
            var sprite = Resources.Load<Sprite>($"Images/csm_0{id}") ?? Resources.Load<Sprite>($"Images/csm_01");
            image.sprite = sprite;
            image.SetNativeSize();
        }
    }
}
