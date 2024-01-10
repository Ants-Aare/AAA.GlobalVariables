using UnityEngine;

namespace AAA.GlobalVariables.Variables
{
    [CreateAssetMenu(menuName = "AAA/Variable/Bool Variable")]
    public class BoolVariable : GlobalVariable<bool, BoolVariable>
    {
#if UNITTY_EDITOR
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        public static void DomainReload() => GenericDomainReload();
#endif

        protected override void SaveVariable() => PlayerPrefs.SetInt(name, value ? 1 : 0);
        protected override void LoadVariable() => value = PlayerPrefs.GetInt(name) == 1;
    }
}