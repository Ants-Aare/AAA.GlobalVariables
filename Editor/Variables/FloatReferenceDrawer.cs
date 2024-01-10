using UnityEditor;
using AAA.GlobalVariables.Variables;

namespace AAA.GlobalVariables.Editor.Variables
{
    [CustomPropertyDrawer(typeof(FloatReference))]
    public class FloatReferenceDrawer : GlobalVariableReferenceDrawer { }
}