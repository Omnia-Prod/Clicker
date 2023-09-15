using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace DisplayManager {

    public class EntityDisplay<T> : MonoBehaviour where T: Entity 
    {
        //public TMP_Text TDamage;
            public TMP_Text thpPhysic;
            public TMP_Text thpMagic;
            
            public T Ent { get; set; }
            
            public void Display()
            {
                thpPhysic.text = Ent.HpPhysic.ToString();
                thpMagic.text = Ent.HpMagic.ToString();
            }
    }
}