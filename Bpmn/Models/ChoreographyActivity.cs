/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SubChoreography))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ChoreographyTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CallChoreography))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("choreographyActivity", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public abstract partial class ChoreographyActivity : FlowNode {
    
    private System.Xml.XmlQualifiedName[] participantRefField;
    
    private CorrelationKey[] correlationKeyField;
    
    private System.Xml.XmlQualifiedName initiatingParticipantRefField;
    
    private ChoreographyLoopType loopTypeField;
    
    public ChoreographyActivity() {
        this.loopTypeField = ChoreographyLoopType.None;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("participantRef")]
    public System.Xml.XmlQualifiedName[] participantRef {
        get {
            return this.participantRefField;
        }
        set {
            this.participantRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("correlationKey")]
    public CorrelationKey[] correlationKey {
        get {
            return this.correlationKeyField;
        }
        set {
            this.correlationKeyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName initiatingParticipantRef {
        get {
            return this.initiatingParticipantRefField;
        }
        set {
            this.initiatingParticipantRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(ChoreographyLoopType.None)]
    public ChoreographyLoopType loopType {
        get {
            return this.loopTypeField;
        }
        set {
            this.loopTypeField = value;
        }
    }
}