namespace Tilia.CameraRigs.UnityXR
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine.XR;
    using Zinnia.Extension;
    using Zinnia.Tracking.CameraRig;

    /// <summary>
    /// Provides the description for a UnityXR CameraRig node element.
    /// </summary>
    public class UnityXRNodeRecord : BaseDeviceDetailsRecord
    {
        /// <summary>
        /// The Node Type for the record.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public XRNode NodeType { get; set; }

        /// <inheritdoc/>
        public override XRNode XRNodeType { get { return NodeType; } protected set { NodeType = value; } }

        /// <inheritdoc/>
        public override int Priority { get => 0; protected set => throw new System.NotImplementedException(); }

        /// <summary>
        /// Sets the <see cref="NodeType"/>.
        /// </summary>
        /// <param name="index">The index of the <see cref="XRNode"/>.</param>
        public virtual void SetNodeType(int index)
        {
            NodeType = EnumExtensions.GetByIndex<XRNode>(index);
        }
    }
}