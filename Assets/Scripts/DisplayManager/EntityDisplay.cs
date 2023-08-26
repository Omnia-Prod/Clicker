using TMPro;
using UnityEngine;

namespace DisplayManager {

    public class EntityDisplay<T> : MonoBehaviour where T: Entity 
    {
        //public TMP_Text TDamage;
            public TMP_Text THPPhysic;
            public TMP_Text THPMagic;
            
            public T Ent { get; set; }
            
            public void Display()
            {
                THPPhysic.text = Ent.HpPhysic.ToString();
                THPMagic.text = Ent.HpMagic.ToString();
            }
    }
}