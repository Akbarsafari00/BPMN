#nullable disable
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

/// <remarks />
[XmlInclude(typeof(Task))]
[XmlInclude(typeof(UserTask))]
[XmlInclude(typeof(ServiceTask))]
[XmlInclude(typeof(SendTask))]
[XmlInclude(typeof(ScriptTask))]
[XmlInclude(typeof(ReceiveTask))]
[XmlInclude(typeof(ManualTask))]
[XmlInclude(typeof(BusinessRuleTask))]
[XmlInclude(typeof(SubProcess))]
[XmlInclude(typeof(Transaction))]
[XmlInclude(typeof(AdHocSubProcess))]
[XmlInclude(typeof(CallActivity))]
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
[XmlRoot("activity", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable = false)]
public abstract class Activity : FlowNode
{
    private string completionQuantityField;

    private DataInputAssociation[] dataInputAssociationField;

    private DataOutputAssociation[] dataOutputAssociationField;

    private string defaultField;

    private InputOutputSpecification ioSpecificationField;

    private bool isForCompensationField;

    private LoopCharacteristics itemField;

    private ResourceRole[] itemsField;

    private Property[] propertyField;

    private string startQuantityField;

    public Activity()
    {
        isForCompensationField = false;
        startQuantityField = "1";
        completionQuantityField = "1";
    }

    /// <remarks />
    public InputOutputSpecification ioSpecification
    {
        get => ioSpecificationField;
        set => ioSpecificationField = value;
    }

    /// <remarks />
    [XmlElement("property")]
    public Property[] property
    {
        get => propertyField;
        set => propertyField = value;
    }

    /// <remarks />
    [XmlElement("dataInputAssociation")]
    public DataInputAssociation[] dataInputAssociation
    {
        get => dataInputAssociationField;
        set => dataInputAssociationField = value;
    }

    /// <remarks />
    [XmlElement("dataOutputAssociation")]
    public DataOutputAssociation[] dataOutputAssociation
    {
        get => dataOutputAssociationField;
        set => dataOutputAssociationField = value;
    }

    /// <remarks />
    [XmlElement("performer", typeof(Performer))]
    [XmlElement("resourceRole", typeof(ResourceRole))]
    public ResourceRole[] Items
    {
        get => itemsField;
        set => itemsField = value;
    }

    /// <remarks />
    [XmlElement("loopCharacteristics", typeof(LoopCharacteristics))]
    [XmlElement("multiInstanceLoopCharacteristics", typeof(MultiInstanceLoopCharacteristics))]
    [XmlElement("standardLoopCharacteristics", typeof(StandardLoopCharacteristics))]
    public LoopCharacteristics Item
    {
        get => itemField;
        set => itemField = value;
    }

    /// <remarks />
    [XmlAttribute]
    [DefaultValue(false)]
    public bool isForCompensation
    {
        get => isForCompensationField;
        set => isForCompensationField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "integer")]
    [DefaultValue("1")]
    public string startQuantity
    {
        get => startQuantityField;
        set => startQuantityField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "integer")]
    [DefaultValue("1")]
    public string completionQuantity
    {
        get => completionQuantityField;
        set => completionQuantityField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "IDREF")]
    public string @default
    {
        get => defaultField;
        set => defaultField = value;
    }
}