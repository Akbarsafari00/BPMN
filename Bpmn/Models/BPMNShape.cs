#nullable disable
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/DI")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/DI", IsNullable=false)]
public partial class BPMNShape : LabeledShape {
    
    private BPMNLabel bPMNLabelField;
    
    private System.Xml.XmlQualifiedName bpmnElementField;
    
    private bool isHorizontalField;
    
    private bool isHorizontalFieldSpecified;
    
    private bool isExpandedField;
    
    private bool isExpandedFieldSpecified;
    
    private bool isMarkerVisibleField;
    
    private bool isMarkerVisibleFieldSpecified;
    
    private bool isMessageVisibleField;
    
    private bool isMessageVisibleFieldSpecified;
    
    private ParticipantBandKind participantBandKindField;
    
    private bool participantBandKindFieldSpecified;
    
    private System.Xml.XmlQualifiedName choreographyActivityShapeField;
    
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
    public bool isHorizontal {
        get {
            return this.isHorizontalField;
        }
        set {
            this.isHorizontalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isHorizontalSpecified {
        get {
            return this.isHorizontalFieldSpecified;
        }
        set {
            this.isHorizontalFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isExpanded {
        get {
            return this.isExpandedField;
        }
        set {
            this.isExpandedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isExpandedSpecified {
        get {
            return this.isExpandedFieldSpecified;
        }
        set {
            this.isExpandedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isMarkerVisible {
        get {
            return this.isMarkerVisibleField;
        }
        set {
            this.isMarkerVisibleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isMarkerVisibleSpecified {
        get {
            return this.isMarkerVisibleFieldSpecified;
        }
        set {
            this.isMarkerVisibleFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isMessageVisible {
        get {
            return this.isMessageVisibleField;
        }
        set {
            this.isMessageVisibleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isMessageVisibleSpecified {
        get {
            return this.isMessageVisibleFieldSpecified;
        }
        set {
            this.isMessageVisibleFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ParticipantBandKind participantBandKind {
        get {
            return this.participantBandKindField;
        }
        set {
            this.participantBandKindField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool participantBandKindSpecified {
        get {
            return this.participantBandKindFieldSpecified;
        }
        set {
            this.participantBandKindFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName choreographyActivityShape {
        get {
            return this.choreographyActivityShapeField;
        }
        set {
            this.choreographyActivityShapeField = value;
        }
    }
}