using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
[XmlRoot("association", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable = false)]
public class Association : Artifact
{
    private AssociationDirection associationDirectionField;

    private XmlQualifiedName sourceRefField;

    private XmlQualifiedName targetRefField;

    public Association()
    {
        associationDirectionField = AssociationDirection.None;
    }

    /// <remarks />
    [XmlAttribute]
    public XmlQualifiedName sourceRef
    {
        get => sourceRefField;
        set => sourceRefField = value;
    }

    /// <remarks />
    [XmlAttribute]
    public XmlQualifiedName targetRef
    {
        get => targetRefField;
        set => targetRefField = value;
    }

    /// <remarks />
    [XmlAttribute]
    [DefaultValue(AssociationDirection.None)]
    public AssociationDirection associationDirection
    {
        get => associationDirectionField;
        set => associationDirectionField = value;
    }
}