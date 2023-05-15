/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("participant", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class Participant : BaseElement {
    
    private System.Xml.XmlQualifiedName[] interfaceRefField;
    
    private System.Xml.XmlQualifiedName[] endPointRefField;
    
    private ParticipantMultiplicity participantMultiplicityField;
    
    private string nameField;
    
    private System.Xml.XmlQualifiedName processRefField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("interfaceRef")]
    public System.Xml.XmlQualifiedName[] interfaceRef {
        get {
            return this.interfaceRefField;
        }
        set {
            this.interfaceRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("endPointRef")]
    public System.Xml.XmlQualifiedName[] endPointRef {
        get {
            return this.endPointRefField;
        }
        set {
            this.endPointRefField = value;
        }
    }
    
    /// <remarks/>
    public ParticipantMultiplicity participantMultiplicity {
        get {
            return this.participantMultiplicityField;
        }
        set {
            this.participantMultiplicityField = value;
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
    public System.Xml.XmlQualifiedName processRef {
        get {
            return this.processRefField;
        }
        set {
            this.processRefField = value;
        }
    }
}