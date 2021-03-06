using System;
using System.Reflection;
using UnityEngine;
using UnityEditor.UIElements;
using UnityEditor.Graphing;
using UnityEditor.ShaderGraph.Drawing;
using UnityEditor.Graphing.Util;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine.UIElements;

namespace UnityEditor.ShaderGraph.Drawing.Inspector.PropertyDrawers
{
    [SGPropertyDrawer(typeof(SampleTexture2DArrayNode))]
    class SampleTexture2DArrayNodePropertyDrawer : AbstractMaterialNodePropertyDrawer
    {
        internal override void AddCustomNodeProperties(VisualElement parentElement, AbstractMaterialNode nodeBase, Action setNodesAsDirtyCallback, Action updateNodeViewsCallback)
        {
            var node = nodeBase as SampleTexture2DArrayNode;
            PropertyDrawerUtils.AddCustomCheckboxProperty(
                parentElement, nodeBase, setNodesAsDirtyCallback, updateNodeViewsCallback,
                "Disable Global Mip Bias", "Change Disable Global Mip Bias",
                () => node.disableGlobalMipBias, (val) => node.disableGlobalMipBias = val);
        }
    }
}
