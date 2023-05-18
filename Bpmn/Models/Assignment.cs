using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
[XmlRoot("assignment", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable = false)]
public class Assignment : BaseElement
{
    private Expression fromField;

    private Expression toField;

    /// <remarks />
    public Expression from
    {
        get => fromField;
        set => fromField = value;
    }

    /// <remarks />
    public Expression to
    {
        get => toField;
        set => toField = value;
    }
}