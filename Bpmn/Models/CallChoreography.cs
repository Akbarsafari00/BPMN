/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("callChoreography", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class CallChoreography : ChoreographyActivity {
    
    private ParticipantAssociation[] participantAssociationField;
    
    private System.Xml.XmlQualifiedName calledChoreographyRefField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("participantAssociation")]
    public ParticipantAssociation[] participantAssociation {
        get {
            return this.participantAssociationField;
        }
        set {
            this.participantAssociationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName calledChoreographyRef {
        get {
            return this.calledChoreographyRefField;
        }
        set {
            this.calledChoreographyRefField = value;
        }
    }
}