using UnityEngine;

namespace SAE.GAD176.Scripting2.Project1.CharacterBondSystem
{
    public class CharacterStats : MonoBehaviour
    {
        [SerializeField]
        protected string characterName = "-1";
        [SerializeField]
        protected int characterBondTableID = -1;

        protected BondTable BondTable;
    }
    
}