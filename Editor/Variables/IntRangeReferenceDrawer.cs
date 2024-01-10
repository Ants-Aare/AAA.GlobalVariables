using UnityEditor;
using AAA.GlobalVariables.Variables;

namespace AAA.GlobalVariables.Editor.Variables
{
    [CustomPropertyDrawer(typeof(IntRangeReference))]
    public class IntRangeReferenceDrawer : GlobalVariableReferenceDrawer { }
}