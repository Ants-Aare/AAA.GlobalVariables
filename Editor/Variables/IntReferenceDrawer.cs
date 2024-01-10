using UnityEditor;
using AAA.GlobalVariables.Variables;

namespace AAA.GlobalVariables.Editor.Variables
{
    [CustomPropertyDrawer(typeof(IntReference))]
    public class IntReferenceDrawer : GlobalVariableReferenceDrawer { }
}