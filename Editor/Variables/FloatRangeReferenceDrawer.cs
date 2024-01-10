using UnityEditor;
using AAA.GlobalVariables.Variables;

namespace AAA.GlobalVariables.Editor.Variables
{
    [CustomPropertyDrawer(typeof(FloatRangeReference))]
    public class FloatRangeReferenceDrawer : GlobalVariableReferenceDrawer { }
}