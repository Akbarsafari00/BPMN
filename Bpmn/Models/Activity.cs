#nullable disable
/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Task))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(UserTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SendTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ScriptTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReceiveTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessRuleTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SubProcess))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Transaction))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AdHocSubProcess))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CallActivity))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("activity", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public abstract partial class Activity : FlowNode {
    
    private InputOutputSpecification ioSpecificationField;
    
    private Property[] propertyField;
    
    private DataInputAssociation[] dataInputAssociationField;
    
    private DataOutputAssociation[] dataOutputAssociationField;
    
    private ResourceRole[] itemsField;
    
    private LoopCharacteristics itemField;
    
    private bool isForCompensationField;
    
    private string startQuantityField;
    
    private string completionQuantityField;
    
    private string defaultField;
    
    public Activity() {
        this.isForCompensationField = false;
        this.startQuantityField = "1";
        this.completionQuantityField = "1";
    }
    
    /// <remarks/>
    public InputOutputSpecification ioSpecification {
        get {
            return this.ioSpecificationField;
        }
        set {
            this.ioSpecificationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("property")]
    public Property[] property {
        get {
            return this.propertyField;
        }
        set {
            this.propertyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("dataInputAssociation")]
    public DataInputAssociation[] dataInputAssociation {
        get {
            return this.dataInputAssociationField;
        }
        set {
            this.dataInputAssociationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("dataOutputAssociation")]
    public DataOutputAssociation[] dataOutputAssociation {
        get {
            return this.dataOutputAssociationField;
        }
        set {
            this.dataOutputAssociationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("performer", typeof(Performer))]
    [System.Xml.Serialization.XmlElementAttribute("resourceRole", typeof(ResourceRole))]
    public ResourceRole[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("loopCharacteristics", typeof(LoopCharacteristics))]
    [System.Xml.Serialization.XmlElementAttribute("multiInstanceLoopCharacteristics", typeof(MultiInstanceLoopCharacteristics))]
    [System.Xml.Serialization.XmlElementAttribute("standardLoopCharacteristics", typeof(StandardLoopCharacteristics))]
    public LoopCharacteristics Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool isForCompensation {
        get {
            return this.isForCompensationField;
        }
        set {
            this.isForCompensationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    [System.ComponentModel.DefaultValueAttribute("1")]
    public string startQuantity {
        get {
            return this.startQuantityField;
        }
        set {
            this.startQuantityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    [System.ComponentModel.DefaultValueAttribute("1")]
    public string completionQuantity {
        get {
            return this.completionQuantityField;
        }
        set {
            this.completionQuantityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
    public string @default {
        get {
            return this.defaultField;
        }
        set {
            this.defaultField = value;
        }
    }
}