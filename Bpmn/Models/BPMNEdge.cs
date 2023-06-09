#nullable disable
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/DI")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/DI", IsNullable=false)]
public partial class BPMNEdge : LabeledEdge {
    
    private BPMNLabel bPMNLabelField;
    
    private System.Xml.XmlQualifiedName bpmnElementField;
    
    private System.Xml.XmlQualifiedName sourceElementField;
    
    private System.Xml.XmlQualifiedName targetElementField;
    
    private MessageVisibleKind messageVisibleKindField;
    
    private bool messageVisibleKindFieldSpecified;
    
    /// <remarks/>
    public BPMNLabel BPMNLabel {
        get {
            return this.bPMNLabelField;
        }
        set {
            this.bPMNLabelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName bpmnElement {
        get {
            return this.bpmnElementField;
        }
        set {
            this.bpmnElementField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName sourceElement {
        get {
            return this.sourceElementField;
        }
        set {
            this.sourceElementField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName targetElement {
        get {
            return this.targetElementField;
        }
        set {
            this.targetElementField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public MessageVisibleKind messageVisibleKind {
        get {
            return this.messageVisibleKindField;
        }
        set {
            this.messageVisibleKindField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool messageVisibleKindSpecified {
        get {
            return this.messageVisibleKindFieldSpecified;
        }
        set {
            this.messageVisibleKindFieldSpecified = value;
        }
    }
}