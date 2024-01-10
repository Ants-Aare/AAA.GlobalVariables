using UnityEditor;
using AAA.GlobalVariables.Variables;

namespace AAA.GlobalVariables.Editor.Variables
{
    [CustomPropertyDrawer(typeof(StringReference))]
    public class StringReferenceDrawer : GlobalVariableReferenceDrawer { }
}