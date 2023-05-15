/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("lane", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class Lane : BaseElement {
    
    private BaseElement partitionElementField;
    
    private string[] flowNodeRefField;
    
    private LaneSet childLaneSetField;
    
    private string nameField;
    
    private System.Xml.XmlQualifiedName partitionElementRefField;
    
    /// <remarks/>
    public BaseElement partitionElement {
        get {
            return this.partitionElementField;
        }
        set {
            this.partitionElementField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("flowNodeRef", DataType="IDREF")]
    public string[] flowNodeRef {
        get {
            return this.flowNodeRefField;
        }
        set {
            this.flowNodeRefField = value;
        }
    }
    
    /// <remarks/>
    public LaneSet childLaneSet {
        get {
            return this.childLaneSetField;
        }
        set {
            this.childLaneSetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName partitionElementRef {
        get {
            return this.partitionElementRefField;
        }
        set {
            this.partitionElementRefField = value;
        }
    }
}