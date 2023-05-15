/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("participantAssociation", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class ParticipantAssociation : BaseElement {
    
    private System.Xml.XmlQualifiedName innerParticipantRefField;
    
    private System.Xml.XmlQualifiedName outerParticipantRefField;
    
    /// <remarks/>
    public System.Xml.XmlQualifiedName innerParticipantRef {
        get {
            return this.innerParticipantRefField;
        }
        set {
            this.innerParticipantRefField = value;
        }
    }
    
    /// <remarks/>
    public System.Xml.XmlQualifiedName outerParticipantRef {
        get {
            return this.outerParticipantRefField;
        }
        set {
            this.outerParticipantRefField = value;
        }
    }
}